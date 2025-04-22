using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DarkModeForms;
using Inventor;
using InventorAutomationProject;

namespace InventorAutomationProject
{
    public partial class CycloidGearPage : UserControl
    {
        private readonly Inventor.Application _invApp;
        public CycloidGearPage(InventorService inventorService)
        {
            InitializeComponent();
            _invApp = inventorService.InvApp;
        }

        private void CreateGear(double Dr, double dr, double N, double E, double a, double g)
        {
            try
            {
                Console.Log("Creating Cycloidal Gear...");

                // 1. Create part document
                string templateFilePath = _invApp.FileManager.GetTemplateFile(DocumentTypeEnum.kPartDocumentObject);
                PartDocument partDocument = (PartDocument)_invApp.Documents.Add(DocumentTypeEnum.kPartDocumentObject, templateFilePath, true);
                PartComponentDefinition compDef = partDocument.ComponentDefinition;

                // 2. Create sketch on XZ plane
                WorkPlane workPlane = compDef.WorkPlanes[3];
                PlanarSketch sketch = compDef.Sketches.Add(workPlane);
                TransientGeometry tg = _invApp.TransientGeometry;
                Console.Log("Sketch created.");

                // 3. Generate cycloidal curve points
                int numPoints = 360;
                double step = (2 * Math.PI) / numPoints;
                SketchPoint[] sketchPoints = new SketchPoint[numPoints];

                for (int i = 0; i < numPoints; i++)
                {
                    double phi = i * step;

                    // Compute gamma (if dynamic; can be passed as fixed value too)
                    double angle = (N - 1) * phi;
                    double numerator = Math.Sin(angle);
                    double denominator = Math.Cos(angle) - (Dr / (2 * E * N));
                    double gamma = Math.Atan2(numerator, denominator);

                    // Parametric equations
                    double x = (Dr / 2.0) * Math.Cos(phi) - (dr / 2.0) * Math.Cos(phi + gamma) - E * Math.Cos(N * phi);
                    double y = -(Dr / 2.0) * Math.Sin(phi) + (dr / 2.0) * Math.Sin(phi + gamma) + E * Math.Sin(N * phi);

                    sketchPoints[i] = sketch.SketchPoints.Add(tg.CreatePoint2d(x, y), false);
                }

                // 4. Create spline through points
                ObjectCollection splinePoints = _invApp.TransientObjects.CreateObjectCollection();
                foreach (SketchPoint pt in sketchPoints)
                    splinePoints.Add(pt);

                sketch.SketchSplines.Add(splinePoints);
                Console.Log("Spline created.");

                // 5. Close profile with a line between last and first points
                sketch.SketchLines.AddByTwoPoints(sketchPoints[numPoints - 1], sketchPoints[0]);

                // 6. Find profile to extrude
                Profile profile = sketch.Profiles.AddForSolid();

                // 7. Extrude the gear body
                double thickness = 1.0; // mm, change as needed
                compDef.Features.ExtrudeFeatures.AddByDistanceExtent(
                    profile,
                    thickness,
                    PartFeatureExtentDirectionEnum.kPositiveExtentDirection,
                    PartFeatureOperationEnum.kJoinOperation,
                    null
                );

                Console.Log("Gear extrusion completed.");
            }
            catch (Exception ex)
            {
                Console.Log("ERROR: " + ex.Message);
                Console.Log("ERROR DETAILS: " + ex.ToString());
            }
        }


        private void CycloidalGearButton_Click(object sender, EventArgs e)
        {
            try
            {
                double Dr = Convert.ToDouble(txtDr.Text);
                double dr = Convert.ToDouble(txt_dr.Text);
                double N = Convert.ToDouble(txt_N.Text);
                double E = Convert.ToDouble(txt_e.Text);
                double a = Convert.ToDouble(txt_a.Text);
                double phi = Math.PI / 6;  // φ in radians

                // Compute numerator and denominator
                double angle = (N - 1) * phi;
                double numerator = Math.Sin(angle);
                double denominator = Math.Cos(angle) - (Dr / (2 * E * N));

                // Compute gamma (correction angle)
                double g = Math.Atan(numerator / denominator); // result in radians

                CreateGear(Dr, dr, N, E, a, g);

            }
            catch (Exception ex)
            {
                Messenger.MessageBox($"An error occurred: {ex.Message}");
            }
        }


    }
}

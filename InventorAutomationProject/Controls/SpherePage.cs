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

namespace InventorAutomationProject
{
    public partial class SpherePage : UserControl
    {
        private readonly Inventor.Application _invApp;

        public SpherePage(InventorService inventorService)
        {
            InitializeComponent();
            _invApp = inventorService.InvApp;
        }


        private void CreateSphere(double radius)
        {
            try
            {
                Console.Log("Creating sphere with radius: " + radius);
                // Create a new part document
                Console.Log("Creating new part document...");
                // Get the template file path for a part document
                string templateFilePath = _invApp.FileManager.GetTemplateFile(DocumentTypeEnum.kPartDocumentObject);
                // Add a new part document using the template file path
                Document newDocument = _invApp.Documents.Add(DocumentTypeEnum.kPartDocumentObject, templateFilePath, true);
                // Cast the new document to a PartDocument
                PartDocument partDocument = (PartDocument)newDocument;
                PartComponentDefinition componentDefinition = partDocument.ComponentDefinition;
                Console.Log("Part document created successfully.");

                // Use the XZ plane (typically index 3, but safest to use Named WorkPlane)
                WorkPlane workPlane = componentDefinition.WorkPlanes[3];
                PlanarSketch sketch = componentDefinition.Sketches.Add(workPlane);
                Console.Log("Sketch created on XZ Plane.");

                // Transient geometry for point creation
                TransientGeometry tg = _invApp.TransientGeometry;

                // Define semicircle points
                Point2d center = tg.CreatePoint2d(0, 0);
                Point2d startPoint = tg.CreatePoint2d(radius, 0);
                Point2d endPoint = tg.CreatePoint2d(-radius, 0);

                // Draw full circle instead of semicircle + line
                SketchCircle circle = sketch.SketchCircles.AddByCenterRadius(center, radius);
                Console.Log("Circle drawn on sketch.");

                InventorService.SetHomeView(_invApp);

                // Create profile from closed sketch
                Profile profile = sketch.Profiles.AddForSolid();
                Console.Log("Profile created from sketch.");

                // Get Y axis for revolution
                SketchLine yAxis = sketch.SketchLines.AddByTwoPoints(
                    tg.CreatePoint2d(0, -radius * 1.5),
                    tg.CreatePoint2d(0, radius * 1.5)
                );
                Console.Log("Revolution axis created.");

                // Revolve profile around axis to create sphere
                RevolveFeature revolve = componentDefinition.Features.RevolveFeatures.AddFull(
                    profile,
                    yAxis,
                    PartFeatureOperationEnum.kNewBodyOperation
                );

                Console.Log("Sphere created successfully.");
            }
            catch (Exception ex)
            {
                Console.Log("ERROR: " + ex.Message);
                // If more detailed information is needed:
                Console.Log("ERROR DETAILS: " + ex.ToString());
                
            }
        }

        private void _CreateSphereButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                double radius = Convert.ToDouble(txtRadius.Text);
                CreateSphere(radius);
            }
            catch (FormatException)
            {
                Messenger.MessageBox("Please enter a valid number for the radius.");
            }
            catch (Exception ex)
            {
                Messenger.MessageBox($"An error occurred: {ex.Message}");
            }
        }
    }
}
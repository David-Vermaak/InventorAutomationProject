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
    public partial class CubePage : UserControl
    {
        private readonly Inventor.Application _invApp;

        public CubePage(InventorService inventorService)
        {
            InitializeComponent();
            _invApp = inventorService.InvApp;
        }


        private void CreateCube(double height, double width, double length)
        {
            Console.Log("Creating cube with dimensions: " + $"Height: {height}, Width: {width}, Length: {length}");
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
            PlanarSketch sketch = componentDefinition.Sketches.Add(componentDefinition.WorkPlanes[3]); // XY Plane
            Console.Log("Sketch created on XY Plane.");

            // Draw rectangle on sketch
            TransientGeometry tg = _invApp.TransientGeometry;
            sketch.SketchLines.AddAsTwoPointRectangle(
                tg.CreatePoint2d(0, 0),
                tg.CreatePoint2d(width, length)
            );
            Console.Log("Rectangle drawn on sketch.");

            // Profile and extrude
            Profile profile = sketch.Profiles.AddForSolid();
            ExtrudeDefinition extrudeDefinition = componentDefinition.Features.ExtrudeFeatures.CreateExtrudeDefinition(
                profile, PartFeatureOperationEnum.kJoinOperation);
            extrudeDefinition.SetDistanceExtent(height, PartFeatureExtentDirectionEnum.kPositiveExtentDirection);
            

            componentDefinition.Features.ExtrudeFeatures.Add(extrudeDefinition);
            Console.Log("Cube created successfully.");
            // Set camera view
            InventorService.SetHomeView(_invApp);
        }

        private void _CreateCubeButton_Click(object sender, EventArgs e)
        {
            try
            {
                double height = Convert.ToDouble(txtHeight.Text);
                double width = Convert.ToDouble(txtWidth.Text);
                double length = Convert.ToDouble(txtLength.Text);

                CreateCube(height, width, length);
            }
            catch (Exception ex)
            {
                Messenger.MessageBox("Error: " + ex.Message);
            }
        }
    }
}

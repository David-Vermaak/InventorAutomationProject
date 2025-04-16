using System;
//Imports System.Type
//Imports System.Activator
using System.Runtime.InteropServices;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
using System.Windows.Forms;
using DarkModeForms;
using Inventor;

namespace InventorAutomationProject
{
    public partial class Form1 : Form
    {
        Inventor.Application _invApp;
        bool _started = false;

        private DarkModeCS dm;

        public Form1()
        {
            InitializeComponent();
            dm = new DarkModeCS(this)
            {
                //[Optional] Choose your preferred color mode here:
                ColorMode = DarkModeCS.DisplayMode.SystemDefault
            };

            try
            {
                _invApp = (Inventor.Application)Marshal.GetActiveObject("Inventor.Application");

            }
            catch (Exception)
            {
                try
                {
                    Type invAppType = Type.GetTypeFromProgID("Inventor.Application");

                    _invApp = (Inventor.Application)System.Activator.CreateInstance(invAppType);
                    _invApp.Visible = true;

                    //Note: if the Inventor session is left running after this
                    //form is closed, there will still be an Inventor.exe 
                    //running. We will use this Boolean to test in Form1.Designer.cs 
                    //in the dispose method whether or not the Inventor App should
                    //be shut down when the form is closed.
                    _started = true;

                }
                catch (Exception ex2)
                {
                    MessageBox.Show(ex2.ToString());
                    MessageBox.Show("Unable to get or start Inventor");
                }
            }
        }

        private void CreateCube(double height, double width, double length)
        {
            // Create a new part document
            PartDocument partDoc = (PartDocument)_invApp.Documents.Add(DocumentTypeEnum.kPartDocumentObject,
                                                                            _invApp.FileManager.GetTemplateFile(DocumentTypeEnum.kPartDocumentObject),
                                                                            true);

            PartComponentDefinition compDef = partDoc.ComponentDefinition;
            PlanarSketch sketch = compDef.Sketches.Add(compDef.WorkPlanes[3]); // XY Plane

            // Draw rectangle on sketch
            TransientGeometry tg = _invApp.TransientGeometry;
            sketch.SketchLines.AddAsTwoPointRectangle(
                tg.CreatePoint2d(0, 0),
                tg.CreatePoint2d(width, length)
            );

            // Profile and extrude
            Profile profile = sketch.Profiles.AddForSolid();
            ExtrudeDefinition extDef = compDef.Features.ExtrudeFeatures.CreateExtrudeDefinition(
                profile, PartFeatureOperationEnum.kJoinOperation);
            extDef.SetDistanceExtent(height, PartFeatureExtentDirectionEnum.kPositiveExtentDirection);

            compDef.Features.ExtrudeFeatures.Add(extDef);
        }

        private void button1_Click(object sender, EventArgs e)
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
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void sphereToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}




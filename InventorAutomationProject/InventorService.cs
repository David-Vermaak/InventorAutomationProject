using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Inventor;

namespace InventorAutomationProject
{
    public class InventorService
    {
        public Inventor.Application InvApp { get; private set; }

        public InventorService()
        {
            try
            {
                InvApp = (Inventor.Application)Marshal.GetActiveObject("Inventor.Application");
            }
            catch
            {
                try
                {
                    Type invAppType = Type.GetTypeFromProgID("Inventor.Application");
                    InvApp = (Inventor.Application)Activator.CreateInstance(invAppType);
                    InvApp.Visible = true;
                }
                catch (Exception ex)
                {
                    throw new InvalidOperationException("Unable to get or start Inventor.", ex);
                }
            }
        }

        public static void SetHomeView(Inventor.Application InvApp)
        {
            try
            {
                // Get the active document
                var activeDocument = InvApp.ActiveDocument;
                // Check if the active document is a part or assembly
                if (activeDocument.DocumentType == Inventor.DocumentTypeEnum.kPartDocumentObject ||
                    activeDocument.DocumentType == Inventor.DocumentTypeEnum.kAssemblyDocumentObject)
                {
                    // Set the home view
                    Camera camera = InvApp.ActiveView.Camera;
                    camera.ViewOrientationType = ViewOrientationTypeEnum.kIsoTopRightViewOrientation;
                    camera.Perspective = false; // Use orthographic view
                    camera.Fit(); // Zoom to fit
                    camera.Apply();
                }
            }
            catch (Exception)
            {
                Console.Log("Error setting home view: ");
            }
        }
    }
}


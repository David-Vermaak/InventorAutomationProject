using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DarkModeForms;

namespace InventorAutomationProject.Controls
{
    public partial class OpenFile : UserControl
    {
        private readonly Inventor.Application _invApp;
        public OpenFile(InventorService inventorService)
        {
            InitializeComponent();
            _invApp = inventorService.InvApp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {

                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "part files (*.ipt)|*.ipt";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of the file
                    filePath = openFileDialog.FileName;

                    Console.Log("Selected file: " + filePath);
                    Console.Log("Opening file in Inventor...");
                    //open the file in Inventor
                    try
                    {
                        // Open the selected file in Inventor
                        _invApp.Documents.Open(filePath, true);
                        Console.Log("File opened successfully.");
                    }
                    catch (Exception ex)
                    {
                        Console.Log("Error opening file: " + ex.Message);
                    }

                }
                else
                {
                    Console.Log("No file selected");
                }

            }   
        }
    }
}

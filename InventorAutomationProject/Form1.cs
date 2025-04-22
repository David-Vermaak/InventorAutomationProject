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
using InventorAutomationProject;

namespace InventorAutomationProject
{
    public partial class Form1 : Form
    {

        private readonly DarkModeCS dm;

        private readonly InventorService _inventorService;
        private readonly MenuControl menuControl;
        private readonly HelpControl helpControl;
        private readonly CubePage cubePage;
        private readonly CycloidGearPage cycloidGearPage;


        public Form1()
        {
            InitializeComponent();
            dm = new DarkModeCS(this)
            {
                //[Optional] Choose your preferred color mode here:
                ColorMode = DarkModeCS.DisplayMode.SystemDefault
            };

            // Initialize the shared InventorService
            _inventorService = new InventorService();

            // Pass the service to controls
            menuControl = new MenuControl(_inventorService);
            helpControl = new HelpControl();
            cubePage = new CubePage(_inventorService);
            cycloidGearPage = new CycloidGearPage(_inventorService);
        }
        

        private void HomeButton_Click(object sender, EventArgs e)
        {
            LoadControlPage(menuControl);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadControlPage(menuControl);
            Console.LogAction = (msg) =>
            {
                if (txtConsole.InvokeRequired)
                {
                    txtConsole.Invoke(new Action(() => Console.LogAction(msg)));
                    return;
                }

                int closingBracket = msg.IndexOf(']');
                if (closingBracket >= 0)
                {
                    string timestamp = msg.Substring(0, closingBracket + 1);
                    string rest = msg.Substring(closingBracket + 1);

                    txtConsole.SelectionStart = txtConsole.TextLength;
                    txtConsole.SelectionColor = System.Drawing.Color.Green; // Color for timestamp
                    txtConsole.AppendText(timestamp);

                    txtConsole.SelectionColor = txtConsole.ForeColor; // Default color
                    txtConsole.AppendText(rest + System.Environment.NewLine);
                    // Scroll to the end of the text
                    txtConsole.SelectionStart = txtConsole.Text.Length;
                    txtConsole.ScrollToCaret();
                }
                else
                {
                    // Fallback in case formatting is off
                    txtConsole.AppendText(msg + System.Environment.NewLine);
                }
            };
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            LoadControlPage(helpControl);
        }

        public void LoadControlPage(Control controlPage)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(controlPage);
            controlPage.Dock = DockStyle.Fill;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            //prompt user to save changes

            if (DialogResult.Yes == Messenger.MessageBox("Are you sure you want to exit? All unsaved changes will be lost!",
				"Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
			{
				// Release the Inventor application object
				_inventorService?.InvApp.Quit();
                // Close the Form
				Form1.ActiveForm.Close();
			}
			else
			{
                
            }

        }

    }
}




using System;
using System.Linq;
using System.Windows.Forms;

namespace InventorAutomationProject
{
    public partial class MenuControl : UserControl
    {
        private readonly InventorService _inventorService;

        public MenuControl(InventorService inventorService)
        {
            InitializeComponent();
            _inventorService = inventorService;
        }

        private void CubeButton_Click(object sender, EventArgs e)
        {
            Form1 mainForm = Application.OpenForms.OfType<Form1>().FirstOrDefault();
            // Check if the main form is open
            mainForm?.LoadControlPage(new CubePage(_inventorService));

        }

        private void SphereButton_Click(object sender, EventArgs e)
        {
            Form1 mainForm = Application.OpenForms.OfType<Form1>().FirstOrDefault();
            // Check if the main form is open
            mainForm?.LoadControlPage(new SpherePage(_inventorService));
        }
    }
}

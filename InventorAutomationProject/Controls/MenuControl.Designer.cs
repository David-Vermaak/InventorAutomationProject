namespace InventorAutomationProject
{
    partial class MenuControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CubeButton = new System.Windows.Forms.Button();
            this.SphereButton = new System.Windows.Forms.Button();
            this.SpurGearButton = new System.Windows.Forms.Button();
            this.WormGearButton = new System.Windows.Forms.Button();
            this.HelicalGearButton = new System.Windows.Forms.Button();
            this.BevelGearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CubeButton
            // 
            this.CubeButton.Location = new System.Drawing.Point(55, 70);
            this.CubeButton.Name = "CubeButton";
            this.CubeButton.Size = new System.Drawing.Size(119, 56);
            this.CubeButton.TabIndex = 6;
            this.CubeButton.Text = "Cube";
            this.CubeButton.UseVisualStyleBackColor = true;
            this.CubeButton.Click += new System.EventHandler(this.CubeButton_Click);
            // 
            // SphereButton
            // 
            this.SphereButton.Location = new System.Drawing.Point(55, 144);
            this.SphereButton.Name = "SphereButton";
            this.SphereButton.Size = new System.Drawing.Size(119, 56);
            this.SphereButton.TabIndex = 7;
            this.SphereButton.Text = "Sphere";
            this.SphereButton.UseVisualStyleBackColor = true;
            this.SphereButton.Click += new System.EventHandler(this.SphereButton_Click);
            // 
            // SpurGearButton
            // 
            this.SpurGearButton.Location = new System.Drawing.Point(227, 70);
            this.SpurGearButton.Name = "SpurGearButton";
            this.SpurGearButton.Size = new System.Drawing.Size(119, 56);
            this.SpurGearButton.TabIndex = 8;
            this.SpurGearButton.Text = "Spur Gear";
            this.SpurGearButton.UseVisualStyleBackColor = true;
            // 
            // WormGearButton
            // 
            this.WormGearButton.Location = new System.Drawing.Point(227, 296);
            this.WormGearButton.Name = "WormGearButton";
            this.WormGearButton.Size = new System.Drawing.Size(119, 56);
            this.WormGearButton.TabIndex = 11;
            this.WormGearButton.Text = "Worm Gear";
            this.WormGearButton.UseVisualStyleBackColor = true;
            // 
            // HelicalGearButton
            // 
            this.HelicalGearButton.Location = new System.Drawing.Point(227, 144);
            this.HelicalGearButton.Name = "HelicalGearButton";
            this.HelicalGearButton.Size = new System.Drawing.Size(119, 56);
            this.HelicalGearButton.TabIndex = 9;
            this.HelicalGearButton.Text = "Helical Gear";
            this.HelicalGearButton.UseVisualStyleBackColor = true;
            // 
            // BevelGearButton
            // 
            this.BevelGearButton.Location = new System.Drawing.Point(227, 219);
            this.BevelGearButton.Name = "BevelGearButton";
            this.BevelGearButton.Size = new System.Drawing.Size(119, 56);
            this.BevelGearButton.TabIndex = 10;
            this.BevelGearButton.Text = "Bevel Gear";
            this.BevelGearButton.UseVisualStyleBackColor = true;
            // 
            // MenuControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.CubeButton);
            this.Controls.Add(this.SphereButton);
            this.Controls.Add(this.SpurGearButton);
            this.Controls.Add(this.WormGearButton);
            this.Controls.Add(this.HelicalGearButton);
            this.Controls.Add(this.BevelGearButton);
            this.Name = "MenuControl";
            this.Size = new System.Drawing.Size(619, 488);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CubeButton;
        private System.Windows.Forms.Button SphereButton;
        private System.Windows.Forms.Button SpurGearButton;
        private System.Windows.Forms.Button WormGearButton;
        private System.Windows.Forms.Button HelicalGearButton;
        private System.Windows.Forms.Button BevelGearButton;
    }
}

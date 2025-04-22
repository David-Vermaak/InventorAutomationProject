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
            this.CycloidGearButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CubeButton
            // 
            this.CubeButton.Location = new System.Drawing.Point(82, 108);
            this.CubeButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CubeButton.Name = "CubeButton";
            this.CubeButton.Size = new System.Drawing.Size(178, 86);
            this.CubeButton.TabIndex = 6;
            this.CubeButton.Text = "Cube";
            this.CubeButton.UseVisualStyleBackColor = true;
            this.CubeButton.Click += new System.EventHandler(this.CubeButton_Click);
            // 
            // SphereButton
            // 
            this.SphereButton.Location = new System.Drawing.Point(82, 222);
            this.SphereButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SphereButton.Name = "SphereButton";
            this.SphereButton.Size = new System.Drawing.Size(178, 86);
            this.SphereButton.TabIndex = 7;
            this.SphereButton.Text = "Sphere";
            this.SphereButton.UseVisualStyleBackColor = true;
            this.SphereButton.Click += new System.EventHandler(this.SphereButton_Click);
            // 
            // SpurGearButton
            // 
            this.SpurGearButton.Location = new System.Drawing.Point(340, 222);
            this.SpurGearButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SpurGearButton.Name = "SpurGearButton";
            this.SpurGearButton.Size = new System.Drawing.Size(178, 86);
            this.SpurGearButton.TabIndex = 8;
            this.SpurGearButton.Text = "Spur Gear";
            this.SpurGearButton.UseVisualStyleBackColor = true;
            // 
            // WormGearButton
            // 
            this.WormGearButton.Location = new System.Drawing.Point(561, 108);
            this.WormGearButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.WormGearButton.Name = "WormGearButton";
            this.WormGearButton.Size = new System.Drawing.Size(178, 86);
            this.WormGearButton.TabIndex = 11;
            this.WormGearButton.Text = "Worm Gear";
            this.WormGearButton.UseVisualStyleBackColor = true;
            // 
            // HelicalGearButton
            // 
            this.HelicalGearButton.Location = new System.Drawing.Point(340, 340);
            this.HelicalGearButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HelicalGearButton.Name = "HelicalGearButton";
            this.HelicalGearButton.Size = new System.Drawing.Size(178, 86);
            this.HelicalGearButton.TabIndex = 9;
            this.HelicalGearButton.Text = "Helical Gear";
            this.HelicalGearButton.UseVisualStyleBackColor = true;
            // 
            // BevelGearButton
            // 
            this.BevelGearButton.Location = new System.Drawing.Point(561, 222);
            this.BevelGearButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BevelGearButton.Name = "BevelGearButton";
            this.BevelGearButton.Size = new System.Drawing.Size(178, 86);
            this.BevelGearButton.TabIndex = 10;
            this.BevelGearButton.Text = "Bevel Gear";
            this.BevelGearButton.UseVisualStyleBackColor = true;
            // 
            // CycloidGearButton
            // 
            this.CycloidGearButton.AutoEllipsis = true;
            this.CycloidGearButton.Location = new System.Drawing.Point(340, 108);
            this.CycloidGearButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CycloidGearButton.Name = "CycloidGearButton";
            this.CycloidGearButton.Size = new System.Drawing.Size(178, 86);
            this.CycloidGearButton.TabIndex = 12;
            this.CycloidGearButton.Text = "Cycloid Gear";
            this.CycloidGearButton.UseVisualStyleBackColor = true;
            this.CycloidGearButton.Click += new System.EventHandler(this.CycloidGearButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(138, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Menu";
            // 
            // MenuControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CycloidGearButton);
            this.Controls.Add(this.CubeButton);
            this.Controls.Add(this.SphereButton);
            this.Controls.Add(this.SpurGearButton);
            this.Controls.Add(this.WormGearButton);
            this.Controls.Add(this.HelicalGearButton);
            this.Controls.Add(this.BevelGearButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MenuControl";
            this.Size = new System.Drawing.Size(1043, 562);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CubeButton;
        private System.Windows.Forms.Button SphereButton;
        private System.Windows.Forms.Button SpurGearButton;
        private System.Windows.Forms.Button WormGearButton;
        private System.Windows.Forms.Button HelicalGearButton;
        private System.Windows.Forms.Button BevelGearButton;
        private System.Windows.Forms.Button CycloidGearButton;
        private System.Windows.Forms.Label label1;
    }
}

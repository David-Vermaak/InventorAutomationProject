namespace InventorAutomationProject
{
    partial class SpherePage
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
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRadius = new System.Windows.Forms.TextBox();
            this._CreateSphereButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 37);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Create a Sphere!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 117);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Radius";
            // 
            // txtRadius
            // 
            this.txtRadius.CausesValidation = false;
            this.txtRadius.Location = new System.Drawing.Point(173, 111);
            this.txtRadius.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(260, 22);
            this.txtRadius.TabIndex = 15;
            // 
            // _CreateSphereButton
            // 
            this._CreateSphereButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this._CreateSphereButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this._CreateSphereButton.Location = new System.Drawing.Point(94, 213);
            this._CreateSphereButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this._CreateSphereButton.Name = "_CreateSphereButton";
            this._CreateSphereButton.Size = new System.Drawing.Size(352, 76);
            this._CreateSphereButton.TabIndex = 18;
            this._CreateSphereButton.Text = "Create";
            this._CreateSphereButton.UseVisualStyleBackColor = false;
            this._CreateSphereButton.Click += new System.EventHandler(this._CreateSphereButton_Click_1);
            // 
            // SpherePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._CreateSphereButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRadius);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SpherePage";
            this.Size = new System.Drawing.Size(550, 390);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRadius;
        private System.Windows.Forms.Button _CreateSphereButton;
    }
}

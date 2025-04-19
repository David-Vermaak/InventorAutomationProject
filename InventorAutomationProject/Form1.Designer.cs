namespace InventorAutomationProject
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.HomeButton = new System.Windows.Forms.Button();
            this.HelpButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.txtConsole = new System.Windows.Forms.RichTextBox();
            this.ConsoleBox = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // HomeButton
            // 
            this.HomeButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.HomeButton.Location = new System.Drawing.Point(12, 56);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(136, 74);
            this.HomeButton.TabIndex = 0;
            this.HomeButton.Text = "Home";
            this.HomeButton.UseVisualStyleBackColor = true;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // HelpButton
            // 
            this.HelpButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.HelpButton.Location = new System.Drawing.Point(12, 151);
            this.HelpButton.Name = "HelpButton";
            this.HelpButton.Size = new System.Drawing.Size(136, 74);
            this.HelpButton.TabIndex = 1;
            this.HelpButton.Text = "Help";
            this.HelpButton.UseVisualStyleBackColor = true;
            this.HelpButton.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ExitButton.Location = new System.Drawing.Point(12, 249);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(136, 74);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Location = new System.Drawing.Point(183, 17);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(619, 488);
            this.MainPanel.TabIndex = 3;
            // 
            // txtConsole
            // 
            this.txtConsole.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtConsole.Location = new System.Drawing.Point(12, 536);
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.ReadOnly = true;
            this.txtConsole.Size = new System.Drawing.Size(790, 340);
            this.txtConsole.TabIndex = 4;
            this.txtConsole.Text = "";
            this.txtConsole.WordWrap = false;
            // 
            // ConsoleBox
            // 
            this.ConsoleBox.Location = new System.Drawing.Point(-3, 511);
            this.ConsoleBox.Name = "ConsoleBox";
            this.ConsoleBox.Size = new System.Drawing.Size(828, 389);
            this.ConsoleBox.TabIndex = 5;
            this.ConsoleBox.TabStop = false;
            this.ConsoleBox.Text = "Console";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(821, 899);
            this.Controls.Add(this.txtConsole);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.HelpButton);
            this.Controls.Add(this.HomeButton);
            this.Controls.Add(this.ConsoleBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Inventor Automation";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Button HelpButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.RichTextBox txtConsole;
        private System.Windows.Forms.GroupBox ConsoleBox;
    }
}


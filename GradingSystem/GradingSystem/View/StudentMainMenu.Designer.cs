namespace GradingSystem
{
    partial class StudentMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentMainMenu));
            this.studentMenuLabel = new System.Windows.Forms.Label();
            this.signOutButton = new System.Windows.Forms.Button();
            this.gotoclassButton = new System.Windows.Forms.Button();
            this.comboBoxClasses = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // studentMenuLabel
            // 
            resources.ApplyResources(this.studentMenuLabel, "studentMenuLabel");
            this.studentMenuLabel.Name = "studentMenuLabel";
            // 
            // signOutButton
            // 
            this.signOutButton.BackColor = System.Drawing.Color.IndianRed;
            resources.ApplyResources(this.signOutButton, "signOutButton");
            this.signOutButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.signOutButton.Name = "signOutButton";
            this.signOutButton.UseVisualStyleBackColor = false;
            this.signOutButton.Click += new System.EventHandler(this.signOutButton_Click);
            // 
            // gotoclassButton
            // 
            this.gotoclassButton.BackColor = System.Drawing.Color.LimeGreen;
            resources.ApplyResources(this.gotoclassButton, "gotoclassButton");
            this.gotoclassButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gotoclassButton.Name = "gotoclassButton";
            this.gotoclassButton.UseVisualStyleBackColor = false;
            this.gotoclassButton.Click += new System.EventHandler(this.gotoclassButton_Click);
            // 
            // comboBoxClasses
            // 
            resources.ApplyResources(this.comboBoxClasses, "comboBoxClasses");
            this.comboBoxClasses.FormattingEnabled = true;
            this.comboBoxClasses.Name = "comboBoxClasses";
            // 
            // StudentMainMenu
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.studentMenuLabel);
            this.Controls.Add(this.comboBoxClasses);
            this.Controls.Add(this.gotoclassButton);
            this.Controls.Add(this.signOutButton);
            this.Name = "StudentMainMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label studentMenuLabel;
        private System.Windows.Forms.Button signOutButton;
        private System.Windows.Forms.Button gotoclassButton;
        private System.Windows.Forms.ComboBox comboBoxClasses;
    }
}
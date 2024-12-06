namespace GradingSystem
{
    partial class teacherMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(teacherMainMenu));
            this.teacherMenuLabel = new System.Windows.Forms.Label();
            this.comboBoxClasses = new System.Windows.Forms.ComboBox();
            this.selectLabel = new System.Windows.Forms.Label();
            this.gotoclassButton = new System.Windows.Forms.Button();
            this.signOutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // teacherMenuLabel
            // 
            resources.ApplyResources(this.teacherMenuLabel, "teacherMenuLabel");
            this.teacherMenuLabel.Name = "teacherMenuLabel";
            // 
            // comboBoxClasses
            // 
            resources.ApplyResources(this.comboBoxClasses, "comboBoxClasses");
            this.comboBoxClasses.FormattingEnabled = true;
            this.comboBoxClasses.Name = "comboBoxClasses";
            // 
            // selectLabel
            // 
            resources.ApplyResources(this.selectLabel, "selectLabel");
            this.selectLabel.Name = "selectLabel";
            // 
            // gotoclassButton
            // 
            resources.ApplyResources(this.gotoclassButton, "gotoclassButton");
            this.gotoclassButton.BackColor = System.Drawing.Color.LimeGreen;
            this.gotoclassButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gotoclassButton.Name = "gotoclassButton";
            this.gotoclassButton.UseVisualStyleBackColor = false;
            this.gotoclassButton.Click += new System.EventHandler(this.gotoclassButton_Click);
            // 
            // signOutButton
            // 
            resources.ApplyResources(this.signOutButton, "signOutButton");
            this.signOutButton.BackColor = System.Drawing.Color.IndianRed;
            this.signOutButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.signOutButton.Name = "signOutButton";
            this.signOutButton.UseVisualStyleBackColor = false;
            this.signOutButton.Click += new System.EventHandler(this.signOutButton_Click);
            // 
            // teacherMainMenu
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.signOutButton);
            this.Controls.Add(this.gotoclassButton);
            this.Controls.Add(this.selectLabel);
            this.Controls.Add(this.comboBoxClasses);
            this.Controls.Add(this.teacherMenuLabel);
            this.Name = "teacherMainMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label teacherMenuLabel;
        private System.Windows.Forms.ComboBox comboBoxClasses;
        private System.Windows.Forms.Label selectLabel;
        private System.Windows.Forms.Button gotoclassButton;
        private System.Windows.Forms.Button signOutButton;
    }
}
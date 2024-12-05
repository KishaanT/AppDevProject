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
            this.teacherMenuLabel = new System.Windows.Forms.Label();
            this.comboBoxClasses = new System.Windows.Forms.ComboBox();
            this.selectLabel = new System.Windows.Forms.Label();
            this.gotoclassButton = new System.Windows.Forms.Button();
            this.signOutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // teacherMenuLabel
            // 
            this.teacherMenuLabel.AutoSize = true;
            this.teacherMenuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherMenuLabel.Location = new System.Drawing.Point(110, 9);
            this.teacherMenuLabel.Name = "teacherMenuLabel";
            this.teacherMenuLabel.Size = new System.Drawing.Size(260, 42);
            this.teacherMenuLabel.TabIndex = 0;
            this.teacherMenuLabel.Text = "Teacher Menu";
            // 
            // comboBoxClasses
            // 
            this.comboBoxClasses.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxClasses.FormattingEnabled = true;
            this.comboBoxClasses.Location = new System.Drawing.Point(12, 123);
            this.comboBoxClasses.Name = "comboBoxClasses";
            this.comboBoxClasses.Size = new System.Drawing.Size(285, 32);
            this.comboBoxClasses.TabIndex = 1;
            // 
            // selectLabel
            // 
            this.selectLabel.AutoSize = true;
            this.selectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectLabel.Location = new System.Drawing.Point(12, 85);
            this.selectLabel.Name = "selectLabel";
            this.selectLabel.Size = new System.Drawing.Size(288, 25);
            this.selectLabel.TabIndex = 2;
            this.selectLabel.Text = "Select a class that you teach";
            // 
            // gotoclassButton
            // 
            this.gotoclassButton.BackColor = System.Drawing.Color.LimeGreen;
            this.gotoclassButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gotoclassButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gotoclassButton.Location = new System.Drawing.Point(324, 114);
            this.gotoclassButton.Name = "gotoclassButton";
            this.gotoclassButton.Size = new System.Drawing.Size(145, 50);
            this.gotoclassButton.TabIndex = 3;
            this.gotoclassButton.Text = "Go to class";
            this.gotoclassButton.UseVisualStyleBackColor = false;
            this.gotoclassButton.Click += new System.EventHandler(this.gotoclassButton_Click);
            // 
            // signOutButton
            // 
            this.signOutButton.BackColor = System.Drawing.Color.IndianRed;
            this.signOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signOutButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.signOutButton.Location = new System.Drawing.Point(376, 9);
            this.signOutButton.Name = "signOutButton";
            this.signOutButton.Size = new System.Drawing.Size(93, 39);
            this.signOutButton.TabIndex = 4;
            this.signOutButton.Text = "Sign Out";
            this.signOutButton.UseVisualStyleBackColor = false;
            this.signOutButton.Click += new System.EventHandler(this.signOutButton_Click);
            // 
            // teacherMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 179);
            this.Controls.Add(this.signOutButton);
            this.Controls.Add(this.gotoclassButton);
            this.Controls.Add(this.selectLabel);
            this.Controls.Add(this.comboBoxClasses);
            this.Controls.Add(this.teacherMenuLabel);
            this.Name = "teacherMainMenu";
            this.Text = "TKB Grading System - Teacher Main Menu";
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
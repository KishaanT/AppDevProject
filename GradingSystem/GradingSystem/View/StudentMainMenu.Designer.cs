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
            this.studentMenuLabel = new System.Windows.Forms.Label();
            this.signOutButton = new System.Windows.Forms.Button();
            this.gotoclassButton = new System.Windows.Forms.Button();
            this.comboBoxClasses = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // studentMenuLabel
            // 
            this.studentMenuLabel.AutoSize = true;
            this.studentMenuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentMenuLabel.Location = new System.Drawing.Point(89, 9);
            this.studentMenuLabel.Name = "studentMenuLabel";
            this.studentMenuLabel.Size = new System.Drawing.Size(251, 42);
            this.studentMenuLabel.TabIndex = 1;
            this.studentMenuLabel.Text = "Student Menu";
            // 
            // signOutButton
            // 
            this.signOutButton.BackColor = System.Drawing.Color.IndianRed;
            this.signOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signOutButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.signOutButton.Location = new System.Drawing.Point(367, 5);
            this.signOutButton.Name = "signOutButton";
            this.signOutButton.Size = new System.Drawing.Size(93, 39);
            this.signOutButton.TabIndex = 5;
            this.signOutButton.Text = "Sign Out";
            this.signOutButton.UseVisualStyleBackColor = false;
            this.signOutButton.Click += new System.EventHandler(this.signOutButton_Click);
            // 
            // gotoclassButton
            // 
            this.gotoclassButton.BackColor = System.Drawing.Color.LimeGreen;
            this.gotoclassButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gotoclassButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gotoclassButton.Location = new System.Drawing.Point(315, 76);
            this.gotoclassButton.Name = "gotoclassButton";
            this.gotoclassButton.Size = new System.Drawing.Size(145, 50);
            this.gotoclassButton.TabIndex = 6;
            this.gotoclassButton.Text = "Go to class";
            this.gotoclassButton.UseVisualStyleBackColor = false;
            this.gotoclassButton.Click += new System.EventHandler(this.gotoclassButton_Click);
            // 
            // comboBoxClasses
            // 
            this.comboBoxClasses.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxClasses.FormattingEnabled = true;
            this.comboBoxClasses.Location = new System.Drawing.Point(12, 85);
            this.comboBoxClasses.Name = "comboBoxClasses";
            this.comboBoxClasses.Size = new System.Drawing.Size(285, 32);
            this.comboBoxClasses.TabIndex = 7;
            // 
            // StudentMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 151);
            this.Controls.Add(this.studentMenuLabel);
            this.Controls.Add(this.comboBoxClasses);
            this.Controls.Add(this.gotoclassButton);
            this.Controls.Add(this.signOutButton);
            this.Name = "StudentMainMenu";
            this.Text = "TKB Grading System - Student Main Menu";
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
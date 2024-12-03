<<<<<<< HEAD:GradingSystem/GradingSystem/IdentifyForm.Designer.cs
﻿namespace GradingSystem
{
    partial class IdentifyForm
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
            this.signInLabel = new System.Windows.Forms.Label();
            this.promptLabel = new System.Windows.Forms.Label();
            this.studentButton = new System.Windows.Forms.Button();
            this.teacherButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // signInLabel
            // 
            this.signInLabel.AutoSize = true;
            this.signInLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signInLabel.Location = new System.Drawing.Point(137, 18);
            this.signInLabel.Name = "signInLabel";
            this.signInLabel.Size = new System.Drawing.Size(116, 37);
            this.signInLabel.TabIndex = 0;
            this.signInLabel.Text = "Sign In";
            // 
            // promptLabel
            // 
            this.promptLabel.AutoSize = true;
            this.promptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.promptLabel.Location = new System.Drawing.Point(48, 76);
            this.promptLabel.Name = "promptLabel";
            this.promptLabel.Size = new System.Drawing.Size(283, 24);
            this.promptLabel.TabIndex = 1;
            this.promptLabel.Text = "Are you a Teacher or a Student?";
            // 
            // studentButton
            // 
            this.studentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentButton.Location = new System.Drawing.Point(82, 136);
            this.studentButton.Name = "studentButton";
            this.studentButton.Size = new System.Drawing.Size(224, 101);
            this.studentButton.TabIndex = 2;
            this.studentButton.Text = "Student";
            this.studentButton.UseVisualStyleBackColor = true;
            this.studentButton.Click += new System.EventHandler(this.studentButton_Click);
            // 
            // teacherButton
            // 
            this.teacherButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherButton.Location = new System.Drawing.Point(82, 292);
            this.teacherButton.Name = "teacherButton";
            this.teacherButton.Size = new System.Drawing.Size(224, 101);
            this.teacherButton.TabIndex = 3;
            this.teacherButton.Text = "Teacher";
            this.teacherButton.UseVisualStyleBackColor = true;
            this.teacherButton.Click += new System.EventHandler(this.teacherButton_Click);
            // 
            // Identify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(381, 450);
            this.Controls.Add(this.teacherButton);
            this.Controls.Add(this.studentButton);
            this.Controls.Add(this.promptLabel);
            this.Controls.Add(this.signInLabel);
            this.Name = "Identify";
            this.Text = "TKB School Grading System - Identification";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label signInLabel;
        private System.Windows.Forms.Label promptLabel;
        private System.Windows.Forms.Button studentButton;
        private System.Windows.Forms.Button teacherButton;
    }
}

=======
﻿namespace GradingSystem
{
    partial class IdentifyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IdentifyForm));
            this.signInLabel = new System.Windows.Forms.Label();
            this.promptLabel = new System.Windows.Forms.Label();
            this.studentButton = new System.Windows.Forms.Button();
            this.teacherButton = new System.Windows.Forms.Button();
            this.languageLabel = new System.Windows.Forms.Label();
            this.languageComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // signInLabel
            // 
            resources.ApplyResources(this.signInLabel, "signInLabel");
            this.signInLabel.Name = "signInLabel";
            // 
            // promptLabel
            // 
            resources.ApplyResources(this.promptLabel, "promptLabel");
            this.promptLabel.Name = "promptLabel";
            // 
            // studentButton
            // 
            resources.ApplyResources(this.studentButton, "studentButton");
            this.studentButton.Name = "studentButton";
            this.studentButton.UseVisualStyleBackColor = true;
            this.studentButton.Click += new System.EventHandler(this.studentButton_Click);
            // 
            // teacherButton
            // 
            resources.ApplyResources(this.teacherButton, "teacherButton");
            this.teacherButton.Name = "teacherButton";
            this.teacherButton.UseVisualStyleBackColor = true;
            this.teacherButton.Click += new System.EventHandler(this.teacherButton_Click);
            // 
            // languageLabel
            // 
            resources.ApplyResources(this.languageLabel, "languageLabel");
            this.languageLabel.Name = "languageLabel";
            // 
            // languageComboBox
            // 
            this.languageComboBox.FormattingEnabled = true;
            this.languageComboBox.Items.AddRange(new object[] {
            resources.GetString("languageComboBox.Items"),
            resources.GetString("languageComboBox.Items1"),
            resources.GetString("languageComboBox.Items2")});
            resources.ApplyResources(this.languageComboBox, "languageComboBox");
            this.languageComboBox.Name = "languageComboBox";
            this.languageComboBox.SelectedIndexChanged += new System.EventHandler(this.languageComboBox_SelectedIndexChanged);
            // 
            // IdentifyForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.languageComboBox);
            this.Controls.Add(this.languageLabel);
            this.Controls.Add(this.teacherButton);
            this.Controls.Add(this.studentButton);
            this.Controls.Add(this.promptLabel);
            this.Controls.Add(this.signInLabel);
            this.Name = "IdentifyForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label signInLabel;
        private System.Windows.Forms.Label promptLabel;
        private System.Windows.Forms.Button studentButton;
        private System.Windows.Forms.Button teacherButton;
        private System.Windows.Forms.Label languageLabel;
        private System.Windows.Forms.ComboBox languageComboBox;
    }
}

>>>>>>> parent of c80975f (Changed whole Shebang):AppDevProject-main/AppDevProject-main/GradingSystem/GradingSystem/IdentifyForm.Designer.cs

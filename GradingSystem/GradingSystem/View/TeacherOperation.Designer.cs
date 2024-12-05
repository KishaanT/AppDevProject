namespace GradingSystem
{
    partial class TeacherOperation
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
            this.label1 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.gradesButton = new System.Windows.Forms.Button();
            this.assignmentsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(504, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose an operation to perform";
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.IndianRed;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.backButton.Location = new System.Drawing.Point(239, 127);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(122, 41);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // gradesButton
            // 
            this.gradesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gradesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradesButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gradesButton.Location = new System.Drawing.Point(53, 75);
            this.gradesButton.Name = "gradesButton";
            this.gradesButton.Size = new System.Drawing.Size(194, 41);
            this.gradesButton.TabIndex = 2;
            this.gradesButton.Text = "Grades";
            this.gradesButton.UseVisualStyleBackColor = false;
            this.gradesButton.Click += new System.EventHandler(this.gradesButton_Click);
            // 
            // assignmentsButton
            // 
            this.assignmentsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.assignmentsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assignmentsButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.assignmentsButton.Location = new System.Drawing.Point(346, 75);
            this.assignmentsButton.Name = "assignmentsButton";
            this.assignmentsButton.Size = new System.Drawing.Size(204, 41);
            this.assignmentsButton.TabIndex = 3;
            this.assignmentsButton.Text = "Assignments";
            this.assignmentsButton.UseVisualStyleBackColor = false;
            this.assignmentsButton.Click += new System.EventHandler(this.assignmentsButton_Click);
            // 
            // TeacherOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 180);
            this.Controls.Add(this.assignmentsButton);
            this.Controls.Add(this.gradesButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.label1);
            this.Name = "TeacherOperation";
            this.Text = "TKB Grading System - Choose Teacher Operation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button gradesButton;
        private System.Windows.Forms.Button assignmentsButton;
    }
}
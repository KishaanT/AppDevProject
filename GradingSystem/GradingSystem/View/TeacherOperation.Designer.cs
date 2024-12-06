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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherOperation));
            this.label1 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.gradesButton = new System.Windows.Forms.Button();
            this.assignmentsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // backButton
            // 
            resources.ApplyResources(this.backButton, "backButton");
            this.backButton.BackColor = System.Drawing.Color.IndianRed;
            this.backButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.backButton.Name = "backButton";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // gradesButton
            // 
            resources.ApplyResources(this.gradesButton, "gradesButton");
            this.gradesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gradesButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gradesButton.Name = "gradesButton";
            this.gradesButton.UseVisualStyleBackColor = false;
            this.gradesButton.Click += new System.EventHandler(this.gradesButton_Click);
            // 
            // assignmentsButton
            // 
            resources.ApplyResources(this.assignmentsButton, "assignmentsButton");
            this.assignmentsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.assignmentsButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.assignmentsButton.Name = "assignmentsButton";
            this.assignmentsButton.UseVisualStyleBackColor = false;
            this.assignmentsButton.Click += new System.EventHandler(this.assignmentsButton_Click);
            // 
            // TeacherOperation
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.assignmentsButton);
            this.Controls.Add(this.gradesButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.label1);
            this.Name = "TeacherOperation";
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
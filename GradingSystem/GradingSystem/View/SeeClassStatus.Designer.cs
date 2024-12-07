namespace GradingSystem
{
    partial class SeeClassStatus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeeClassStatus));
            this.titleLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.gradeLabel = new System.Windows.Forms.Label();
            this.passingLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.averageLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            resources.ApplyResources(this.titleLabel, "titleLabel");
            this.titleLabel.Name = "titleLabel";
            // 
            // closeButton
            // 
            resources.ApplyResources(this.closeButton, "closeButton");
            this.closeButton.BackColor = System.Drawing.Color.IndianRed;
            this.closeButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.closeButton.Name = "closeButton";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // gradeLabel
            // 
            resources.ApplyResources(this.gradeLabel, "gradeLabel");
            this.gradeLabel.Name = "gradeLabel";
            // 
            // passingLabel
            // 
            resources.ApplyResources(this.passingLabel, "passingLabel");
            this.passingLabel.ForeColor = System.Drawing.Color.SpringGreen;
            this.passingLabel.Name = "passingLabel";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // averageLabel
            // 
            resources.ApplyResources(this.averageLabel, "averageLabel");
            this.averageLabel.Name = "averageLabel";
            // 
            // statusLabel
            // 
            resources.ApplyResources(this.statusLabel, "statusLabel");
            this.statusLabel.Name = "statusLabel";
            // 
            // SeeClassStatus
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.gradeLabel);
            this.Controls.Add(this.passingLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.averageLabel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "SeeClassStatus";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label gradeLabel;
        private System.Windows.Forms.Label passingLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label averageLabel;
        private System.Windows.Forms.Label statusLabel;
    }
}
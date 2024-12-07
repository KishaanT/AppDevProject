namespace GradingSystem
{
    partial class AddModifyGrades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddModifyGrades));
            this.titleLabel = new System.Windows.Forms.Label();
            this.assignmentListView = new System.Windows.Forms.ListView();
            this.nameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.weightColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gradeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.closeButton = new System.Windows.Forms.Button();
            this.gradeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.promptLabel = new System.Windows.Forms.Label();
            this.insertButton = new System.Windows.Forms.Button();
            this.studentLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gradeNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            resources.ApplyResources(this.titleLabel, "titleLabel");
            this.titleLabel.Name = "titleLabel";
            // 
            // assignmentListView
            // 
            this.assignmentListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameColumn,
            this.weightColumn,
            this.gradeColumn});
            this.assignmentListView.FullRowSelect = true;
            this.assignmentListView.HideSelection = false;
            resources.ApplyResources(this.assignmentListView, "assignmentListView");
            this.assignmentListView.MultiSelect = false;
            this.assignmentListView.Name = "assignmentListView";
            this.assignmentListView.UseCompatibleStateImageBehavior = false;
            this.assignmentListView.View = System.Windows.Forms.View.Details;
            // 
            // nameColumn
            // 
            resources.ApplyResources(this.nameColumn, "nameColumn");
            // 
            // weightColumn
            // 
            resources.ApplyResources(this.weightColumn, "weightColumn");
            // 
            // gradeColumn
            // 
            resources.ApplyResources(this.gradeColumn, "gradeColumn");
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.IndianRed;
            resources.ApplyResources(this.closeButton, "closeButton");
            this.closeButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.closeButton.Name = "closeButton";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // gradeNumericUpDown
            // 
            resources.ApplyResources(this.gradeNumericUpDown, "gradeNumericUpDown");
            this.gradeNumericUpDown.Name = "gradeNumericUpDown";
            // 
            // promptLabel
            // 
            resources.ApplyResources(this.promptLabel, "promptLabel");
            this.promptLabel.Name = "promptLabel";
            // 
            // insertButton
            // 
            resources.ApplyResources(this.insertButton, "insertButton");
            this.insertButton.Name = "insertButton";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // studentLabel
            // 
            resources.ApplyResources(this.studentLabel, "studentLabel");
            this.studentLabel.Name = "studentLabel";
            // 
            // AddModifyGrades
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.studentLabel);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.promptLabel);
            this.Controls.Add(this.gradeNumericUpDown);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.assignmentListView);
            this.Controls.Add(this.titleLabel);
            this.Name = "AddModifyGrades";
            ((System.ComponentModel.ISupportInitialize)(this.gradeNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.ListView assignmentListView;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.NumericUpDown gradeNumericUpDown;
        private System.Windows.Forms.Label promptLabel;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.ColumnHeader nameColumn;
        private System.Windows.Forms.ColumnHeader weightColumn;
        private System.Windows.Forms.ColumnHeader gradeColumn;
        private System.Windows.Forms.Label studentLabel;
    }
}
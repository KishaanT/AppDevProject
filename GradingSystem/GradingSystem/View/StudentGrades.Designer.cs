namespace GradingSystem
{
    partial class StudentGrades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentGrades));
            this.assignmentListView = new System.Windows.Forms.ListView();
            this.nameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.weightColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gradeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gradingSystemLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.seeAverageButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.dropOutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // assignmentListView
            // 
            this.assignmentListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameColumn,
            this.weightColumn,
            this.gradeColumn,
            this.statusColumn});
            resources.ApplyResources(this.assignmentListView, "assignmentListView");
            this.assignmentListView.FullRowSelect = true;
            this.assignmentListView.HideSelection = false;
            this.assignmentListView.MultiSelect = false;
            this.assignmentListView.Name = "assignmentListView";
            this.assignmentListView.UseCompatibleStateImageBehavior = false;
            this.assignmentListView.View = System.Windows.Forms.View.Details;
            this.assignmentListView.SelectedIndexChanged += new System.EventHandler(this.assignmentListView_SelectedIndexChanged);
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
            // statusColumn
            // 
            resources.ApplyResources(this.statusColumn, "statusColumn");
            // 
            // gradingSystemLabel
            // 
            resources.ApplyResources(this.gradingSystemLabel, "gradingSystemLabel");
            this.gradingSystemLabel.Name = "gradingSystemLabel";
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.IndianRed;
            resources.ApplyResources(this.backButton, "backButton");
            this.backButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.backButton.Name = "backButton";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // seeAverageButton
            // 
            this.seeAverageButton.BackColor = System.Drawing.Color.SteelBlue;
            resources.ApplyResources(this.seeAverageButton, "seeAverageButton");
            this.seeAverageButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.seeAverageButton.Name = "seeAverageButton";
            this.seeAverageButton.UseVisualStyleBackColor = false;
            this.seeAverageButton.Click += new System.EventHandler(this.seeAverageButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.CadetBlue;
            resources.ApplyResources(this.clearButton, "clearButton");
            this.clearButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.clearButton.Name = "clearButton";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.CadetBlue;
            resources.ApplyResources(this.searchButton, "searchButton");
            this.searchButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.searchButton.Name = "searchButton";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchBox
            // 
            this.searchBox.BackColor = System.Drawing.Color.SkyBlue;
            resources.ApplyResources(this.searchBox, "searchBox");
            this.searchBox.Name = "searchBox";
            // 
            // searchLabel
            // 
            resources.ApplyResources(this.searchLabel, "searchLabel");
            this.searchLabel.Name = "searchLabel";
            // 
            // dropOutButton
            // 
            this.dropOutButton.BackColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.dropOutButton, "dropOutButton");
            this.dropOutButton.ForeColor = System.Drawing.Color.Yellow;
            this.dropOutButton.Name = "dropOutButton";
            this.dropOutButton.UseVisualStyleBackColor = false;
            this.dropOutButton.Click += new System.EventHandler(this.dropOutButton_Click);
            // 
            // StudentGrades
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dropOutButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.seeAverageButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.gradingSystemLabel);
            this.Controls.Add(this.assignmentListView);
            this.Name = "StudentGrades";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView assignmentListView;
        private System.Windows.Forms.ColumnHeader nameColumn;
        private System.Windows.Forms.ColumnHeader weightColumn;
        private System.Windows.Forms.Label gradingSystemLabel;
        private System.Windows.Forms.ColumnHeader gradeColumn;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.ColumnHeader statusColumn;
        private System.Windows.Forms.Button seeAverageButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Button dropOutButton;
    }
}
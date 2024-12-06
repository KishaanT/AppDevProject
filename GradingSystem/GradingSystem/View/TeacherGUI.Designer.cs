namespace GradingSystem
{
    partial class TeacherGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherGUI));
            this.gradingSystemLabel = new System.Windows.Forms.Label();
            this.studentListView = new System.Windows.Forms.ListView();
            this.studentColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.studentIDcolumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.backButton = new System.Windows.Forms.Button();
            this.seeStatusButton = new System.Windows.Forms.Button();
            this.addModifyGradeButton = new System.Windows.Forms.Button();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gradingSystemLabel
            // 
            resources.ApplyResources(this.gradingSystemLabel, "gradingSystemLabel");
            this.gradingSystemLabel.Name = "gradingSystemLabel";
            // 
            // studentListView
            // 
            this.studentListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.studentColumn,
            this.studentIDcolumn});
            resources.ApplyResources(this.studentListView, "studentListView");
            this.studentListView.FullRowSelect = true;
            this.studentListView.HideSelection = false;
            this.studentListView.MultiSelect = false;
            this.studentListView.Name = "studentListView";
            this.studentListView.UseCompatibleStateImageBehavior = false;
            this.studentListView.View = System.Windows.Forms.View.Details;
            // 
            // studentColumn
            // 
            resources.ApplyResources(this.studentColumn, "studentColumn");
            // 
            // studentIDcolumn
            // 
            resources.ApplyResources(this.studentIDcolumn, "studentIDcolumn");
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
            // seeStatusButton
            // 
            this.seeStatusButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            resources.ApplyResources(this.seeStatusButton, "seeStatusButton");
            this.seeStatusButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.seeStatusButton.Name = "seeStatusButton";
            this.seeStatusButton.UseVisualStyleBackColor = false;
            this.seeStatusButton.Click += new System.EventHandler(this.seeStatusButton_Click);
            // 
            // addModifyGradeButton
            // 
            this.addModifyGradeButton.BackColor = System.Drawing.Color.SteelBlue;
            resources.ApplyResources(this.addModifyGradeButton, "addModifyGradeButton");
            this.addModifyGradeButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addModifyGradeButton.Name = "addModifyGradeButton";
            this.addModifyGradeButton.UseVisualStyleBackColor = false;
            this.addModifyGradeButton.Click += new System.EventHandler(this.addModifyGradeButton_Click);
            // 
            // searchLabel
            // 
            resources.ApplyResources(this.searchLabel, "searchLabel");
            this.searchLabel.Name = "searchLabel";
            // 
            // searchBox
            // 
            this.searchBox.BackColor = System.Drawing.Color.SkyBlue;
            resources.ApplyResources(this.searchBox, "searchBox");
            this.searchBox.Name = "searchBox";
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
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.CadetBlue;
            resources.ApplyResources(this.clearButton, "clearButton");
            this.clearButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.clearButton.Name = "clearButton";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // TeacherGUI
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.addModifyGradeButton);
            this.Controls.Add(this.seeStatusButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.studentListView);
            this.Controls.Add(this.gradingSystemLabel);
            this.Name = "TeacherGUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gradingSystemLabel;
        private System.Windows.Forms.ListView studentListView;
        private System.Windows.Forms.ColumnHeader studentColumn;
        private System.Windows.Forms.ColumnHeader studentIDcolumn;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button seeStatusButton;
        private System.Windows.Forms.Button addModifyGradeButton;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button clearButton;
    }
}
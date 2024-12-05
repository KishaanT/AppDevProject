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
            this.assignmentListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assignmentListView.FullRowSelect = true;
            this.assignmentListView.HideSelection = false;
            this.assignmentListView.Location = new System.Drawing.Point(185, 75);
            this.assignmentListView.MultiSelect = false;
            this.assignmentListView.Name = "assignmentListView";
            this.assignmentListView.Size = new System.Drawing.Size(551, 656);
            this.assignmentListView.TabIndex = 2;
            this.assignmentListView.UseCompatibleStateImageBehavior = false;
            this.assignmentListView.View = System.Windows.Forms.View.Details;
            // 
            // nameColumn
            // 
            this.nameColumn.Text = "Assignment Name";
            this.nameColumn.Width = 260;
            // 
            // weightColumn
            // 
            this.weightColumn.Text = "Weight";
            this.weightColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.weightColumn.Width = 100;
            // 
            // gradeColumn
            // 
            this.gradeColumn.Text = "Grade";
            this.gradeColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gradeColumn.Width = 100;
            // 
            // statusColumn
            // 
            this.statusColumn.Text = "Status";
            this.statusColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.statusColumn.Width = 100;
            // 
            // gradingSystemLabel
            // 
            this.gradingSystemLabel.AutoSize = true;
            this.gradingSystemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradingSystemLabel.Location = new System.Drawing.Point(302, 20);
            this.gradingSystemLabel.Name = "gradingSystemLabel";
            this.gradingSystemLabel.Size = new System.Drawing.Size(141, 42);
            this.gradingSystemLabel.TabIndex = 3;
            this.gradingSystemLabel.Text = "Grades";
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.IndianRed;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.backButton.Location = new System.Drawing.Point(12, 83);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(148, 51);
            this.backButton.TabIndex = 4;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // seeAverageButton
            // 
            this.seeAverageButton.BackColor = System.Drawing.Color.SteelBlue;
            this.seeAverageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seeAverageButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.seeAverageButton.Location = new System.Drawing.Point(12, 169);
            this.seeAverageButton.Name = "seeAverageButton";
            this.seeAverageButton.Size = new System.Drawing.Size(148, 128);
            this.seeAverageButton.TabIndex = 5;
            this.seeAverageButton.Text = "See Average For Class";
            this.seeAverageButton.UseVisualStyleBackColor = false;
            this.seeAverageButton.Click += new System.EventHandler(this.seeAverageButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.CadetBlue;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.clearButton.Location = new System.Drawing.Point(12, 445);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(113, 33);
            this.clearButton.TabIndex = 12;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.CadetBlue;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.searchButton.Location = new System.Drawing.Point(12, 406);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(113, 33);
            this.searchButton.TabIndex = 11;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchBox
            // 
            this.searchBox.BackColor = System.Drawing.Color.SkyBlue;
            this.searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.Location = new System.Drawing.Point(12, 362);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(157, 38);
            this.searchBox.TabIndex = 10;
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.Location = new System.Drawing.Point(12, 334);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(86, 25);
            this.searchLabel.TabIndex = 9;
            this.searchLabel.Text = "Search:";
            // 
            // dropOutButton
            // 
            this.dropOutButton.BackColor = System.Drawing.Color.Red;
            this.dropOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropOutButton.ForeColor = System.Drawing.Color.Yellow;
            this.dropOutButton.Location = new System.Drawing.Point(12, 644);
            this.dropOutButton.Name = "dropOutButton";
            this.dropOutButton.Size = new System.Drawing.Size(148, 51);
            this.dropOutButton.TabIndex = 13;
            this.dropOutButton.Text = "Dropout!!!";
            this.dropOutButton.UseVisualStyleBackColor = false;
            this.dropOutButton.Click += new System.EventHandler(this.dropOutButton_Click);
            // 
            // StudentGrades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 727);
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
            this.Text = "TKB Grading System - Student Grades";
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
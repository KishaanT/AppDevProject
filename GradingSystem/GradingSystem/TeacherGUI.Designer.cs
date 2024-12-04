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
            this.gradingSystemLabel.AutoSize = true;
            this.gradingSystemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradingSystemLabel.Location = new System.Drawing.Point(193, 9);
            this.gradingSystemLabel.Name = "gradingSystemLabel";
            this.gradingSystemLabel.Size = new System.Drawing.Size(285, 42);
            this.gradingSystemLabel.TabIndex = 0;
            this.gradingSystemLabel.Text = "Grading System";
            // 
            // studentListView
            // 
            this.studentListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.studentColumn,
            this.studentIDcolumn});
            this.studentListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentListView.FullRowSelect = true;
            this.studentListView.HideSelection = false;
            this.studentListView.Location = new System.Drawing.Point(200, 70);
            this.studentListView.MultiSelect = false;
            this.studentListView.Name = "studentListView";
            this.studentListView.Size = new System.Drawing.Size(455, 591);
            this.studentListView.TabIndex = 1;
            this.studentListView.UseCompatibleStateImageBehavior = false;
            this.studentListView.View = System.Windows.Forms.View.Details;
            // 
            // studentColumn
            // 
            this.studentColumn.Text = "Student";
            this.studentColumn.Width = 225;
            // 
            // studentIDcolumn
            // 
            this.studentIDcolumn.Text = "Student ID";
            this.studentIDcolumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.studentIDcolumn.Width = 225;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.IndianRed;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.backButton.Location = new System.Drawing.Point(12, 70);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(148, 51);
            this.backButton.TabIndex = 2;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // seeStatusButton
            // 
            this.seeStatusButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.seeStatusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seeStatusButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.seeStatusButton.Location = new System.Drawing.Point(12, 162);
            this.seeStatusButton.Name = "seeStatusButton";
            this.seeStatusButton.Size = new System.Drawing.Size(148, 78);
            this.seeStatusButton.TabIndex = 3;
            this.seeStatusButton.Text = "See Status";
            this.seeStatusButton.UseVisualStyleBackColor = false;
            this.seeStatusButton.Click += new System.EventHandler(this.seeStatusButton_Click);
            // 
            // addModifyGradeButton
            // 
            this.addModifyGradeButton.BackColor = System.Drawing.Color.SteelBlue;
            this.addModifyGradeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addModifyGradeButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addModifyGradeButton.Location = new System.Drawing.Point(12, 280);
            this.addModifyGradeButton.Name = "addModifyGradeButton";
            this.addModifyGradeButton.Size = new System.Drawing.Size(169, 81);
            this.addModifyGradeButton.TabIndex = 4;
            this.addModifyGradeButton.Text = "Add/Modify Grade";
            this.addModifyGradeButton.UseVisualStyleBackColor = false;
            this.addModifyGradeButton.Click += new System.EventHandler(this.addModifyGradeButton_Click);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.Location = new System.Drawing.Point(12, 501);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(86, 25);
            this.searchLabel.TabIndex = 5;
            this.searchLabel.Text = "Search:";
            // 
            // searchBox
            // 
            this.searchBox.BackColor = System.Drawing.Color.SkyBlue;
            this.searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.Location = new System.Drawing.Point(12, 529);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(169, 38);
            this.searchBox.TabIndex = 6;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.CadetBlue;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.searchButton.Location = new System.Drawing.Point(12, 573);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(113, 33);
            this.searchButton.TabIndex = 7;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.CadetBlue;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.clearButton.Location = new System.Drawing.Point(12, 612);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(113, 33);
            this.clearButton.TabIndex = 8;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // TeacherGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 688);
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
            this.Text = "TKB Grading System - Teacher GUI";
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
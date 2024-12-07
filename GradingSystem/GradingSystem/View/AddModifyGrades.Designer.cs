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
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(188, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(291, 37);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Add/Modify Grades";
            // 
            // assignmentListView
            // 
            this.assignmentListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameColumn,
            this.weightColumn,
            this.gradeColumn});
            this.assignmentListView.FullRowSelect = true;
            this.assignmentListView.HideSelection = false;
            this.assignmentListView.Location = new System.Drawing.Point(203, 49);
            this.assignmentListView.MultiSelect = false;
            this.assignmentListView.Name = "assignmentListView";
            this.assignmentListView.Size = new System.Drawing.Size(452, 307);
            this.assignmentListView.TabIndex = 1;
            this.assignmentListView.UseCompatibleStateImageBehavior = false;
            this.assignmentListView.View = System.Windows.Forms.View.Details;
            // 
            // nameColumn
            // 
            this.nameColumn.Text = "Assignment Name";
            this.nameColumn.Width = 150;
            // 
            // weightColumn
            // 
            this.weightColumn.Text = "Weight";
            this.weightColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.weightColumn.Width = 150;
            // 
            // gradeColumn
            // 
            this.gradeColumn.Text = "Attributed Grade";
            this.gradeColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gradeColumn.Width = 150;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.IndianRed;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.closeButton.Location = new System.Drawing.Point(12, 305);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(148, 51);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // gradeNumericUpDown
            // 
            this.gradeNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradeNumericUpDown.Location = new System.Drawing.Point(12, 100);
            this.gradeNumericUpDown.Name = "gradeNumericUpDown";
            this.gradeNumericUpDown.Size = new System.Drawing.Size(152, 29);
            this.gradeNumericUpDown.TabIndex = 4;
            // 
            // promptLabel
            // 
            this.promptLabel.AutoSize = true;
            this.promptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.promptLabel.Location = new System.Drawing.Point(12, 72);
            this.promptLabel.Name = "promptLabel";
            this.promptLabel.Size = new System.Drawing.Size(136, 25);
            this.promptLabel.TabIndex = 5;
            this.promptLabel.Text = "Insert Grade:";
            // 
            // insertButton
            // 
            this.insertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertButton.Location = new System.Drawing.Point(13, 135);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(130, 32);
            this.insertButton.TabIndex = 6;
            this.insertButton.Text = "Insert";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // studentLabel
            // 
            this.studentLabel.AutoSize = true;
            this.studentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentLabel.Location = new System.Drawing.Point(16, 218);
            this.studentLabel.Name = "studentLabel";
            this.studentLabel.Size = new System.Drawing.Size(148, 25);
            this.studentLabel.TabIndex = 7;
            this.studentLabel.Text = "Student Name";
            // 
            // AddModifyGrades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 367);
            this.Controls.Add(this.studentLabel);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.promptLabel);
            this.Controls.Add(this.gradeNumericUpDown);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.assignmentListView);
            this.Controls.Add(this.titleLabel);
            this.Name = "AddModifyGrades";
            this.Text = "TKB Grading System - Add/Modify Grades";
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
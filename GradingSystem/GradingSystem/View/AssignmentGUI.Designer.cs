namespace GradingSystem
{
    partial class AssignmentGUI
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
            this.backButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.assignmentListView = new System.Windows.Forms.ListView();
            this.nameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.weight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.createAssignmentLabel = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.weightLabelCreate = new System.Windows.Forms.Label();
            this.weightUpDownCreate = new System.Windows.Forms.NumericUpDown();
            this.createButton = new System.Windows.Forms.Button();
            this.weightUpDownModify = new System.Windows.Forms.NumericUpDown();
            this.selectAndModifyLabel = new System.Windows.Forms.Label();
            this.weightLabelModify = new System.Windows.Forms.Label();
            this.modifyButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.weightUpDownCreate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weightUpDownModify)).BeginInit();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Firebrick;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.backButton.Location = new System.Drawing.Point(12, 373);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(160, 65);
            this.backButton.TabIndex = 2;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(300, 21);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(201, 37);
            this.titleLabel.TabIndex = 3;
            this.titleLabel.Text = "Assignments";
            // 
            // assignmentListView
            // 
            this.assignmentListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameColumn,
            this.weight});
            this.assignmentListView.FullRowSelect = true;
            this.assignmentListView.HideSelection = false;
            this.assignmentListView.Location = new System.Drawing.Point(238, 73);
            this.assignmentListView.MultiSelect = false;
            this.assignmentListView.Name = "assignmentListView";
            this.assignmentListView.Size = new System.Drawing.Size(550, 365);
            this.assignmentListView.TabIndex = 4;
            this.assignmentListView.UseCompatibleStateImageBehavior = false;
            this.assignmentListView.View = System.Windows.Forms.View.Details;
            // 
            // nameColumn
            // 
            this.nameColumn.Text = "Assignment Name";
            this.nameColumn.Width = 494;
            // 
            // weight
            // 
            this.weight.Text = "Weight";
            this.weight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.weight.Width = 50;
            // 
            // createAssignmentLabel
            // 
            this.createAssignmentLabel.AutoSize = true;
            this.createAssignmentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createAssignmentLabel.Location = new System.Drawing.Point(13, 73);
            this.createAssignmentLabel.Name = "createAssignmentLabel";
            this.createAssignmentLabel.Size = new System.Drawing.Size(200, 25);
            this.createAssignmentLabel.TabIndex = 5;
            this.createAssignmentLabel.Text = "Create Assignment:";
            // 
            // nameBox
            // 
            this.nameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.Location = new System.Drawing.Point(63, 110);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(154, 22);
            this.nameBox.TabIndex = 6;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(9, 113);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(44, 16);
            this.nameLabel.TabIndex = 8;
            this.nameLabel.Text = "Name";
            // 
            // weightLabelCreate
            // 
            this.weightLabelCreate.AutoSize = true;
            this.weightLabelCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightLabelCreate.Location = new System.Drawing.Point(9, 155);
            this.weightLabelCreate.Name = "weightLabelCreate";
            this.weightLabelCreate.Size = new System.Drawing.Size(49, 16);
            this.weightLabelCreate.TabIndex = 9;
            this.weightLabelCreate.Text = "Weight";
            // 
            // weightUpDownCreate
            // 
            this.weightUpDownCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightUpDownCreate.Location = new System.Drawing.Point(63, 153);
            this.weightUpDownCreate.Name = "weightUpDownCreate";
            this.weightUpDownCreate.Size = new System.Drawing.Size(154, 22);
            this.weightUpDownCreate.TabIndex = 10;
            // 
            // createButton
            // 
            this.createButton.BackColor = System.Drawing.Color.LimeGreen;
            this.createButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.createButton.Location = new System.Drawing.Point(12, 185);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(103, 43);
            this.createButton.TabIndex = 11;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = false;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // weightUpDownModify
            // 
            this.weightUpDownModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightUpDownModify.Location = new System.Drawing.Point(63, 281);
            this.weightUpDownModify.Name = "weightUpDownModify";
            this.weightUpDownModify.Size = new System.Drawing.Size(154, 22);
            this.weightUpDownModify.TabIndex = 12;
            // 
            // selectAndModifyLabel
            // 
            this.selectAndModifyLabel.AutoSize = true;
            this.selectAndModifyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectAndModifyLabel.Location = new System.Drawing.Point(13, 243);
            this.selectAndModifyLabel.Name = "selectAndModifyLabel";
            this.selectAndModifyLabel.Size = new System.Drawing.Size(189, 25);
            this.selectAndModifyLabel.TabIndex = 13;
            this.selectAndModifyLabel.Text = "Select and modify:";
            // 
            // weightLabelModify
            // 
            this.weightLabelModify.AutoSize = true;
            this.weightLabelModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightLabelModify.Location = new System.Drawing.Point(8, 283);
            this.weightLabelModify.Name = "weightLabelModify";
            this.weightLabelModify.Size = new System.Drawing.Size(49, 16);
            this.weightLabelModify.TabIndex = 14;
            this.weightLabelModify.Text = "Weight";
            // 
            // modifyButton
            // 
            this.modifyButton.BackColor = System.Drawing.Color.Gold;
            this.modifyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.modifyButton.Location = new System.Drawing.Point(12, 309);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.Size = new System.Drawing.Size(103, 43);
            this.modifyButton.TabIndex = 15;
            this.modifyButton.Text = "Modify";
            this.modifyButton.UseVisualStyleBackColor = false;
            this.modifyButton.Click += new System.EventHandler(this.modifyButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.OrangeRed;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.deleteButton.Location = new System.Drawing.Point(121, 309);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(103, 43);
            this.deleteButton.TabIndex = 16;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // AssignmentGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.modifyButton);
            this.Controls.Add(this.weightLabelModify);
            this.Controls.Add(this.selectAndModifyLabel);
            this.Controls.Add(this.weightUpDownModify);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.weightUpDownCreate);
            this.Controls.Add(this.weightLabelCreate);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.createAssignmentLabel);
            this.Controls.Add(this.assignmentListView);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.backButton);
            this.Name = "AssignmentGUI";
            this.Text = "TKB Grading System - Assignments GUI";
            ((System.ComponentModel.ISupportInitialize)(this.weightUpDownCreate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weightUpDownModify)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.ListView assignmentListView;
        private System.Windows.Forms.Label createAssignmentLabel;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label weightLabelCreate;
        private System.Windows.Forms.NumericUpDown weightUpDownCreate;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.NumericUpDown weightUpDownModify;
        private System.Windows.Forms.Label selectAndModifyLabel;
        private System.Windows.Forms.Label weightLabelModify;
        private System.Windows.Forms.Button modifyButton;
        private System.Windows.Forms.ColumnHeader nameColumn;
        private System.Windows.Forms.ColumnHeader weight;
        private System.Windows.Forms.Button deleteButton;
    }
}
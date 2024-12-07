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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssignmentGUI));
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
            resources.ApplyResources(this.backButton, "backButton");
            this.backButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.backButton.Name = "backButton";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
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
            this.weight});
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
            // weight
            // 
            resources.ApplyResources(this.weight, "weight");
            // 
            // createAssignmentLabel
            // 
            resources.ApplyResources(this.createAssignmentLabel, "createAssignmentLabel");
            this.createAssignmentLabel.Name = "createAssignmentLabel";
            // 
            // nameBox
            // 
            resources.ApplyResources(this.nameBox, "nameBox");
            this.nameBox.Name = "nameBox";
            // 
            // nameLabel
            // 
            resources.ApplyResources(this.nameLabel, "nameLabel");
            this.nameLabel.Name = "nameLabel";
            // 
            // weightLabelCreate
            // 
            resources.ApplyResources(this.weightLabelCreate, "weightLabelCreate");
            this.weightLabelCreate.Name = "weightLabelCreate";
            // 
            // weightUpDownCreate
            // 
            resources.ApplyResources(this.weightUpDownCreate, "weightUpDownCreate");
            this.weightUpDownCreate.Name = "weightUpDownCreate";
            // 
            // createButton
            // 
            this.createButton.BackColor = System.Drawing.Color.LimeGreen;
            resources.ApplyResources(this.createButton, "createButton");
            this.createButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.createButton.Name = "createButton";
            this.createButton.UseVisualStyleBackColor = false;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // weightUpDownModify
            // 
            resources.ApplyResources(this.weightUpDownModify, "weightUpDownModify");
            this.weightUpDownModify.Name = "weightUpDownModify";
            // 
            // selectAndModifyLabel
            // 
            resources.ApplyResources(this.selectAndModifyLabel, "selectAndModifyLabel");
            this.selectAndModifyLabel.Name = "selectAndModifyLabel";
            // 
            // weightLabelModify
            // 
            resources.ApplyResources(this.weightLabelModify, "weightLabelModify");
            this.weightLabelModify.Name = "weightLabelModify";
            // 
            // modifyButton
            // 
            this.modifyButton.BackColor = System.Drawing.Color.Gold;
            resources.ApplyResources(this.modifyButton, "modifyButton");
            this.modifyButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.UseVisualStyleBackColor = false;
            this.modifyButton.Click += new System.EventHandler(this.modifyButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.OrangeRed;
            resources.ApplyResources(this.deleteButton, "deleteButton");
            this.deleteButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // AssignmentGUI
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
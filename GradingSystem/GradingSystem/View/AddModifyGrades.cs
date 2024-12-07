using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GradingSystem.Services;

namespace GradingSystem
{
    public partial class AddModifyGrades : Form
    {
        public AddModifyGrades()
        {
            InitializeComponent();
            changeStudentLabel();
            loadData();
            ApplyTheme();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void changeStudentLabel()
        {
            //studentLabel.Text = DataService.Student.Name;
        }

        private void loadData()
        {
            // load the data here, whoever knows this model system can take care of this
            // should be retrieved from the student object
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (assignmentListView.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Please select an assignment to modify.",
                        "Select Assignment", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                ListViewItem selectedItem = assignmentListView.SelectedItems[0];
                string assignmentName = selectedItem.Text;

                if (!double.TryParse(gradeNumericUpDown.Text, out double newGrade))
                {
                    MessageBox.Show("Please enter a valid grade.",
                        "Invalid Grade", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Assignment assignmentToUpdate = DataService.Course.Assignments
                    .FirstOrDefault(a => a.Name == assignmentName);

                if (assignmentToUpdate != null)
                {
                    assignmentToUpdate.Grade = newGrade;
                    selectedItem.SubItems[2].Text = newGrade.ToString();
                    MessageBox.Show($"Grade for '{assignmentName}' updated successfully.",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Assignment '{assignmentName}' not found in the course.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ApplyTheme()
        {
            ThemeManager.ApplyTheme(this);

            if (ThemeManager.IsDarkMode)
            {
                assignmentListView.BackColor = Color.FromArgb(30, 30, 30);
                assignmentListView.ForeColor = Color.White;
                closeButton.BackColor = Color.IndianRed;
                closeButton.ForeColor = Color.White;
                promptLabel.ForeColor = Color.White;
                titleLabel.ForeColor = Color.White;
                insertButton.BackColor = Color.Black;

                gradeNumericUpDown.BackColor = Color.FromArgb(30, 30, 30);
                gradeNumericUpDown.ForeColor = Color.White;

                studentLabel.ForeColor = Color.White;
            }
            else
            {
                assignmentListView.BackColor = Color.White;
                assignmentListView.ForeColor = Color.Black;
                promptLabel.ForeColor = Color.Black;

                closeButton.BackColor = Color.IndianRed;
                closeButton.ForeColor = Color.White;
                titleLabel.ForeColor = Color.Black;
                insertButton.BackColor = Color.White;

                gradeNumericUpDown.BackColor = Color.White;
                gradeNumericUpDown.ForeColor = Color.Black;

                studentLabel.ForeColor = Color.Black;
            }
        }
    }
}
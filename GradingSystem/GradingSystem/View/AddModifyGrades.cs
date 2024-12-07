using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Globalization;
using GradingSystem.Services;

namespace GradingSystem
{
    public partial class AddModifyGrades : Form
    {
        ChangeLanguage changeLanguage = new ChangeLanguage();

        public AddModifyGrades()
        {
            
            InitializeComponent();
            changeLanguage.UpdateConfig(ApplicationLanguage.Instance.Key, ApplicationLanguage.Instance.Value);
            loadData();
            changeStudentLabel();

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void changeStudentLabel()
        {
            studentLabel.Text = DataService.Student.Name;
            
        }

        private void loadData()
        {
            List<Assignment> assignments = DataService.Student.EnrolledCourses.FirstOrDefault(c => c.CourseId == DataService.Course.CourseId).Assignments;
            foreach(Assignment assignment in assignments)
            {
                var lvitem = new ListViewItem(assignment.Name);
                lvitem.SubItems.Add(assignment.Weight.ToString());
                lvitem.SubItems.Add(assignment.Grade.ToString());
                assignmentListView.Items.Add(lvitem);

            }          
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
    
            try
            {
                // Ensure an assignment is selected
                if (assignmentListView.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Please select an assignment to modify.",
                        "Select Assignment", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Get the selected item
                ListViewItem selectedItem = assignmentListView.SelectedItems[0];
                string assignmentName = selectedItem.Text;

                // Validate and parse the new grade
                if (!double.TryParse(gradeNumericUpDown.Text, out double newGrade))
                {
                    MessageBox.Show("Please enter a valid grade.",
                        "Invalid Grade", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Update the grade in the data model
                Assignment assignmentToUpdate = DataService.Course.Assignments
                    .FirstOrDefault(a => a.Name == assignmentName);

                if (assignmentToUpdate != null)
                {
                    assignmentToUpdate.Grade = newGrade;

                    // Update the UI
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

       
    }
}

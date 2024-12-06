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
    public partial class AssignmentGUI : Form
    {
        public AssignmentGUI()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Hide();
            var form = new TeacherOperation();
            form.Closed += (s, args) => Close();
            form.Show();
        }

        private void createButton_Click(object sender, EventArgs e) 
        {
            var lvitem = new ListViewItem(nameBox.Text);
            lvitem.SubItems.Add(weightUpDownCreate.Value.ToString());
            assignmentListView.Items.Add(lvitem);
            Assignment assignment = new Assignment(nameBox.Text, Double.Parse(weightUpDownCreate.Value.ToString()));
            DataService.Course.Assignments.Add(assignment);
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            if (assignmentListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("You must select an assignment before modifying it", "Select Assignment", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string name = assignmentListView.SelectedItems[0].Text;
                assignmentListView.Items.Remove(assignmentListView.SelectedItems[0]);
                var lvitem = new ListViewItem(name);
                lvitem.SubItems.Add(weightUpDownModify.Value.ToString());
                assignmentListView.Items.Add(lvitem);
                foreach (Assignment assignment in DataService.Course.Assignments)
                {
                    if (assignment.Name == name)
                    {
                        assignment.Weight = Double.Parse(weightUpDownModify.Value.ToString());
                        break;
                    }
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (assignmentListView.SelectedItems.Count == 0)
                {
                    MessageBox.Show("You must select an assignment before deleting it.",
                        "Select Assignment", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string name = assignmentListView.SelectedItems[0].Text;

                assignmentListView.Items.Remove(assignmentListView.SelectedItems[0]);

                if (DataService.Course == null || DataService.Course.Assignments == null)
                {
                    MessageBox.Show("Course assignments data is missing.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Assignment assignmentToRemove = DataService.Course.Assignments.FirstOrDefault(a => a.Name == name);
                if (assignmentToRemove != null)
                {
                    DataService.Course.Assignments.Remove(assignmentToRemove);
                    MessageBox.Show($"Assignment '{name}' deleted successfully.",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Assignment '{name}' not found in the course.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while deleting the assignment: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}

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
            ApplyTheme();
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
        private void ApplyTheme()
        {

            ThemeManager.ApplyTheme(this);

            if (ThemeManager.IsDarkMode)
            {
                this.BackColor = Color.FromArgb(18, 18, 18);
                this.ForeColor = Color.White; 

                assignmentListView.BackColor = Color.FromArgb(30, 30, 30);
                assignmentListView.ForeColor = Color.White;

                nameBox.BackColor = Color.FromArgb(30, 30, 30);
                nameBox.ForeColor = Color.White;

                weightUpDownCreate.BackColor = Color.FromArgb(30, 30, 30);
                weightUpDownCreate.ForeColor = Color.White;

                weightUpDownModify.BackColor = Color.FromArgb(30, 30, 30);
                weightUpDownModify.ForeColor = Color.White;

                createButton.BackColor = Color.Green; 
                createButton.ForeColor = Color.White;

                modifyButton.BackColor = Color.Gold; 
                modifyButton.ForeColor = Color.White;

                deleteButton.BackColor = Color.Red; 
                deleteButton.ForeColor = Color.White;

                backButton.BackColor = Color.DarkRed; 
                backButton.ForeColor = Color.White;
            }
            else
            {
                this.BackColor = Color.White; 
                this.ForeColor = Color.Black; 

                assignmentListView.BackColor = Color.White;
                assignmentListView.ForeColor = Color.Black;

                nameBox.BackColor = Color.White;
                nameBox.ForeColor = Color.Black;

                weightUpDownCreate.BackColor = Color.White;
                weightUpDownCreate.ForeColor = Color.Black;

                weightUpDownModify.BackColor = Color.White;
                weightUpDownModify.ForeColor = Color.Black;

                createButton.BackColor = Color.Green; 
                createButton.ForeColor = Color.White;

                modifyButton.BackColor = Color.Gold; 
                modifyButton.ForeColor = Color.White;

                deleteButton.BackColor = Color.Red; 
                deleteButton.ForeColor = Color.White;

                backButton.BackColor = Color.DarkRed; 
                backButton.ForeColor = Color.White;
            }
        }
    }
}
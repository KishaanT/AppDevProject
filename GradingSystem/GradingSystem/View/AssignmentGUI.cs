using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Globalization;
using GradingSystem.Services;

namespace GradingSystem
{
    public partial class AssignmentGUI : Form
    {
        ChangeLanguage changeLanguage = new ChangeLanguage();
        public AssignmentGUI()
        {            
            changeLanguage.UpdateConfig(ApplicationLanguage.Instance.Key, ApplicationLanguage.Instance.Value);
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Hide();
            var form = new TeacherOperation();
            form.Closed += (s, args) => Close();
            form.Show();
        }

        //private void createButton_Click(object sender, EventArgs e) // Method has to add the Asssignment to the Teacher's assignment list, and also the student's assignment list.
        //{
        //    List<Assignment> assignments = DataBackupService.RestoreAssignmentsData();
        //    List<Course> courses = DataBackupService.RestoreCourseData();

        //    var lvitem = new ListViewItem(nameBox.Text);
        //    lvitem.SubItems.Add(weightUpDownCreate.Value.ToString());
        //    assignmentListView.Items.Add(lvitem);
        //    Assignment assignment = new Assignment(nameBox.Text, Double.Parse(weightUpDownCreate.Value.ToString()));
        //    courses.FirstOrDefault(c => c == DataService.Course).Assignments.Add(assignment);
        //    assignments.Add(assignment);
        //    DataService.Course.Assignments.Add(assignment);
        //    courses.FirstOrDefault(c => c == DataService.Course).Assignments.Add(assignment);
        //    DataBackupService.BackupCoursesData(courses);
        //    DataBackupService.BackupAssignmentData(assignments);
        //}

        private void createButton_Click(object sender, EventArgs e)
        {
            // Restore data from backup
            List<Assignment> assignments = DataBackupService.RestoreAssignmentsData();
            List<Course> courses = DataBackupService.RestoreCourseData();

            // Create a new ListView item and add it to the assignment ListView
            var lvitem = new ListViewItem(nameBox.Text);
            lvitem.SubItems.Add(weightUpDownCreate.Value.ToString());
            assignmentListView.Items.Add(lvitem);

            // Create a new Assignment object
            Assignment assignment = new Assignment(nameBox.Text, (double)weightUpDownCreate.Value);

            // Find the current course
            
            if (DataService.Course != null)
            {
                // Add the assignment to the current course's assignment list
                DataService.Course.Assignments.Add(assignment);
            }

            // Add the assignment to the global assignments list and the current course's assignment list
            assignments.Add(assignment);
            DataService.Course.Assignments.Add(assignment);

            // Backup the updated data
            DataBackupService.BackupCoursesData(courses);
            DataBackupService.BackupAssignmentData(assignments);

            Console.WriteLine("Assignment created and data backed up successfully.");
        }


        private void modifyButton_Click(object sender, EventArgs e)
        {
            List<Assignment> assignments = DataBackupService.RestoreAssignmentsData();
            List<Course> courses = DataBackupService.RestoreCourseData();

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
                for(int i = 0; i  < courses.Count; i++)
                {
                    if (courses[i].CourseId == DataService.Course.CourseId)
                    {
                        courses[i] = DataService.Course;
                    }
                }
                DataBackupService.BackupCoursesData(courses);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e) // Gotta handle this exception too
        {
            List<Course> courses = DataBackupService.RestoreCourseData();
            if (assignmentListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("You must select an assignment before deleting it", "Select Assignment", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string name = assignmentListView.SelectedItems[0].Text;
                assignmentListView.Items.Remove(assignmentListView.SelectedItems[0]);
                foreach (Assignment assignment in DataService.Course.Assignments)
                {
                    if (assignment.Name == name)
                    {
                        DataService.Course.Assignments.Remove(assignment);
                        break;
                    }
                }

                for (int i = 0; i < courses.Count; i++)
                {
                    if (courses[i].CourseId == DataService.Course.CourseId)
                    {
                        courses[i] = DataService.Course;
                    }
                }
                DataBackupService.BackupCoursesData(courses);
            }
        }

       
    }
}

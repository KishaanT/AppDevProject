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
    public partial class StudentGrades : Form
    {
        ChangeLanguage changeLanguage = new ChangeLanguage();
        private AssignmentSearch[] assignmentSearch;
        
        public StudentGrades()
        {
            populatAssignmentSearch();
            AddAssignments();
            changeLanguage.UpdateConfig(ApplicationLanguage.Instance.Key, ApplicationLanguage.Instance.Value);
            InitializeComponent();
          
        }
        private class AssignmentSearch
        {
            public string Name { get; set; }
            public string Weight { get; set; }
            public string Grade { get; set; }
            public string Status { get; set; }


            public AssignmentSearch(string name, string weight, string grade, string status)
            {
                Name = name;
                Weight = weight;
                Grade = grade;
                Status = status;
            }
        }

        private void populatAssignmentSearch()
        {
            assignmentSearch = new AssignmentSearch[DataService.Course.Students.Count];
            int i = 0;
            foreach (Assignment assignment in DataService.Course.Assignments)
            {
                AssignmentSearch assignmentS = new AssignmentSearch(assignment.Name, assignment.Weight.ToString(), assignment.Grade.ToString(), returnStatus(assignment.Grade));
                assignmentSearch[i] = assignmentS;
                i++;
            }
        }

        private void AddAssignments() // normally this would retrieve the students list from the course list
        {
            // Ensure course and assignments data is available
            if (DataService.Course == null || DataService.Course.Assignments == null)
            {
                MessageBox.Show("Course or assignments data is missing.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Clear existing items to avoid duplication
       

            // Retrieve assignments
            List<Assignment> assignments = DataService.Course.Assignments;

            // Populate the ListView with assignments
            foreach (Assignment assignment in assignments)
            {
                var lvitem = new ListViewItem(assignment.Name);
                lvitem.SubItems.Add(assignment.Weight.ToString("F2")); // Format weight as needed
                lvitem.SubItems.Add(assignment.Grade.ToString("F2"));  // Format grade as needed
                lvitem.SubItems.Add(returnStatus(assignment.Grade));   // Add the calculated status
                assignmentListView.Items.Add(lvitem);
            }
        }

        // Helper method to calculate the status of an assignment
        //private string returnStatus(double grade)
        //{
        //    return grade >= 60 ? "Passing" : "Failing";
        //}

        

        private void backButton_Click(object sender, EventArgs e)
        {
            Hide();
            var form = new StudentMainMenu();
            form.Closed += (s, args) => Close();
            form.Show();
        }

        private void dropOutButton_Click(object sender, EventArgs e)
        {
            var answer = MessageBox.Show("Are you sure you want to drop out?", "Drop out?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (answer == DialogResult.Yes)
            {
                MessageBox.Show("You dropped the course", "Successfully dropped out", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataService.DropStudentFromCourse(DataService.Student.Id,DataService.Course.CourseId);
                Hide();
                var form = new StudentMainMenu();
                form.Closed += (s, args) => Close();
                form.Show();
            }
            else
            {
                // do nothing
            }

        }

        private void seeAverageButton_Click(object sender, EventArgs e)
        {
            var form = new SeeClassStatus();
            form.Show();
        }

        private void searchButton_Click(object sender, EventArgs e) // Should work, but it throws an error because something is null
        {
            int preval = assignmentListView.Items.Count;
            assignmentListView.Items.Clear();
            if (preval == 0)
            {
                MessageBox.Show("Can't search while there are no assignments", "No Assignments", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                foreach (AssignmentSearch a in assignmentSearch) 
                {
                    if (a.Name.ToLower().Contains(searchBox.Text.ToLower()) || a.Weight.ToLower().Contains(searchBox.Text.ToLower()) || a.Grade.ToLower().Contains(searchBox.Text.ToLower()) || a.Status.ToLower().Contains(searchBox.Text.ToLower()))
                    {
                        assignmentListView.Items.Add(new ListViewItem(new[] { a.Name, a.Weight, a.Grade, a.Status }));
                    }
                }
            }

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            assignmentListView.Items.Clear();
            AddAssignments();
            searchBox.Text = string.Empty;
        }

        private String returnStatus(double grade)
        {
            string status = "";
            if (grade >= 60)
            {
                status = "Passing";
            }
            else
            {
                status = "Failing";
            }
            return status;
        }

    }
}

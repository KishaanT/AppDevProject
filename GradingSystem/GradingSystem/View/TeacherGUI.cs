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
    public partial class TeacherGUI : Form
    {
        private StudentSearch[] studentSearch;
        private class StudentSearch
        {
            public string StudentName { get; set; }
            public string StudentID {  get; set; } 

            public StudentSearch(string name, string id)
            {
                StudentName = name;
                StudentID = id;
            }

        }

        private void populateStudentSearch()
        {
            studentSearch = new StudentSearch[DataService.Course.Students.Count];
            int i = 0;
            foreach (Student student in DataService.Course.Students)
            {
                StudentSearch studentS = new StudentSearch(student.Name, student.Id.ToString());
                studentSearch[i] = studentS;
                i++;
            }
        }

        public TeacherGUI()
        {
            InitializeComponent();
            AddStudents();
            populateStudentSearch();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Hide();
            var form = new TeacherOperation();
            form.Closed += (s, args) => Close();
            form.Show();
        }

        private void AddStudents() 
        {
            List<Student> students = DataService.Course.Students;
            foreach (Student student in students)
            {
                var lvitem = new ListViewItem(student.Name);
                lvitem.SubItems.Add(student.Id.ToString());
                studentListView.Items.Add(lvitem);
            }
        }

        private void addModifyGradeButton_Click(object sender, EventArgs e)
        {
            if (studentListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("You must select a student first", "Select Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                foreach (Student student in DataService.Course.Students)
                {
                    if (studentListView.SelectedItems[0].Text.Equals(student.Name.ToString()))
                    {
                        DataService.Student = student;
                        var form = new AddModifyGrades();
                        form.Show();
                        break;
                    }
                }
            }
        }

        private void seeStatusButton_Click(object sender, EventArgs e)
        {
            if (studentListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("You must select a student first", "Select Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                foreach (Student student in DataService.Course.Students)
                {
                    if (studentListView.SelectedItems[0].Text.Equals(student.Name.ToString()))
                    {
                        DataService.Student = student;
                        var form = new SeeStudentStatus();
                        form.Show();
                        break;
                    }
                }
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            studentListView.Items.Clear(); 
            foreach(StudentSearch s in studentSearch)
            {
                if (s.StudentName.ToLower().Contains(searchBox.Text.ToLower()) || s.StudentID.ToLower().Contains(searchBox.Text.ToLower()))
                {
                    studentListView.Items.Add(new ListViewItem(new[] {s.StudentName, s.StudentID}));
                }
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            studentListView.Items.Clear();
            AddStudents();
            searchBox.Text = string.Empty;
        }
    }
}

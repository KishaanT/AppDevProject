using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradingSystem
{
    public partial class TeacherGUI : Form
    {
        public TeacherGUI()
        {
            InitializeComponent();
            AddStudents();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Hide();
            var form = new TeacherOperation();
            form.Closed += (s, args) => Close();
            form.Show();
        }

        public void AddStudents() // normally this would retrieve the students list from the course list
        {
            var lvitem = new ListViewItem("Thao The Man");
            lvitem.SubItems.Add("1234567");
            studentListView.Items.Add(lvitem);
            var lvitem2 = new ListViewItem("Kishaan K. Knitter");
            lvitem2.SubItems.Add("2345678");
            studentListView.Items.Add(lvitem2);
            var lvitem3 = new ListViewItem("Brian P. Diddy");
            lvitem3.SubItems.Add("3456789");
            studentListView.Items.Add(lvitem3);
        }

        private void addModifyGradeButton_Click(object sender, EventArgs e)
        {
            var form = new AddModifyGrades();
            form.Show();
        }

        private void seeStatusButton_Click(object sender, EventArgs e)
        {
            // this method has to make a reference to a student object from a course from the course list, which belongs to the teacher object (i.e. the teacher logging in)
            var form = new SeeStudentStatus();
            form.Show();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            // code to return searched items
            studentListView.Items.Clear(); // lets pretend it returns a result
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            studentListView.Items.Clear();
            AddStudents();
            searchBox.Text = string.Empty;
        }
    }
}

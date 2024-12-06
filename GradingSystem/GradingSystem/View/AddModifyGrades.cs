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
            // load the data here, whoever knows this model system can take care of this
            // should be retrieved from the student object
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            ListViewItem item = assignmentListView.SelectedItems[0];
            assignmentListView.SelectedItems[0].Remove();
            string value = item.Text;
            var lvitem = new ListViewItem(value);
            lvitem.SubItems.Add(""); // should be the second value
            lvitem.SubItems.Add(gradeNumericUpDown.Text);
            assignmentListView.Items.Add(lvitem);
            foreach(int i in DataService.Student.EnrolledCourses)
            {
                if (DataService.Student.EnrolledCourses.Contains(DataService.Course.CourseId))
                {
                    // Yeah, fuck this model logic, take care of this feature I give up
                }
            }
        }
    }
}

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
    public partial class StudentGrades : Form
    {
        public StudentGrades()
        {
            InitializeComponent();
            AddAssignments();
        }

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

        private void searchButton_Click(object sender, EventArgs e)
        {
            assignmentListView.Items.Clear(); // lets pretend it returns a result
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            assignmentListView.Items.Clear();
            AddAssignments();
            searchBox.Text = string.Empty;
        }

        private void AddAssignments()
        {
            var lvitem = new ListViewItem("Assignment 1");
            lvitem.SubItems.Add("5%");
            lvitem.SubItems.Add("100%");
            lvitem.SubItems.Add("Passing");
            assignmentListView.Items.Add(lvitem);
            var lvitem2 = new ListViewItem("Assignment 2");
            lvitem2.SubItems.Add("15%");
            lvitem2.SubItems.Add("90%");
            lvitem2.SubItems.Add("Passing");
            assignmentListView.Items.Add(lvitem2);
            var lvitem3 = new ListViewItem("Assignment 3");
            lvitem3.SubItems.Add("20%");
            lvitem3.SubItems.Add("50%");
            lvitem3.SubItems.Add("Failing");
            assignmentListView.Items.Add(lvitem3);
            var lvitem4 = new ListViewItem("Assignment 4");
            lvitem4.SubItems.Add("30%");
            lvitem4.SubItems.Add("70%");
            lvitem4.SubItems.Add("Passing");
            assignmentListView.Items.Add(lvitem4);
        }
    }
}

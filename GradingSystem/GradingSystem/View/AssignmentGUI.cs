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

        private void createButton_Click(object sender, EventArgs e) // Method has to add the Asssignment to the Teacher's assignment list, and also the student's assignment list.
        {
            var lvitem = new ListViewItem(nameBox.Text);
            lvitem.SubItems.Add(weightUpDownCreate.Value.ToString());
            assignmentListView.Items.Add(lvitem);
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            if (assignmentListView.SelectedItems[0].Text == null) // Handle this exception guys
            {
                throw new ArgumentOutOfRangeException("Must select an assignment first");
                MessageBox.Show("You must select an assignment first");
            }
            else
            {
                string name = assignmentListView.SelectedItems[0].Text;
                assignmentListView.Items.Remove(assignmentListView.SelectedItems[0]);
                var lvitem = new ListViewItem(name);
                lvitem.SubItems.Add(weightUpDownModify.Value.ToString());
                assignmentListView.Items.Add(lvitem);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e) // Gotta handle this exception too
        {
            string name = assignmentListView.SelectedItems[0].Text;
            assignmentListView.Items.Remove(assignmentListView.SelectedItems[0]);
        }
    }
}

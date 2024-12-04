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

        private void createButton_Click(object sender, EventArgs e)
        {
            var lvitem = new ListViewItem(nameBox.Text);
            lvitem.SubItems.Add(weightUpDownCreate.Value.ToString());
            assignmentListView.Items.Add(lvitem);
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            string name = assignmentListView.SelectedItems[0].Text;
            assignmentListView.Items.Remove(assignmentListView.SelectedItems[0]);
            var lvitem = new ListViewItem(name);
            lvitem.SubItems.Add(weightUpDownModify.Value.ToString());
            assignmentListView.Items.Add(lvitem);
        }
    }
}

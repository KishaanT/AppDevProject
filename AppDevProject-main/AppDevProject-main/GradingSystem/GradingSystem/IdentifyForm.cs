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
    public partial class IdentifyForm : Form
    {
        public IdentifyForm()
        {
            InitializeComponent();
        }

        private void studentButton_Click(object sender, EventArgs e)
        {
            Hide();
            var studentSignInForm = new StudentSignInForm();
            studentSignInForm.Closed += (s, args) => this.Close();
            studentSignInForm.Show();
        }

        private void teacherButton_Click(object sender, EventArgs e)
        {
            Hide();
            var teacherSignInForm = new TeacherSignInForm();
            teacherSignInForm.Closed += (s, args) => this.Close();
            teacherSignInForm.Show();
        }
    }
}

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
    public partial class SeeStudentStatus : Form
    {
        private Student student;
        private string status;

        public SeeStudentStatus()
        {
            InitializeComponent();
            //determineStanding();
            //displayAverage();
        }

        private void loadStudent()
        {
            // ok basically the idea for this method is to take the item from the previous list viewer and assign the according student object based on their names and/or object reference.
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        //private void determineStanding() // it works, but the students must have assigned values first
        //{
        //    if (student.Average >= 60)
        //    {
        //        status = "Passing";
        //    }
        //    else
        //    {
        //        status = "Failing";
        //    }
        //    passingLabel.Text = status;
        //}

        //private void displayAverage()
        //{
        //    string averageToDisplay = student.Average.ToString();
        //    averageToDisplay += "%";
        //    gradeLabel.Text = averageToDisplay;
        //}

    }
}

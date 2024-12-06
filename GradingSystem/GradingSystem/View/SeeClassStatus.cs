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

namespace GradingSystem
{
    public partial class SeeClassStatus : Form
    {
        ApplicationLanguage language = ApplicationLanguage.Instance;
        ChangeLanguage changeLanguage = new ChangeLanguage();
        public SeeClassStatus()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

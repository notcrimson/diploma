using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace курсач
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }
        public string TName
        {
            get { return testName.Text; }
            set { testName.Text = value; }
        }
        public string TPercent
        {
            get { return percentage.Text; }
            set { percentage.Text = value; }
        }
    }
}

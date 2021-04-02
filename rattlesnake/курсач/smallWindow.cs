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
    public partial class smallWindow : Form
    {
        public smallWindow()
        {
            InitializeComponent();
        }

        private void smallWindow_Load(object sender, EventArgs e)
        {
            label1.Text = "You scored a " + TestsForm.percent.ToString() + "%";
            circularProgressBar1.Value = (int)Math.Round(TestsForm.percent);
            if (TestsForm.percent <= 100 && TestsForm.percent >= 90)
            {
                circularProgressBar1.ProgressColor = Color.SeaGreen;
            }
            else if (TestsForm.percent <= 90)
            {
                circularProgressBar1.ProgressColor = Color.IndianRed;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Press OK if you want to see what you got wrong", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                this.Close();
            }
            else
            {
                //foreach (Form f in Application.OpenForms)
                //{
                //    if (f.Name != "Form3" || f.Name != "Login" || f.Name != "basicForm")
                //        f.Close();
                //}
            }

        }
    }
}

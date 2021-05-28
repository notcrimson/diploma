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
            label1.Text = "You scored a " + ((int)Math.Round(TestsForm.percent)).ToString() + "%";
            circularProgressBar1.Value = (int)Math.Round(TestsForm.percent);
            if (TestsForm.percent <= 100 && TestsForm.percent >= 90)
            {
                circularProgressBar1.ProgressColor = Color.SeaGreen;
                label2.Text = "Congrats, you passed!";
            }
            else if (TestsForm.percent <= 90 && TestsForm.percent >=50)
            {
                circularProgressBar1.ProgressColor = Color.Gold;
                label2.Text = "Very close, try again.";
            }
            else if (TestsForm.percent <= 50)
            {
                circularProgressBar1.ProgressColor = Color.IndianRed;
                label2.Text = "You did'nt pass, try again next time.";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Press OK if you want to see what you got wrong", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                Dispose();
                this.Close();
            }
            else
            {
                List<Form> openForms = new List<Form>();
                foreach (Form f in Application.OpenForms)
                    openForms.Add(f);

                foreach (var f in openForms)
                {
                    if (f.Name != "Login")
                    {
                        f.Close();
                        f.Dispose();
                    }
                }
                openForms.Clear();
                //TestsForm.testForm.Close();
                Form3 MMenu = new Form3();
                MMenu.Show();
                //Close();
                //foreach (Form f in Application.OpenForms)
                //{
                //    if (f.Name != "Form3" || f.Name != "Login" || f.Name != "basicForm")
                //        f.Close();
                //}
            }

        }
    }
}

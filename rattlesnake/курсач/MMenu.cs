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
    public partial class Form3 : basicForm
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label3.Text = "Welcome back " + Login.USER.Name + "!";
            Login l = new Login();
            previousForm = l;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Units pu = new Units();
            pu.Show();
        }

        private void profile_Click(object sender, EventArgs e)
        {
            this.Hide();
            Profile profile = new Profile();
            profile.Show();
        }
    }
}

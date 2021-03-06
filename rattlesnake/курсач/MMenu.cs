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
            BackButton.Visible = false;
            label3.Text = "Welcome back " + USER.Name + "!";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Units pu = new Units();
            pu.Show();
        }

        private void profile_Click(object sender, EventArgs e)
        {
            this.Close();
            Profile profile = new Profile();
            profile.Show();
        }

        private void VocabularyButton_Click(object sender, EventArgs e)
        {
            this.Close();
            VocabularyForm vocabularyForm = new VocabularyForm();
            vocabularyForm.Show();
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}

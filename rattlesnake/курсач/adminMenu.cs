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
    public partial class adminMenu : basicForm
    {
        public adminMenu()
        {
            InitializeComponent();
        }

        private void adminMenu_Load(object sender, EventArgs e)
        {
            BackButton.Visible = false;
            label3.Text = "Welcome back " + USER.Name + "!";
        }
        private void addPu_Click(object sender, EventArgs e)
        {
            Close();
            AdminPUsChanges apc = new AdminPUsChanges();
            apc.Show();
        }

        private void addTest_Click(object sender, EventArgs e)
        {
            Close();
            Units un = new Units();
            un.Show();
        }

        private void addVocabulary_Click(object sender, EventArgs e)
        {
            Close();
            AddVocabulary addVocabularyForm = new AddVocabulary();
            addVocabularyForm.Show();
        }
    }
}

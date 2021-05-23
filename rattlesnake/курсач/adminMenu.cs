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
            Login login = new Login();
            previousForm = login;
            label3.Text = "Welcome back " + Login.USER.Name + "!";
        }
        private void addPu_Click(object sender, EventArgs e)
        {
            Hide();
            AdminPUsChanges apc = new AdminPUsChanges();
            apc.Show();
        }

        private void addTest_Click(object sender, EventArgs e)
        {
            Hide();
            Units un = new Units();
            un.Show();
        }

        private void addVocabulary_Click(object sender, EventArgs e)
        {
            Hide();
            AddVocabulary addVocabularyForm = new AddVocabulary();
            addVocabularyForm.Show();
        }
    }
}

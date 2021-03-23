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
            Login login = new Login();
            previousForm = login;
        }
        private void addPu_Click(object sender, EventArgs e)
        {
            AdminPUsChanges apc = new AdminPUsChanges();
            apc.Show();
            Hide();
        }

        private void addTest_Click(object sender, EventArgs e)
        {
            Units un = new Units();
            un.Show();
            Hide();
        }
    }
}

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
    public partial class Login : basicForm
    {
        public static User USER { get; set; }
        

        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "test";
            textBox2.Text = "pas1!A";
            ActiveControl = textBox1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User usr = db.Users.Where(x=> x.Login == textBox1.Text).FirstOrDefault();
            if ((usr != null) && (usr.Password == textBox2.Text))
            {
                USER = usr;
                previousForm = this;

                if (usr.Role == "admin")
                {
                    adminMenu admin = new adminMenu();
                    admin.Show();
                    this.Hide();
                }
                else if (usr.Role == "student")
                {
                    Form3 menu = new Form3();
                    menu.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Incorrect Password or Login\nCheck if you entered the them correctly", "Wrong credentials", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Login_Resize(object sender, EventArgs e)
        {
            //int locx = (this.Width) / 2 - (textBox1.Width / 2);
            //int locy = textBox1.Location.Y;
            //textBox1.Location = new Point(locx, locy);
        }
        private void Register_Click(object sender, EventArgs e)
        {
            Register reg = new Register();
            reg.Show();
            Hide();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

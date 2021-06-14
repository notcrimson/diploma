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
        private Users usr = new Users();
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //previousForm = null;
            usr = null;
            USER = null;
            textBox1.Text = "test";
            textBox2.Text = "pas1!A";
            ActiveControl = textBox1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            usr = db.Users.FirstOrDefault(x => x.Login == textBox1.Text && x.Password == textBox2.Text);

            if (usr != null)
            {
                using (Model1 dbo = new Model1())
                {
                    USER = usr;
                    User_Log adminLog = dbo.User_Log.FirstOrDefault(x => x.UserID == USER.UserId);

                    if (adminLog == null)
                    {
                        if (usr.Role == "admin")
                        {
                            this.Hide();
                            //this.Visible = false;
                            adminMenu admin = new adminMenu();
                            admin.Show();
                        }
                        else if (usr.Role == "student")
                        {
                            this.Hide();
                            //this.Visible = false;
                            Form3 menu = new Form3();
                            menu.Show();
                        }
                    }
                    else
                    {
                        this.Hide();
                        Type type = Type.GetType("курсач." + adminLog.LastFormUsed);
                        Form f = (Form)Activator.CreateInstance(type);
                        f.Show();
                    }
                }
            }
            else
            {
                MessageBox.Show("Incorrect Password or Login\nCheck if you entered the them correctly", "Wrong credentials", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            usr = null; // clearing memory
        }

        private void Login_Resize(object sender, EventArgs e)
        {
            //int locx = (this.Width) / 2 - (textBox1.Width / 2);
            //int locy = textBox1.Location.Y;
            //textBox1.Location = new Point(locx, locy);
        }
        private void Register_Click(object sender, EventArgs e)
        {
            Hide();
            Register reg = new Register();
            reg.Show();
        }

        private void textBox2_MouseHover(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '\0';
        }

        private void textBox2_MouseLeave(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '•';
        }

        private void Login_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible == true)
            {
                usr = null;
                USER = null;
            }
            else
            {
                return;
            }
        }
    }
}

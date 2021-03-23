using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace курсач
{
    public partial class Profile : basicForm
    {
        public Profile()
        {
            InitializeComponent();
        }
        private void Profile_Load(object sender, EventArgs e)
        {
            Form3 menu = new Form3();
            previousForm = menu;

            User studnet = db.Users.Where(x => x.UserId == Login.USER.UserId && x.Role == "student").FirstOrDefault();
            if (studnet != null)
            {
                using (var ms = new MemoryStream(studnet.ProfilePic))
                {
                    pictureBox2.Image = Image.FromStream(ms);
                }
                label3.Text = studnet.Name;
            }
            var results = db.Results.Where(x => x.StudentID == Login.USER.UserId);
            foreach (var result in results)
            {
                UserControl1 resultControl = new UserControl1();
                //resultControl.AutoSize = true;
                //resultControl.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
                resultControl.TName = result.Test_name;
                resultControl.TPercent = result.Percentage;
                resultLayoutPanel.Controls.Add(resultControl);
            }
        }
        protected override void BackButton_Click(object sender, EventArgs e)
        {
            previousForm.Show();
            Close();
        }
    }
}

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
using курсач;

namespace курсач
{
    public partial class Profile : basicForm
    {
        private Users student { get; set; }
        public Profile()
        {
            InitializeComponent();
        }
        private void Profile_Load(object sender, EventArgs e)
        {
            Form3 menu = new Form3();
            _prevForm = menu;

            student = db.Users.FirstOrDefault(x => x.UserId == USER.UserId && x.Role == "student");
            if (student != null)
            {
                using (MemoryStream ms = new MemoryStream(student.ProfilePic))
                {
                    pictureBox2.Image = Image.FromStream(ms);
                    ms.Dispose();
                }
                label3.Text = student.Name;
                student = null;

            }
            GetResults();
        }
        private void GetResults()
        {
            IQueryable<Result> results = db.Result.Where(x => x.StudentID == USER.UserId).OrderByDescending(d => d.Date);
            foreach (var result in results)
            {
                UserControl1 resultControl = new UserControl1();
                resultControl.TName = result.Test_name;
                resultControl.TDate = result.Date?.ToString("dd/mm/yyyy\n" +
                    "H:mm"); ;
                resultControl.TPercent = result.Percentage.ToString() + "%";
                if (result.Percentage <= 100 && result.Percentage >= 90)
                {
                    resultControl.BackColor = Color.SeaGreen;
                }
                else if (result.Percentage <= 90 && result.Percentage >= 50)
                {
                    resultControl.BackColor = Color.FromArgb(246, 160, 21);
                }
                else if (result.Percentage < 50)
                {
                    resultControl.BackColor = Color.IndianRed;
                }
                resultLayoutPanel.Controls.Add(resultControl);
            }
            results = null;

        }

        //protected override void BackButton_Click(object sender, EventArgs e)
        //{
        //    Close();
        //    previousForm.Show();

        //}
    }
}

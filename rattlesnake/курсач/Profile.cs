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
using System.Linq.Expressions;

namespace курсач
{
    public partial class Profile : basicForm
    {
        private Users student { get; set; }
        string SelectedPU { get; set; }
        string test { get; set; }
        public Profile()
        {
            InitializeComponent();
        }
        private void Profile_Load(object sender, EventArgs e)
        {
            Form3 menu = new Form3();
            _prevForm = menu;
            List<string> test = new List<string>();
            test.Add("All professional units");
            test.AddRange(db.The_Test.Select(x => x.Name_of_PU).Distinct().ToList());
            the_TestBindingSource.DataSource = test;
            SelectedPU = PUsortComboBox.SelectedItem.ToString();

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
            GetResults(db.Result.Where(x => x.StudentID == USER.UserId).OrderByDescending(d => d.Date).ToList());
        }
        private void GetResults(List<Result> results)
        {
            foreach (var result in results)
            {
                UserControl1 resultControl = new UserControl1();
                resultControl.TName = result.Test_name;
                resultControl.TDate = result.Date?.ToString("dd/MM/yyyy\n" +
                    "H:mm");
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
        }

        private void PUsortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            resultLayoutPanel.Controls.Clear();
            if (PUsortComboBox.SelectedItem is null) return;
            SelectedPU = PUsortComboBox.SelectedItem.ToString();
            if (dateRadioButton.Checked)
                distinctPu(db.Result.Where(x => x.StudentID == USER.UserId).OrderByDescending(d => d.Date).ToList(),
                    db.Result.Where(x => x.StudentID == USER.UserId && x.Test_name == test), d => d.Date);
            else if (percentageRadioButton.Checked)
                distinctPu(db.Result.Where(x => x.StudentID == USER.UserId).OrderByDescending(p => p.Percentage).ToList(),
                    db.Result.Where(x => x.StudentID == USER.UserId && x.Test_name == test), p => p.Percentage);
        }

        private void filter_Changed(object sender, EventArgs e)
        {
            resultLayoutPanel.Controls.Clear();
            if (dateRadioButton.Checked)
                distinctPu(db.Result.Where(x => x.StudentID == USER.UserId).OrderByDescending(d => d.Date).ToList(),
                    db.Result.Where(x => x.StudentID == USER.UserId && x.Test_name == test), d => d.Date);
            else if (percentageRadioButton.Checked)
                distinctPu(db.Result.Where(x => x.StudentID == USER.UserId).OrderByDescending(p => p.Percentage).ToList(),
                    db.Result.Where(x => x.StudentID == USER.UserId && x.Test_name == test), p => p.Percentage);

        }
        private void distinctPu(List<Result> resultForAllPU, IQueryable<Result> resultForSpecificPU, Func<Result, object> parameter)
        {
            List<Result> res = new List<Result>();
            if (SelectedPU == "All professional units")
                GetResults(resultForAllPU);
            else
            {
                var testsFromSelectedPU = from selectedPu in db.The_Test
                                          where selectedPu.Name_of_PU == SelectedPU
                                          select selectedPu.Test_name;

                foreach (var testName in testsFromSelectedPU)
                {
                    test = testName;
                    res.AddRange(resultForSpecificPU);
                }
                if (dateRadioButton.Checked)
                    GetResults(res.OrderByDescending(parameter).ToList());
                else if (percentageRadioButton.Checked)
                    GetResults(res.OrderByDescending(parameter).ToList());
            }
            test = null;
        }
    }
}


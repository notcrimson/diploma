using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace курсач
{
    public partial class listOfTests : basicForm
    {
        public listOfTests()
        {
            InitializeComponent();
        }

        private void listOfTests_Load(object sender, EventArgs e)
        {
            Units units = new Units();
            _prevForm = units;

            var queryOftests = from t in db.The_Test
                               where t.Name_of_PU == selectedPU
                               select t.Test_name;

            string previouseItem = queryOftests.ToList()[0];
            listBox1.Items.Add(queryOftests.ToList()[0]);
            foreach (var test in queryOftests.ToList().Skip(1))
            {
                Result passedTest = db.Result.Where(x => x.StudentID == USER.UserId && x.Test_name == previouseItem && x.Percentage >= 90).FirstOrDefault();
                if (passedTest != null)
                {
                    listBox1.Items.Add(test);
                    previouseItem = test;
                }
                else
                {
                    listBox1.Items.Add("🔒" + test);
                    previouseItem = test;
                }
            }
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                if (Regex.IsMatch(listBox1.SelectedItem.ToString(), @"🔒"))
                {
                    writeTest.Visible = false;
                    return;
                }
                else
                {
                    testName = listBox1.SelectedItem.ToString();
                    writeTest.Visible = true;
                }
            }
        }
        private void goToTest()
        {
            if (Regex.IsMatch(listBox1.SelectedItem.ToString(), @"🔒"))
            {
                return;
            }
            else
            {
                Close();
                TestsForm testForm = new TestsForm();
                testForm.Show();
            }
        }
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            goToTest();
        }

        private void writeTest_Click(object sender, EventArgs e)
        {
            goToTest();
        }

    }
}

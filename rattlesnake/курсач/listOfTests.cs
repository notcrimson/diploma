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
        public static string testName;
        public static bool finishedPU;
        public listOfTests()
        {
            InitializeComponent();
        }

        private void listOfTests_Load(object sender, EventArgs e)
        {
            Units u = new Units();
            previousForm = u;

            var queryOftests = from t in db.The_Test
                               where t.Name_of_PU == selectedItem
                               select t.Test_name;

            
            string previouseItem = queryOftests.ToList()[0];
            listBox1.Items.Add(queryOftests.ToList()[0]);
            foreach (var test in queryOftests.ToList().Skip(1))
            {
                var passedTest = db.Result.Where(x => x.StudentID == Login.USER.UserId && x.Test_name == previouseItem && x.Percentage >= 90).FirstOrDefault();
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

            int j = 0;
            foreach (string testInList in listBox1.Items)
            {
                if (Regex.IsMatch(testInList, @"🔒"))
                {
                    j++;
                }
            }
            if (j == 0)
            {
                finishedPU = true;
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
                TestsForm testForm = new TestsForm();
                testForm.Show();
                Hide();
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

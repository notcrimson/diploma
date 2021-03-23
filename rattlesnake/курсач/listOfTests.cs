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
    public partial class listOfTests : basicForm
    {
        public static string testName;
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

            foreach(var tests in queryOftests)
            {
                listBox1.Items.Add(tests);
            }

        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                testName = listBox1.SelectedItem.ToString();
                //panel3.Visible = true;
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            TestsForm te = new TestsForm();
            te.Show();
            Hide();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

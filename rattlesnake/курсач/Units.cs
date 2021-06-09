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
    public partial class Units : basicForm
    {
        public Units()
        {

            InitializeComponent();
        }

        private void Units_Load(object sender, EventArgs e)
        {
            if (USER.Role == "student")
            {
                Form3 menu = new Form3();
                _prevForm = menu;


                List<string> profUnits = db.Professional_units.Select(x => x.Name_of_PU).ToList();
                listBox1.Items.Add(profUnits[0]);
                //string previouseItem = profUnits[0];
                //foreach (var profUnit in profUnits)
                for (int i = 0; i < profUnits.Count; i++)
                {
                    bool finishedPU = false;
                    bool noTestsInPU = false;
                    int j = 0;
                    string tstName = profUnits[i];
                    var queryOftests = from t in db.The_Test
                                       where t.Name_of_PU == tstName
                                       select t.Test_name;

                    foreach (var test in queryOftests)
                    {
                        //if (test == "Introduction to programming test questions")
                        //{
                        //    //j++;
                        //    continue;
                        //}
                        Result passedTest = db.Result.Where(x => x.StudentID == USER.UserId && x.Test_name == test && x.Percentage >= 90).FirstOrDefault();
                        if (passedTest != null)
                            continue;
                        else
                        {
                            j++;
                        }

                    }

                    if (queryOftests.Count() == 0)
                    {
                        try
                        {
                            listBox1.Items.Add("🔒 " + profUnits[i + 1]);
                            noTestsInPU = true;
                        }
                        catch (System.ArgumentOutOfRangeException)
                        {
                            break;
                        }
                    }
                    if (!noTestsInPU)
                    {
                        if (j == 0)
                            finishedPU = true;

                        if (finishedPU)
                        {
                            try
                            {
                                listBox1.Items.Add(profUnits[i + 1]);
                            }
                            catch (System.ArgumentOutOfRangeException)
                            {
                                break;
                            }
                        }
                        else
                        {
                            try
                            {
                                listBox1.Items.Add("🔒 " + profUnits[i + 1]);
                            }
                            catch (System.ArgumentOutOfRangeException)
                            {
                                break;
                            }
                        }
                    }
                    queryOftests.ToList().Clear(); // clearing memory
                }
                profUnits.Clear(); // clearing memory
            }
            else if (USER.Role == "admin")
            {
                adminMenu adminMenu = new adminMenu();
                _prevForm = adminMenu;
                var pus = from p in db.Professional_units
                          select new { p.Name_of_PU };
                foreach (var Pu in pus)
                {
                    listBox1.Items.Add(Pu.Name_of_PU);
                }
                pus = null;
            }
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                if (USER.Role == "student")
                {
                    if (Regex.IsMatch(listBox1.SelectedItem.ToString(), @"🔒"))
                        panel3.Visible = false;
                    else
                    {
                        panel3.Visible = true;
                        selectedPU = listBox1.SelectedItem.ToString();
                    }
                }
                else if (USER.Role == "admin")
                {
                    panel5.Visible = true;
                    selectedPU = listBox1.SelectedItem.ToString();
                }
            }
        }

        private void OpenPU_Click(object sender, EventArgs e)
        {
            Close();
            StudentPU sPU = new StudentPU();
            sPU.Show();

        }

        private void Write_a_test_Click(object sender, EventArgs e)
        {
            Close();
            listOfTests test = new listOfTests();
            test.Show();

        }
        private void addTest_Click(object sender, EventArgs e)
        {
            Close();
            adminAddTests a = new adminAddTests();
            a.Show();

        }
        private void Units_Resize(object sender, EventArgs e)
        {
            //int locx = (flowLayoutPanel1.Width) / 2 - (panel3.Width / 2);
            //int locy = panel3.Location.Y;
            //panel3.Location = new Point(locx, locy);

            //int locx2 = (flowLayoutPanel1.Width) / 2 - (listBox1.Width / 2);
            //int locy2 = listBox1.Location.Y;
            //listBox1.Location = new Point(locx2, locy2);
        }

        private void Units_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            StudentPU sPU = new StudentPU();
            sPU.Show();
        }
    }
}

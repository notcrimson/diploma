using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace курсач
{
    public partial class TestsForm : basicForm
    {
        //public static Form testForm = new Form();
        List<string> multipleAnswers = new List<string>();
        List<string> seperatedAnswer = new List<string>();
        public static float percent;
        string[] seperator1 = { ";" };
        string[] seperator2 = { ", " };
        int count;
        public TestsForm()
        {
            InitializeComponent();
        }

        private void Tests_Load(object sender, EventArgs e)
        {
            if (selectedPU == null)
                selectedPU = Properties.Settings.Default.selectedPu;
            if (testName == null)
                testName = Properties.Settings.Default.testName;
            //List<object> lmao = new List<object>();
            //var quer = from paa in db.Tests
            //           where paa.Test_name == "kek2"
            //           select paa;
            //foreach (var aa in quer)
            //{
            //    lmao.Add(aa);
            //}
            //testBindingSource.DataSource = lmao;

            listOfTests l = new listOfTests();
            _prevForm = l;


            label1.Text = listOfTests.testName;
            int a = 0;
            int b = 0;
            int j = panel3.Location.X;


            var queryForAns = from testAnswers in db.Questions
                              where testAnswers.Test_name == listOfTests.testName
                              select testAnswers.Answers;


            foreach (var answers in queryForAns)
            {
                multipleAnswers.AddRange(answers.Split(seperator1, StringSplitOptions.RemoveEmptyEntries));
            }
            foreach (var sep in multipleAnswers)
            {
                seperatedAnswer.AddRange(sep.Split(seperator2, StringSplitOptions.RemoveEmptyEntries));
            }

            string[] sepp = seperatedAnswer.ToArray();

            var queryForNQ = from k in db.Questions
                             where k.Test_name == listOfTests.testName
                             select k.Question;
            count = queryForNQ.Count();


            List<string> Questions = new List<string>();
            foreach (var q in queryForNQ)
            {
                Questions.Add(q);
            }

            List<string> ans = new List<string>();
            List<int> numberOfAnswers = new List<int>();


            for (int i = 0; i <= Questions.Count - 1; i++)
            {
                string s = Questions[i];
                var qForPossibleAnswers = from pA in db.Questions
                                          where pA.Question == s && pA.Test_name == label1.Text
                                          select pA.Answers;

                foreach (var q in qForPossibleAnswers)
                {
                    ans.AddRange(q.Split(seperator2, StringSplitOptions.RemoveEmptyEntries));
                }
                numberOfAnswers.Add(ans.Count);
                ans.Clear();
            }

            int p = 0;
            for (int i = 0; i < count; i++)
            {
                int answerY = radioButton2.Location.Y;
                Panel gp = new Panel();
                gp.Name = "questionPanel" + i.ToString();
                gp.Location = new Point(panel3.Location.X, j);
                
                gp.BorderStyle = panel3.BorderStyle;
                gp.BackColor = panel3.BackColor;
                gp.Size = panel3.Size;
                gp.Visible = true;
                j += 230;

                Label ll = new Label();
                ll.Location = label3.Location;
                ll.AutoSize = label3.AutoSize;
                ll.Size = label3.Size;
                ll.Text = Questions[b];
                b++;
                gp.Controls.Add(ll);


                for (int d = 0; d < numberOfAnswers[p]; d++)
                {
                    RadioButton rd = new RadioButton();
                    rd.Location = new Point(radioButton2.Location.X, answerY);
                    rd.BackColor = radioButton2.BackColor;
                    rd.AutoSize = true;

                    rd.Text = sepp[a];
                    a++;
                    answerY += 53;

                    gp.Controls.Add(rd);
                    Control c2 = new Control();
                    //Control c3 = new Control();
                    //if (c.GetType() == typeof(Label))
                    //{
                    //    c3 = new Label();
                    //    c3.Location = c.Location;
                    //    c3.Size = c.Size;
                    //    c3.Text = Questions[b];
                    //    b++;
                    //}
                    //if (c.GetType() == typeof(RadioButton))
                    //{
                    //    c2 = new RadioButton();
                    //    c2.Location = c.Location;
                    //    c2.Size = c.Size;
                    //    c2.Text = sepp[a];
                    //    a++;
                    //}
                    //gp.Controls.Add(c2);
                    //gp.Controls.Add(c3);
                }
                p++;
                //MessageBox.Show(sepp.Length.ToString());
                flowLayoutPanel1.Controls.Add(gp);

            }
        }
       
        private void finishTest_Click(object sender, EventArgs e)
        {
            float correct = 0;
            string k = "";
            string label = "";
            
            multipleAnswers.Clear();
            seperatedAnswer.Clear();

            var checkCorrectAnswers = from CorrectAnswers in db.The_Test
                                      where CorrectAnswers.Test_name == listOfTests.testName
                                      select CorrectAnswers.Correct_answers;
            foreach (var ans in checkCorrectAnswers)
            {
                multipleAnswers.AddRange(ans.Split(seperator1, StringSplitOptions.RemoveEmptyEntries));
            }
            foreach (var sep in multipleAnswers)
            {
                seperatedAnswer.AddRange(sep.Split(seperator2, StringSplitOptions.RemoveEmptyEntries));
            }

            //Test
            //string l = "";
            //for (int i = 0; i < seperatedAnswer.Count; i++)
            //{
            //    l += seperatedAnswer[i];
            //}
            //MessageBox.Show(l);



            List<string> answers = new List<string>();
            foreach (Panel p in flowLayoutPanel1.Controls)
            {
                foreach (Control c in p.Controls)
                {
                    if (c is RadioButton)
                    {
                        if (((RadioButton)c).Checked)
                        {
                            answers.Add(c.Text);
                        }
                    }
                }
            }
            if (answers.Count == seperatedAnswer.Count)
            {
                //testForm = this;
                foreach (Panel p in flowLayoutPanel1.Controls)
                {
                    foreach (Control c in p.Controls)
                    {
                        if (c is Label)
                        {
                            label = c.Text;
                        }
                        if (c is RadioButton)
                        {
                            if (((RadioButton)c).Checked)
                            {
                                Questions q = db.Questions.Where(x => x.Question == label && x.Test_name == label1.Text).FirstOrDefault();
                                if (c.Text == q.Correct_Answer)
                                {
                                    p.ForeColor = Color.White;
                                    p.BackColor = Color.SeaGreen;
                                }
                                else
                                {
                                    p.ForeColor = Color.White;
                                    p.BackColor = Color.IndianRed;
                                }
                            }
                        }
                    }
                }
                for (int i = 0; i < answers.Count; i++)
                {
                    if (answers[i] == seperatedAnswer[i])
                        correct++;

                    if (i + 1 == answers.Count)
                    {
                        k += answers[i] + ";";
                    }
                    else
                    {
                        k += answers[i] + ", ";
                    }

                }
                //MessageBox.Show(correct.ToString());
                //MessageBox.Show(k);
                //MessageBox.Show(selectedItem);

                percent = (correct / count) * 100;

                Result r = new Result();
                r.Test_name = listOfTests.testName;
                r.Answers = k;
                r.StudentID = USER.UserId;
                r.Percentage = (int)Math.Round(percent);
                r.Date = DateTime.Now;
                db.Result.Add(r);
                try
                {
                    db.SaveChanges();
                    smallWindow s = new smallWindow();
                    s.Show();
                }
                catch (System.Data.Entity.Validation.DbEntityValidationException ex)
                {
                    foreach (var validationErrors in ex.EntityValidationErrors)
                    {
                        foreach (var validationError in validationErrors.ValidationErrors)
                        {
                            MessageBox.Show($"Property: {validationError.PropertyName} Error: {validationError.ErrorMessage}");
                        }
                    }
                }
                finishTest.Visible = false;
            }
            else
            {
                MessageBox.Show("Answer all the questions!");
            }
        }
    }
}

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
    public partial class adminAddTests : basicForm
    {
        public int j;
        public int spaceBetweenQ;
        public int ind = 1;
        public int panelNumber = 1;
        public string panelN;
        public string panelPossibleAnswerName;
        public string panelToDelete;
        public Control pp;
        public adminAddTests()
        {
            InitializeComponent();
        }

        private void adminAddTests_Load(object sender, EventArgs e)
        {
            ActiveControl = textBox3;
            Units am = new Units();
            previousForm = am;
            j = panel0.Location.Y;
            spaceBetweenQ = textBox2.Location.Y + 50;
            addQues();
        }
        public void addQues()
        {
            Panel p = new Panel();
            p.Name = "panel" + (panelNumber).ToString();
            p.Location = new Point(panel0.Location.X, j);
            p.Size = new Size(870, 184);
            p.BorderStyle = panel0.BorderStyle;
            p.BackColor = panel0.BackColor;
            p.Enter += new EventHandler(this.panel0_Enter);
            j += 293;
            panelNumber++;

            Label l = new Label();
            l.Location = label3.Location;
            l.Size = label3.Size;
            l.Text = label3.Text;

            TextBox t = new TextBox();
            t.Location = questionField.Location;
            t.Size = questionField.Size;
            t.Name = questionField.Name;

            p.Controls.Add(l);
            p.Controls.Add(t);

            // creating question 
            TextBox posAnswerTextBox = new TextBox();
            posAnswerTextBox.Location = textBox2.Location;
            posAnswerTextBox.Size = textBox2.Size;
            posAnswerTextBox.Enter += new EventHandler(this.textBox2_Enter);
            posAnswerTextBox.TextChanged += new EventHandler(this.textBox2_TextChanged);

            RadioButton posAnswerRadioBut = new RadioButton();
            posAnswerRadioBut.Location = radioButton1.Location;
            posAnswerRadioBut.Size = radioButton1.Size;
            posAnswerRadioBut.Text = radioButton1.Text;


            //p.Controls.Add(possibleAnswer);
            p.Controls.Add(posAnswerTextBox);
            p.Controls.Add(posAnswerRadioBut);

            //p.Controls.Add(panQ);

            // CREATING BOTTEM PANEL WITH THE ADD AND DELETE BUTTONS
            Panel bp = new Panel();
            bp.Name = panel4.Name;
            bp.Dock = DockStyle.Bottom;
            bp.Location = panel4.Location;
            bp.Size = panel4.Size;
            bp.BorderStyle = panel4.BorderStyle;
            bp.BackColor = panel4.BackColor;
            //bp.Enter += new EventHandler(this.panel4_Enter);

            Button add = new Button();
            add.Location = addAnswer.Location;
            add.Size = addAnswer.Size;
            add.Text = addAnswer.Text;
            add.BackColor = addAnswer.BackColor;
            add.Click += new EventHandler(this.addAnswer_Click);

            Button del = new Button();
            del.Location = button2.Location;
            del.Size = button2.Size;
            del.Text = button2.Text;
            del.BackColor = button2.BackColor;
            del.Click += new EventHandler(this.deletePossibleAnswer);



            bp.Controls.Add(add);
            bp.Controls.Add(del);
            //bp.Controls.Add(le);
            //bp.Controls.Add(cmb);

            p.Controls.Add(bp);
            flowLayoutPanel1.Controls.Add(p);
        }
        private void addQuestion_Click(object sender, EventArgs e)
        {
            addQues();
        }

        private void deleteQ_Click(object sender, EventArgs e)
        {
            var panel = flowLayoutPanel1.Controls[panelN];
            if (flowLayoutPanel1.Controls.Count > 1)
            {
                flowLayoutPanel1.Controls.RemoveAt(flowLayoutPanel1.Controls.Count - 1);
            }
        }
        public int textbox = 0;
        public int radiobutton = 0;
        private void addAnswer_Click(object sender, EventArgs e)
        {
            TextBox posAnswerTextBox = new TextBox();
            posAnswerTextBox.Location = new Point(textBox2.Location.X, spaceBetweenQ);
            posAnswerTextBox.Size = textBox2.Size;
            posAnswerTextBox.Enter += new EventHandler(this.textBox2_Enter);
            posAnswerTextBox.TextChanged += new EventHandler(this.textBox2_TextChanged);

            RadioButton posAnswerRadioBut = new RadioButton();
            posAnswerRadioBut.Location = new Point(radioButton1.Location.X, spaceBetweenQ);
            posAnswerRadioBut.Size = radioButton1.Size;

            spaceBetweenQ += 50;

            var panel = flowLayoutPanel1.Controls[panelN];
            //panel.Controls.Add(anotherAnswer);
            //panel.Controls.Add(possibleAnswer);
            panel.Controls.Add(posAnswerTextBox);
            panel.Controls.Add(posAnswerRadioBut);

            panel.Size = new Size(panel.Width, panel.Height + 50);
        }

        private void deletePossibleAnswer(object sender, EventArgs e)
        {

            var panel = flowLayoutPanel1.Controls[panelN];
            //MessageBox.Show(panel.Controls.Count.ToString());
            if (panel.Controls.Count > 5)
            {
                panel.Controls.RemoveAt(panel.Controls.Count - 1);
                panel.Controls.RemoveAt(panel.Controls.Count - 1);
            }

            panel.MinimumSize = new Size(870, 184);
            panel.Size = new Size(panel.Width, panel.Height - 50);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //int countQ = 0;
            //var panel = flowLayoutPanel1.Controls[panelN];
            //foreach (Control h in panel.Controls)
            //{
            //    if (h.GetType() == typeof(RadioButton))
            //    {
            //        countQ++;
            //    }
            //}

            //for (int i = 0; i < countQ; i++)
            //{
            //    spaceBetweenQ = textBox2.Location.Y + 50 + (i * 50);
            //}

        }

        private void panel0_Enter(object sender, EventArgs e)
        {
            timer1.Enabled = true;

            Panel questionPanel = sender as Panel;
            panelN = questionPanel.Name;

            int countQ = 0;
            var panel = flowLayoutPanel1.Controls[panelN];

            foreach (Control h in panel.Controls)
            {
                if (h.GetType() == typeof(RadioButton))
                {
                    countQ++;
                }
            }

            for (int i = 0; i < countQ; i++)
            {
                spaceBetweenQ = textBox2.Location.Y + 50 + (i * 50);
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show($"So you want the name of the test to be:\n\"{textBox3.Text}\"", "Test name", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                textBox3.Visible = false;
                label5.Visible = false;
                label1.Text = textBox3.Text;
            }
            else
            {
                return;
            }
        }

        private void addTest_Click(object sender, EventArgs e)
        {
            string k = "";
            int num = 0;
            List<string> questions = new List<string>();
            List<string> pAnswers = new List<string>();
            List<string> allAnswers = new List<string>();

            The_Test tca = new The_Test();
            tca.Test_name = label1.Text;
            tca.Name_of_PU = selectedItem;
            string k2 = "";
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

            for (int i = 0; i < answers.Count; i++)
            {
                if (i + 1 == answers.Count)
                {
                    k2 += answers[i] + ";";
                }
                else
                {
                    k2 += answers[i] + ", ";
                }
            }
            MessageBox.Show(k2);

            tca.Correct_answers = k2;
            db.The_Test.Add(tca);
            try
            {
                db.SaveChanges();
                MessageBox.Show("correct answers added");
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

            foreach (Control p in flowLayoutPanel1.Controls)
            {
                if(p is Panel && p.Visible)
                {
                    foreach (Control c in p.Controls)
                    {
                        if (c is TextBox && c.Visible)
                        {
                            if (c.Name == "questionField")
                            {
                                questions.Add(c.Text);
                            }
                            if (c.Name != "questionField")
                            {
                                pAnswers.Add(c.Text);
                            }
                        }
                    }
                    for (int i = 0; i < pAnswers.Count; i++)
                    {
                        if (i + 1 == pAnswers.Count)
                        {
                            k += pAnswers[i] + ";";
                        }
                        else
                        {
                            k += pAnswers[i] + ", ";
                        }
                    }
                    allAnswers.Add(k);
                    k = "";
                    pAnswers.Clear();
                }
               
            }


            Questions test = new Questions();
            foreach (var a in questions)
            {
                //test.Name_of_PU = selectedItem;
                test.Test_name = label1.Text;
                test.Question = questions[num];
                test.Answers = allAnswers[num];
                db.Questions.Add(test);
                try
                {
                    db.SaveChanges();
                    MessageBox.Show("added");
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
                num++;
            }

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            TextBox t = sender as TextBox;
            string s = "";
            foreach (Control c in pp.Controls)
            {
                if (c is TextBox)
                {
                    s = c.Text;
                }
                if (c is RadioButton)
                {
                    c.Text = s;
                }
            }

        }

        private void panelQ_Click(object sender, EventArgs e)
        {
            //Panel questionPanel = sender as Panel;
            //panelPossibleAnswerName = questionPanel.Name;
            ////var panel = panelN.Controls[pane];
            //foreach(Control c in panel.Controls)
            //{
            //    if (c is Panel && c.Name != "panel4")
            //    {
            //        ((Panel)c).BorderStyle = BorderStyle.None;
            //    }
            //}
            //questionPanel.BorderStyle = BorderStyle.Fixed3D;
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            string s = "";
            List<string> list = new List<string>();
            var panel = flowLayoutPanel1.Controls[panelN];
            foreach (Control c in panel.Controls)
            {
                if (c is Panel)
                {
                    foreach (Control c2 in c.Controls)
                    {
                        if (c2 is TextBox)
                        {
                            s = c2.Text;
                        }
                        if (c2 is ComboBox)
                        {
                            string[] textBoxText = list.ToArray();
                            ((ComboBox)c2).Items.Add(s);
                        }
                    }
                }
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            pp = flowLayoutPanel1.Controls[panelN];
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

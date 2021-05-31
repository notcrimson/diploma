using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace курсач
{
    public partial class VocabularyForm : basicForm
    {
        public VocabularyForm()
        {
            InitializeComponent();
        }

        private void VocabularyForm_Load(object sender, EventArgs e)
        {

            Form3 Mmenu = new Form3();
            _prevForm = Mmenu;

            List<string> puNames = db.Vocabulary.Select(x => x.PU_Name).Distinct().ToList();
            List<Vocabulary> vocabulary = db.Vocabulary.ToList();
            foreach (var pu in puNames)
            {
                GroupBox puGroup = new GroupBox();
                puGroup.Name = pu;
                puGroup.Text = pu;
                puGroup.ForeColor = Color.DarkGreen;
                puGroup.AutoSize = true;

                Button hideBtn = new Button();
                hideBtn.Text = "–";
                hideBtn.Font = new Font("Century Gothic", 24, FontStyle.Bold, GraphicsUnit.World);
                hideBtn.TextAlign = ContentAlignment.TopCenter;
                hideBtn.Size = new Size(35, 35);
                hideBtn.Click += HideBtn_Click;
                hideBtn.Location = new Point(840, 0);
                hideBtn.UseVisualStyleBackColor = true;
                puGroup.Controls.Add(hideBtn);

                int y = 50;
                foreach (var word in vocabulary)
                {
                    if (word.PU_Name == pu)
                    {
                        VocabularyControl vocabularyControl = new VocabularyControl();
                        vocabularyControl.Word = word.Word;
                        vocabularyControl.Definition = word.Definition;
                        vocabularyControl.word = word;
                        vocabularyControl.Location = new Point(10, y);

                        foreach (Control c in vocabularyControl.Controls)
                        {
                            if (c is AxWMPLib.AxWindowsMediaPlayer)
                                ((AxWMPLib.AxWindowsMediaPlayer)c).PlayStateChange += VocabularyForm_PlayStateChange;
                        }
                        y += 130;
                        puGroup.Controls.Add(vocabularyControl);
                    }
                }
                vocabularyLayoutPanel.Controls.Add(puGroup);
            }
            vocabulary.Clear(); //clearing memory
            puNames.Clear(); //clearing memory
        }

        private void HideBtn_Click(object sender, EventArgs e)
        {
            Button hideBtn = sender as Button;

            if (hideBtn.Text == "–")
            {
                foreach (Control c in hideBtn.Parent.Controls)
                {
                    if (c is Button)
                    {
                        continue;
                    }
                    else
                    {
                        c.Hide();
                    }
                }
                hideBtn.Text = "+";
            }
            else if (hideBtn.Text == "+")
            {
                foreach (Control c in hideBtn.Parent.Controls)
                {
                    if (c is Button)
                    {
                        continue;
                    }
                    else
                    {
                        c.Show();
                    }
                }
                hideBtn.Text = "–";
            }
        }

        private void VocabularyForm_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if ((WMPLib.WMPPlayState)e.newState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                this.Enabled = false;
            }
            if ((WMPLib.WMPPlayState)e.newState == WMPLib.WMPPlayState.wmppsMediaEnded)
            {
                this.Enabled = true;
            }
        }
    }
}

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
    public partial class VocabularyControl : UserControl
    {
        public Control vocabcont { get; set; }
        public VocabularyControl()
        {
            InitializeComponent();
        }
        public string Word
        {
            get { return wordTextbox.Text; }
            set { wordTextbox.Text = value; }
        }
        public string Definition
        {
            get { return definitionTextbox.Text; }
            set { definitionTextbox.Text = value; }
        }
        public string Pronunciation
        {
            get { return axWindowsMediaPlayer1.URL; }
            set { axWindowsMediaPlayer1.URL = value; }
        }
        public Vocabulary word { get; set; }
        public void PlayWord(Vocabulary word)
        {
            if ((word != null) && (word.Pronunciation != null))
            {
                //a:
                try
                {
                    File.WriteAllBytes(Environment.CurrentDirectory.ToString() + "\\PUs\\word.mp3", word.Pronunciation);
                }
                catch (Exception ex)
                {
                    //goto a;
                    MessageBox.Show(ex.InnerException.InnerException.Message);
                }
                axWindowsMediaPlayer1.URL = Environment.CurrentDirectory.ToString() + "\\PUs\\word.mp3";
            }
        }
        private void playButton_Click(object sender, EventArgs e)
        {
            Control btn = sender as Control;
            if (btn.Parent == vocabcont)
                axWindowsMediaPlayer1.Ctlcontrols.play();
            else
                PlayWord(word);
        }

        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if ((WMPLib.WMPPlayState)e.newState == WMPLib.WMPPlayState.wmppsMediaEnded)
            {
                axWindowsMediaPlayer1.close();
            }
        }

        private void VocabularyControl_Enter(object sender, EventArgs e)
        {
            vocabcont = sender as Control;
            PlayWord(word);
        }

        private void Control_MouseHover(object sender, EventArgs e)
        {
                BorderStyle = BorderStyle.Fixed3D;
        }

        private void Control_MouseLeave(object sender, EventArgs e)
        {
            BorderStyle = BorderStyle.None;
        }
    }
}

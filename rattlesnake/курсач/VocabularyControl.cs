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
        public static bool playing;
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
        //public byte[] pronuns { get; set; }
        public void PlayWord(Vocabulary word)
        {
            //axWindowsMediaPlayer1.URL = null;
            if ((word != null) && (word.Pronunciation != null) /*&& !playing*/)
            {
                //File.Delete("C:\\song.mp3");
                /* a:*/
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
            PlayWord(word);
            //playing = true;
            axWindowsMediaPlayer1.Ctlcontrols.play();
            
        }

        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState != 3)
            {
                //playing = true;
            }
            if ((WMPLib.WMPPlayState)e.newState == WMPLib.WMPPlayState.wmppsMediaEnded)
            {
                //playing = false;
                axWindowsMediaPlayer1.close();
            }
        }
    }
}

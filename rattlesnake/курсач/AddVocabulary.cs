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
    public partial class AddVocabulary : basicForm
    {
        byte[] audio;
        List<string> puList = new List<string>();
        public AddVocabulary()
        {
            InitializeComponent();
        }

        private void AddVocabulary_Load(object sender, EventArgs e)
        {
            adminMenu admenu = new adminMenu();
            _prevForm = admenu;
            var puQuery = from pus in db.Professional_units
                          select pus.Name_of_PU;
            foreach (var pu in puQuery)
            {
                puList.Add(pu);
            }
            puBindingSource.DataSource = puList;
            puComboBox.Text = "--Select professional unit--";

        }

        private void uploadFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "MP3 (*mp3)|*.mp3";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    audio = File.ReadAllBytes(ofd.FileName);
                }
            }
        }

        private void addwordButton_Click(object sender, EventArgs e)
        {
            Vocabulary newWord = new Vocabulary();
            newWord.Word = wordTextBox.Text;
            newWord.Definition = definitionTextBox.Text;
            newWord.PU_Name = puComboBox.SelectedItem.ToString();
            newWord.Pronunciation = audio;
            db.Vocabulary.Add(newWord);
            try
            {
                db.SaveChanges();
                DialogResult dr = MessageBox.Show("Word succesfully added!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dr == DialogResult.OK)
                {
                    Dispose();
                    Close();
                    previousForm.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.InnerException.Message);
            }
        }
    }
}

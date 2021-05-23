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
    public partial class VocabularyForm : basicForm
    {
        public VocabularyForm()
        {
            InitializeComponent();
        }

        private void VocabularyForm_Load(object sender, EventArgs e)
        {
            Form3 Mmenu = new Form3();
            previousForm = Mmenu;

            List<Vocabulary> vocabulary = db.Vocabulary.ToList();
            foreach (var word in vocabulary)
            {
                VocabularyControl vocabularyControl = new VocabularyControl();
                vocabularyControl.Word = word.Word;
                vocabularyControl.Definition = word.Definition;
                vocabularyControl.word = word;
                //vocabularyControl.pronuns = word.Pronunciation;
                vocabularyLayoutPanel.Controls.Add(vocabularyControl);
            }
        }
    }
}

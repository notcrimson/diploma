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
    public partial class AdminPUsChanges : basicForm
    {
        public string contentOfPuString;
        public string fileNameString;
        public string path = Environment.CurrentDirectory.ToString() + @"\PUs\";
        public AdminPUsChanges()
        {
            InitializeComponent();
        }

        private void PUPDFfile_Load(object sender, EventArgs e)
        {
            adminMenu am = new adminMenu();
            previousForm = am;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = path;
            openFileDialog1.Filter = "Word Document|*.doc; *.docx";
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                object readOnly = true;
                object visible = true;
                object fileName = openFileDialog1.FileName.ToString();
                fileNameString = System.IO.Path.GetFileNameWithoutExtension(openFileDialog1.FileName);
                //MessageBox.Show(fileNameString);
                object missing = Type.Missing;
                Microsoft.Office.Interop.Word.Document document;
                Microsoft.Office.Interop.Word.Application application = new Microsoft.Office.Interop.Word.Application() { Visible = false };
                document = application.Documents.Open(fileName, missing, readOnly, missing, missing, missing, missing, missing, missing,
                    missing, missing, visible, missing, missing, missing, missing);
                document.ActiveWindow.Selection.WholeStory();
                document.ActiveWindow.Selection.Copy();
                IDataObject dataObject = Clipboard.GetDataObject();
                richTextBox1.Rtf = dataObject.GetData(DataFormats.Rtf).ToString();
                contentOfPuString = dataObject.GetData(DataFormats.Rtf).ToString();
                application.Quit(missing, missing, missing);
            }
        }

        private void addPU_Click(object sender, EventArgs e)
        {
            if (contentOfPuString != null)
            {
                byte[] contentOfPuBytearray = Encoding.ASCII.GetBytes(contentOfPuString);

                Professional_units pu = new Professional_units();
                //MessageBox.Show(fileNameString);
                pu.Name_of_PU = fileNameString;
                pu.ContentOfPU = contentOfPuBytearray;
                db.Professional_units.Add(pu);

                try
                {
                    db.SaveChanges();
                    MessageBox.Show("Content added to database");

                }
                catch (System.Data.Entity.Validation.DbEntityValidationException ex) // make a catch for reapeating keys 
                {
                    foreach (var validationErrors in ex.EntityValidationErrors)
                    {
                        foreach (var validationError in validationErrors.ValidationErrors)
                        {
                            MessageBox.Show($"Property: {validationError.PropertyName} Error: {validationError.ErrorMessage}");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("File not selected");
            }
        }
    }
}

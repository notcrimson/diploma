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
    public partial class StudentPU : basicForm
    {
        public StudentPU()
        {
            InitializeComponent();
        }

        private void StudentPU_Load(object sender, EventArgs e)
        {
            Units un = new Units();
            _prevForm = un;

            if (selectedPU == null)
                selectedPU = Properties.Settings.Default.selectedPu;

            label1.Text = selectedPU;
            string contentString;
            Professional_units pr = db.Professional_units.Find(selectedPU);
            if (pr != null)
            {
                contentString = Encoding.ASCII.GetString(pr.ContentOfPU);
                richTextBox1.Rtf = contentString;
            }
            contentString = null;
        }
    }
}

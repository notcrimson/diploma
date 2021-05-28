﻿using System;
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
    public partial class Units : basicForm
    {
        //public Professional_unit PU {get;set;}
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
            }
            else if (USER.Role == "admin")
            {
                adminMenu adminMenu = new adminMenu();
                _prevForm = adminMenu;
            }
           

            var pus = from p in db.Professional_units
                      select new { p.Name_of_PU };
            foreach (var Pu in pus)
            {
                listBox1.Items.Add(Pu.Name_of_PU);
            }
            pus = null;
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                selectedPU = listBox1.SelectedItem.ToString();
                if(USER.Role == "student")
                {
                    panel3.Visible = true;
                }
                else if (USER.Role == "admin")
                {
                    panel5.Visible = true;
                }
            }
        }

        private void OpenPU_Click(object sender, EventArgs e)
        {
            //listBox1.Items.Clear();
            Close();
            StudentPU sPU = new StudentPU();
            sPU.Show();
            
        }       

        private void Write_a_test_Click(object sender, EventArgs e)
        {
            //listBox1.Items.Clear();
            Close();
            listOfTests test = new listOfTests();
            test.Show();
            
        }
        private void addTest_Click(object sender, EventArgs e)
        {
            //listBox1.Items.Clear();
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
    }
}

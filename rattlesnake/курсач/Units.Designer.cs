namespace курсач
{
    partial class Units
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel3 = new System.Windows.Forms.Panel();
            this.OpenPU = new System.Windows.Forms.Button();
            this.Write_a_test = new System.Windows.Forms.Button();
            this.professionalunitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.addTest = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.professionalunitBindingSource)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 9);
            this.label1.Text = "Professional units";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.OpenPU);
            this.panel3.Controls.Add(this.Write_a_test);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1008, 70);
            this.panel3.TabIndex = 0;
            this.panel3.Visible = false;
            // 
            // OpenPU
            // 
            this.OpenPU.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.OpenPU.Location = new System.Drawing.Point(26, 16);
            this.OpenPU.Name = "OpenPU";
            this.OpenPU.Size = new System.Drawing.Size(146, 34);
            this.OpenPU.TabIndex = 2;
            this.OpenPU.Text = "Open PU";
            this.OpenPU.UseVisualStyleBackColor = true;
            this.OpenPU.Click += new System.EventHandler(this.OpenPU_Click);
            // 
            // Write_a_test
            // 
            this.Write_a_test.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Write_a_test.Location = new System.Drawing.Point(847, 16);
            this.Write_a_test.Name = "Write_a_test";
            this.Write_a_test.Size = new System.Drawing.Size(149, 34);
            this.Write_a_test.TabIndex = 0;
            this.Write_a_test.Text = "Write a test";
            this.Write_a_test.UseVisualStyleBackColor = true;
            this.Write_a_test.Click += new System.EventHandler(this.Write_a_test_Click);
            // 
            // professionalunitBindingSource
            // 
            this.professionalunitBindingSource.DataSource = typeof(курсач.Professional_units);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.listBox1);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 85);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1008, 460);
            this.panel4.TabIndex = 3;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.LightGray;
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.ForeColor = System.Drawing.Color.DarkGreen;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 22;
            this.listBox1.Location = new System.Drawing.Point(0, 138);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1008, 322);
            this.listBox1.TabIndex = 2;
            this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button1);
            this.panel5.Controls.Add(this.addTest);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 70);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1008, 68);
            this.panel5.TabIndex = 1;
            this.panel5.Visible = false;
            // 
            // addTest
            // 
            this.addTest.Location = new System.Drawing.Point(847, 18);
            this.addTest.Name = "addTest";
            this.addTest.Size = new System.Drawing.Size(149, 34);
            this.addTest.TabIndex = 0;
            this.addTest.Text = "Add a Test";
            this.addTest.UseVisualStyleBackColor = true;
            this.addTest.Click += new System.EventHandler(this.addTest_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button1.Location = new System.Drawing.Point(26, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "Open PU";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Units
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 595);
            this.Controls.Add(this.panel4);
            this.Name = "Units";
            this.Text = "Units";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Units_FormClosed);
            this.Load += new System.EventHandler(this.Units_Load);
            this.Resize += new System.EventHandler(this.Units_Resize);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.professionalunitBindingSource)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Write_a_test;
        private System.Windows.Forms.Button OpenPU;
        private System.Windows.Forms.BindingSource professionalunitBindingSource;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button addTest;
        private System.Windows.Forms.Button button1;
    }
}
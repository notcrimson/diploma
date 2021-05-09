namespace курсач
{
    partial class listOfTests
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.writeTest = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.writeTest);
            this.panel2.Controls.SetChildIndex(this.BackButton, 0);
            this.panel2.Controls.SetChildIndex(this.writeTest, 0);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(979, 0);
            // 
            // fHide
            // 
            this.fHide.Location = new System.Drawing.Point(951, -2);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 9);
            this.label1.Text = "List of tests";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.LightGray;
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.ForeColor = System.Drawing.Color.DarkGreen;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 22;
            this.listBox1.Location = new System.Drawing.Point(0, 85);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1008, 460);
            this.listBox1.TabIndex = 2;
            this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // writeTest
            // 
            this.writeTest.Location = new System.Drawing.Point(863, 10);
            this.writeTest.Name = "writeTest";
            this.writeTest.Size = new System.Drawing.Size(123, 32);
            this.writeTest.TabIndex = 3;
            this.writeTest.Text = "Write test";
            this.writeTest.UseVisualStyleBackColor = true;
            this.writeTest.Visible = false;
            this.writeTest.Click += new System.EventHandler(this.writeTest_Click);
            // 
            // listOfTests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 595);
            this.Controls.Add(this.listBox1);
            this.Name = "listOfTests";
            this.Text = "listOfTests";
            this.Load += new System.EventHandler(this.listOfTests_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.listBox1, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button writeTest;
    }
}
namespace курсач
{
    partial class adminAddTests
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
            this.questionField = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.panel0 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.addAnswer = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.addQuestion = new System.Windows.Forms.Button();
            this.deleteQ = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.addTest = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel0.SuspendLayout();
            this.panel4.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.SetChildIndex(this.label1, 0);
            this.panel1.Controls.SetChildIndex(this.label5, 0);
            this.panel1.Controls.SetChildIndex(this.textBox3, 0);
            this.panel1.Controls.SetChildIndex(this.label2, 0);
            this.panel1.Controls.SetChildIndex(this.fHide, 0);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.deleteQ);
            this.panel2.Controls.Add(this.addTest);
            this.panel2.Controls.Add(this.addQuestion);
            this.panel2.Controls.SetChildIndex(this.BackButton, 0);
            this.panel2.Controls.SetChildIndex(this.addQuestion, 0);
            this.panel2.Controls.SetChildIndex(this.addTest, 0);
            this.panel2.Controls.SetChildIndex(this.deleteQ, 0);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(89, 11);
            this.label1.Size = new System.Drawing.Size(856, 24);
            // 
            // questionField
            // 
            this.questionField.Location = new System.Drawing.Point(204, 28);
            this.questionField.Name = "questionField";
            this.questionField.Size = new System.Drawing.Size(612, 31);
            this.questionField.TabIndex = 0;
            this.questionField.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(205, 72);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(549, 31);
            this.textBox2.TabIndex = 1;
            this.textBox2.Visible = false;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox2.Enter += new System.EventHandler(this.textBox2_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "Question field";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(186, 76);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(147, 26);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // panel0
            // 
            this.panel0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel0.Controls.Add(this.textBox2);
            this.panel0.Controls.Add(this.questionField);
            this.panel0.Controls.Add(this.label3);
            this.panel0.Controls.Add(this.panel4);
            this.panel0.Controls.Add(this.radioButton1);
            this.panel0.Location = new System.Drawing.Point(3, 3);
            this.panel0.Name = "panel0";
            this.panel0.Size = new System.Drawing.Size(983, 196);
            this.panel0.TabIndex = 6;
            this.panel0.Visible = false;
            this.panel0.Enter += new System.EventHandler(this.panel0_Enter);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.addAnswer);
            this.panel4.Controls.Add(this.button2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 143);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(979, 49);
            this.panel4.TabIndex = 11;
            this.panel4.Click += new System.EventHandler(this.panel4_Click);
            // 
            // addAnswer
            // 
            this.addAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(227)))));
            this.addAnswer.Location = new System.Drawing.Point(497, 9);
            this.addAnswer.Name = "addAnswer";
            this.addAnswer.Size = new System.Drawing.Size(138, 32);
            this.addAnswer.TabIndex = 0;
            this.addAnswer.Text = "Add Answer";
            this.addAnswer.UseVisualStyleBackColor = false;
            this.addAnswer.Click += new System.EventHandler(this.addAnswer_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(227)))));
            this.button2.Location = new System.Drawing.Point(641, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(205, 32);
            this.button2.TabIndex = 1;
            this.button2.Text = "Remove an Answer";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.deletePossibleAnswer);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.panel0);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 85);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1008, 460);
            this.flowLayoutPanel1.TabIndex = 7;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // addQuestion
            // 
            this.addQuestion.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.addQuestion.Location = new System.Drawing.Point(274, 10);
            this.addQuestion.Name = "addQuestion";
            this.addQuestion.Size = new System.Drawing.Size(222, 32);
            this.addQuestion.TabIndex = 0;
            this.addQuestion.Text = "Add another question";
            this.addQuestion.UseVisualStyleBackColor = true;
            this.addQuestion.Click += new System.EventHandler(this.addQuestion_Click);
            // 
            // deleteQ
            // 
            this.deleteQ.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.deleteQ.Location = new System.Drawing.Point(502, 10);
            this.deleteQ.Name = "deleteQ";
            this.deleteQ.Size = new System.Drawing.Size(197, 32);
            this.deleteQ.TabIndex = 1;
            this.deleteQ.Text = "Remove a question";
            this.deleteQ.UseVisualStyleBackColor = true;
            this.deleteQ.Click += new System.EventHandler(this.deleteQ_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // addTest
            // 
            this.addTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addTest.Location = new System.Drawing.Point(888, 10);
            this.addTest.Name = "addTest";
            this.addTest.Size = new System.Drawing.Size(98, 32);
            this.addTest.TabIndex = 7;
            this.addTest.Text = "Add Test";
            this.addTest.UseVisualStyleBackColor = true;
            this.addTest.Click += new System.EventHandler(this.addTest_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(270, 10);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(663, 31);
            this.textBox3.TabIndex = 3;
            this.textBox3.Leave += new System.EventHandler(this.textBox3_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FloralWhite;
            this.label5.Location = new System.Drawing.Point(101, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 22);
            this.label5.TabIndex = 7;
            this.label5.Text = "Set name of test:";
            // 
            // adminAddTests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 595);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "adminAddTests";
            this.Text = "adminAddTests";
            this.Load += new System.EventHandler(this.adminAddTests_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.flowLayoutPanel1, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel0.ResumeLayout(false);
            this.panel0.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox questionField;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Panel panel0;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button deleteQ;
        private System.Windows.Forms.Button addQuestion;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button addAnswer;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button addTest;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
    }
}
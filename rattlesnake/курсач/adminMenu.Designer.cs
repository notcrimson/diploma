namespace курсач
{
    partial class adminMenu
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
            this.addPu = new System.Windows.Forms.Button();
            this.addTest = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.addVocabulary = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Text = "Admin\'s Menu";
            // 
            // BackButton
            // 
            this.BackButton.Visible = false;
            // 
            // addPu
            // 
            this.addPu.Location = new System.Drawing.Point(242, 218);
            this.addPu.Name = "addPu";
            this.addPu.Size = new System.Drawing.Size(219, 101);
            this.addPu.TabIndex = 2;
            this.addPu.Text = "Add a Professional Unit";
            this.addPu.UseVisualStyleBackColor = true;
            this.addPu.Click += new System.EventHandler(this.addPu_Click);
            // 
            // addTest
            // 
            this.addTest.Location = new System.Drawing.Point(521, 218);
            this.addTest.Name = "addTest";
            this.addTest.Size = new System.Drawing.Size(219, 101);
            this.addTest.TabIndex = 2;
            this.addTest.Text = "Add a Test";
            this.addTest.UseVisualStyleBackColor = true;
            this.addTest.Click += new System.EventHandler(this.addTest_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Location = new System.Drawing.Point(0, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1008, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Welcome back __";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addVocabulary
            // 
            this.addVocabulary.Location = new System.Drawing.Point(242, 345);
            this.addVocabulary.Name = "addVocabulary";
            this.addVocabulary.Size = new System.Drawing.Size(219, 101);
            this.addVocabulary.TabIndex = 6;
            this.addVocabulary.Text = "Add to the vocabulary";
            this.addVocabulary.UseVisualStyleBackColor = true;
            this.addVocabulary.Click += new System.EventHandler(this.addVocabulary_Click);
            // 
            // adminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 595);
            this.Controls.Add(this.addVocabulary);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addTest);
            this.Controls.Add(this.addPu);
            this.Name = "adminMenu";
            this.Text = "adminMenu";
            this.Load += new System.EventHandler(this.adminMenu_Load);
            this.Controls.SetChildIndex(this.addPu, 0);
            this.Controls.SetChildIndex(this.addTest, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.addVocabulary, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button addPu;
        private System.Windows.Forms.Button addTest;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addVocabulary;
    }
}
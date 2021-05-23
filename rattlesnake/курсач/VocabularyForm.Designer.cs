
namespace курсач
{
    partial class VocabularyForm
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
            this.vocabularyLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Text = "Vocabulary";
            // 
            // vocabularyLayoutPanel
            // 
            this.vocabularyLayoutPanel.AutoScroll = true;
            this.vocabularyLayoutPanel.Location = new System.Drawing.Point(56, 122);
            this.vocabularyLayoutPanel.Name = "vocabularyLayoutPanel";
            this.vocabularyLayoutPanel.Size = new System.Drawing.Size(895, 351);
            this.vocabularyLayoutPanel.TabIndex = 2;
            // 
            // VocabularyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 595);
            this.Controls.Add(this.vocabularyLayoutPanel);
            this.Name = "VocabularyForm";
            this.Text = "VocabularyForm";
            this.Load += new System.EventHandler(this.VocabularyForm_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.vocabularyLayoutPanel, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel vocabularyLayoutPanel;
    }
}
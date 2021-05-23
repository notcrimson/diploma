
namespace курсач
{
    partial class AddVocabulary
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
            this.wordTextBox = new System.Windows.Forms.TextBox();
            this.wordLabel = new System.Windows.Forms.Label();
            this.defenitionLabel = new System.Windows.Forms.Label();
            this.uploadFile = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.puLabel = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.addwordButton = new System.Windows.Forms.Button();
            this.puComboBox = new System.Windows.Forms.ComboBox();
            this.puBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.definitionTextBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.puBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.addwordButton);
            this.panel2.Controls.SetChildIndex(this.BackButton, 0);
            this.panel2.Controls.SetChildIndex(this.addwordButton, 0);
            // 
            // label1
            // 
            this.label1.Text = "Add new words";
            // 
            // wordTextBox
            // 
            this.wordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.wordTextBox.Location = new System.Drawing.Point(337, 197);
            this.wordTextBox.Name = "wordTextBox";
            this.wordTextBox.Size = new System.Drawing.Size(371, 31);
            this.wordTextBox.TabIndex = 2;
            // 
            // wordLabel
            // 
            this.wordLabel.AutoSize = true;
            this.wordLabel.Location = new System.Drawing.Point(210, 197);
            this.wordLabel.Name = "wordLabel";
            this.wordLabel.Size = new System.Drawing.Size(63, 22);
            this.wordLabel.TabIndex = 4;
            this.wordLabel.Text = "Word:";
            // 
            // defenitionLabel
            // 
            this.defenitionLabel.AutoSize = true;
            this.defenitionLabel.Location = new System.Drawing.Point(210, 240);
            this.defenitionLabel.Name = "defenitionLabel";
            this.defenitionLabel.Size = new System.Drawing.Size(99, 22);
            this.defenitionLabel.TabIndex = 4;
            this.defenitionLabel.Text = "Definition:";
            // 
            // uploadFile
            // 
            this.uploadFile.Location = new System.Drawing.Point(396, 367);
            this.uploadFile.Name = "uploadFile";
            this.uploadFile.Size = new System.Drawing.Size(255, 32);
            this.uploadFile.TabIndex = 5;
            this.uploadFile.Text = "Add the pronunciation";
            this.uploadFile.UseVisualStyleBackColor = true;
            this.uploadFile.Click += new System.EventHandler(this.uploadFile_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(468, 415);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "*.mp3 files";
            // 
            // puLabel
            // 
            this.puLabel.AutoSize = true;
            this.puLabel.Location = new System.Drawing.Point(208, 155);
            this.puLabel.Name = "puLabel";
            this.puLabel.Size = new System.Drawing.Size(126, 22);
            this.puLabel.TabIndex = 7;
            this.puLabel.Text = "Add section:";
            // 
            // addwordButton
            // 
            this.addwordButton.Location = new System.Drawing.Point(777, 10);
            this.addwordButton.Name = "addwordButton";
            this.addwordButton.Size = new System.Drawing.Size(205, 32);
            this.addwordButton.TabIndex = 9;
            this.addwordButton.Text = "Add to vocabulary";
            this.addwordButton.UseVisualStyleBackColor = true;
            this.addwordButton.Click += new System.EventHandler(this.addwordButton_Click);
            // 
            // puComboBox
            // 
            this.puComboBox.DataSource = this.puBindingSource;
            this.puComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.puComboBox.FormattingEnabled = true;
            this.puComboBox.Location = new System.Drawing.Point(337, 152);
            this.puComboBox.Name = "puComboBox";
            this.puComboBox.Size = new System.Drawing.Size(371, 30);
            this.puComboBox.TabIndex = 9;
            // 
            // definitionTextBox
            // 
            this.definitionTextBox.Location = new System.Drawing.Point(337, 237);
            this.definitionTextBox.Multiline = true;
            this.definitionTextBox.Name = "definitionTextBox";
            this.definitionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.definitionTextBox.Size = new System.Drawing.Size(370, 102);
            this.definitionTextBox.TabIndex = 10;
            // 
            // AddVocabulary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 595);
            this.Controls.Add(this.definitionTextBox);
            this.Controls.Add(this.puComboBox);
            this.Controls.Add(this.puLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.uploadFile);
            this.Controls.Add(this.defenitionLabel);
            this.Controls.Add(this.wordLabel);
            this.Controls.Add(this.wordTextBox);
            this.Name = "AddVocabulary";
            this.Text = "AddVocabulary";
            this.Load += new System.EventHandler(this.AddVocabulary_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.wordTextBox, 0);
            this.Controls.SetChildIndex(this.wordLabel, 0);
            this.Controls.SetChildIndex(this.defenitionLabel, 0);
            this.Controls.SetChildIndex(this.uploadFile, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.puLabel, 0);
            this.Controls.SetChildIndex(this.puComboBox, 0);
            this.Controls.SetChildIndex(this.definitionTextBox, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.puBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox wordTextBox;
        private System.Windows.Forms.Label wordLabel;
        private System.Windows.Forms.Label defenitionLabel;
        private System.Windows.Forms.Button uploadFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label puLabel;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button addwordButton;
        private System.Windows.Forms.ComboBox puComboBox;
        private System.Windows.Forms.BindingSource puBindingSource;
        private System.Windows.Forms.TextBox definitionTextBox;
    }
}
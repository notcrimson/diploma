namespace курсач
{
    partial class Profile
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
            SelectedPU = null;
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
            this.resultLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.sortingPanel = new System.Windows.Forms.Panel();
            this.filterGroupBox = new System.Windows.Forms.GroupBox();
            this.percentageRadioButton = new System.Windows.Forms.RadioButton();
            this.dateRadioButton = new System.Windows.Forms.RadioButton();
            this.PUsortComboBox = new System.Windows.Forms.ComboBox();
            this.the_TestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PUfilterLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.resultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.sortingPanel.SuspendLayout();
            this.filterGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.the_TestBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Text = "Your profile";
            // 
            // resultLayoutPanel
            // 
            this.resultLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultLayoutPanel.AutoScroll = true;
            this.resultLayoutPanel.Location = new System.Drawing.Point(255, 207);
            this.resultLayoutPanel.Name = "resultLayoutPanel";
            this.resultLayoutPanel.Size = new System.Drawing.Size(753, 338);
            this.resultLayoutPanel.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 85);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(249, 460);
            this.panel3.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(65, 408);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Edit profile";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(4, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(242, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "label3";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::курсач.Properties.Resources.profile_pic;
            this.pictureBox2.Location = new System.Drawing.Point(45, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(161, 164);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // sortingPanel
            // 
            this.sortingPanel.Controls.Add(this.label4);
            this.sortingPanel.Controls.Add(this.filterGroupBox);
            this.sortingPanel.Controls.Add(this.PUsortComboBox);
            this.sortingPanel.Controls.Add(this.PUfilterLabel);
            this.sortingPanel.Controls.Add(this.comboBox1);
            this.sortingPanel.Location = new System.Drawing.Point(255, 85);
            this.sortingPanel.Name = "sortingPanel";
            this.sortingPanel.Size = new System.Drawing.Size(753, 123);
            this.sortingPanel.TabIndex = 5;
            // 
            // filterGroupBox
            // 
            this.filterGroupBox.Controls.Add(this.percentageRadioButton);
            this.filterGroupBox.Controls.Add(this.dateRadioButton);
            this.filterGroupBox.ForeColor = System.Drawing.Color.DarkGreen;
            this.filterGroupBox.Location = new System.Drawing.Point(411, 11);
            this.filterGroupBox.Name = "filterGroupBox";
            this.filterGroupBox.Size = new System.Drawing.Size(206, 109);
            this.filterGroupBox.TabIndex = 3;
            this.filterGroupBox.TabStop = false;
            this.filterGroupBox.Text = "Filter by:";
            // 
            // percentageRadioButton
            // 
            this.percentageRadioButton.AutoSize = true;
            this.percentageRadioButton.Location = new System.Drawing.Point(19, 62);
            this.percentageRadioButton.Name = "percentageRadioButton";
            this.percentageRadioButton.Size = new System.Drawing.Size(140, 26);
            this.percentageRadioButton.TabIndex = 1;
            this.percentageRadioButton.Text = "percentage";
            this.percentageRadioButton.UseVisualStyleBackColor = true;
            this.percentageRadioButton.CheckedChanged += new System.EventHandler(this.filter_Changed);
            // 
            // dateRadioButton
            // 
            this.dateRadioButton.AutoSize = true;
            this.dateRadioButton.Checked = true;
            this.dateRadioButton.Location = new System.Drawing.Point(19, 30);
            this.dateRadioButton.Name = "dateRadioButton";
            this.dateRadioButton.Size = new System.Drawing.Size(73, 26);
            this.dateRadioButton.TabIndex = 0;
            this.dateRadioButton.TabStop = true;
            this.dateRadioButton.Text = "date";
            this.dateRadioButton.UseVisualStyleBackColor = true;
            this.dateRadioButton.CheckedChanged += new System.EventHandler(this.filter_Changed);
            // 
            // PUsortComboBox
            // 
            this.PUsortComboBox.DataSource = this.the_TestBindingSource;
            this.PUsortComboBox.DisplayMember = "Name_of_PU";
            this.PUsortComboBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PUsortComboBox.FormattingEnabled = true;
            this.PUsortComboBox.Location = new System.Drawing.Point(114, 11);
            this.PUsortComboBox.Name = "PUsortComboBox";
            this.PUsortComboBox.Size = new System.Drawing.Size(275, 29);
            this.PUsortComboBox.TabIndex = 2;
            this.PUsortComboBox.ValueMember = "Name_of_PU";
            this.PUsortComboBox.SelectedIndexChanged += new System.EventHandler(this.PUsortComboBox_SelectedIndexChanged);
            // 
            // the_TestBindingSource
            // 
            this.the_TestBindingSource.DataSource = typeof(курсач.The_Test);
            // 
            // PUfilterLabel
            // 
            this.PUfilterLabel.AutoSize = true;
            this.PUfilterLabel.Location = new System.Drawing.Point(2, 14);
            this.PUfilterLabel.Name = "PUfilterLabel";
            this.PUfilterLabel.Size = new System.Drawing.Size(106, 22);
            this.PUfilterLabel.TabIndex = 1;
            this.PUfilterLabel.Text = "Sort by PU:";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.resultBindingSource;
            this.comboBox1.DisplayMember = "Test_name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(663, 10);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(90, 30);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "Test_name";
            this.comboBox1.Visible = false;
            // 
            // resultBindingSource
            // 
            this.resultBindingSource.DataSource = typeof(курсач.Result);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Your test results:";
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 595);
            this.Controls.Add(this.sortingPanel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.resultLayoutPanel);
            this.Name = "Profile";
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.Profile_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.resultLayoutPanel, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.sortingPanel, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.sortingPanel.ResumeLayout(false);
            this.sortingPanel.PerformLayout();
            this.filterGroupBox.ResumeLayout(false);
            this.filterGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.the_TestBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel resultLayoutPanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel sortingPanel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label PUfilterLabel;
        private System.Windows.Forms.BindingSource resultBindingSource;
        private System.Windows.Forms.ComboBox PUsortComboBox;
        private System.Windows.Forms.BindingSource the_TestBindingSource;
        private System.Windows.Forms.GroupBox filterGroupBox;
        private System.Windows.Forms.RadioButton percentageRadioButton;
        private System.Windows.Forms.RadioButton dateRadioButton;
        private System.Windows.Forms.Label label4;
    }
}
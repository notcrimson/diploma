
namespace курсач
{
    partial class VocabularyControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VocabularyControl));
            this.wordTextbox = new System.Windows.Forms.Label();
            this.definitionTextbox = new System.Windows.Forms.Label();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.playButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // wordTextbox
            // 
            this.wordTextbox.AutoSize = true;
            this.wordTextbox.Location = new System.Drawing.Point(22, 47);
            this.wordTextbox.Name = "wordTextbox";
            this.wordTextbox.Size = new System.Drawing.Size(58, 22);
            this.wordTextbox.TabIndex = 0;
            this.wordTextbox.Text = "Word";
            // 
            // definitionTextbox
            // 
            this.definitionTextbox.Location = new System.Drawing.Point(154, 9);
            this.definitionTextbox.Name = "definitionTextbox";
            this.definitionTextbox.Size = new System.Drawing.Size(571, 98);
            this.definitionTextbox.TabIndex = 1;
            this.definitionTextbox.Text = "Definition";
            this.definitionTextbox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(826, 85);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(37, 35);
            this.axWindowsMediaPlayer1.TabIndex = 2;
            this.axWindowsMediaPlayer1.Visible = false;
            this.axWindowsMediaPlayer1.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.axWindowsMediaPlayer1_PlayStateChange);
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(750, 48);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(89, 31);
            this.playButton.TabIndex = 3;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // VocabularyControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.definitionTextbox);
            this.Controls.Add(this.wordTextbox);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.ForeColor = System.Drawing.Color.DarkGreen;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "VocabularyControl";
            this.Size = new System.Drawing.Size(864, 118);
            this.Enter += new System.EventHandler(this.VocabularyControl_Enter);
            this.MouseLeave += new System.EventHandler(this.Control_MouseLeave);
            this.MouseHover += new System.EventHandler(this.Control_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label wordTextbox;
        private System.Windows.Forms.Label definitionTextbox;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button playButton;
    }
}

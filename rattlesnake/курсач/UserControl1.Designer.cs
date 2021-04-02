
namespace курсач
{
    partial class UserControl1
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
            this.percentage = new System.Windows.Forms.Label();
            this.testName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // percentage
            // 
            this.percentage.AutoSize = true;
            this.percentage.Location = new System.Drawing.Point(645, 22);
            this.percentage.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.percentage.Name = "percentage";
            this.percentage.Size = new System.Drawing.Size(120, 22);
            this.percentage.TabIndex = 0;
            this.percentage.Text = "Precentage";
            this.percentage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // testName
            // 
            this.testName.AutoSize = true;
            this.testName.Location = new System.Drawing.Point(12, 22);
            this.testName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.testName.Name = "testName";
            this.testName.Size = new System.Drawing.Size(103, 22);
            this.testName.TabIndex = 1;
            this.testName.Text = "Test name";
            this.testName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.testName);
            this.Controls.Add(this.percentage);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(721, 67);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label percentage;
        private System.Windows.Forms.Label testName;
    }
}

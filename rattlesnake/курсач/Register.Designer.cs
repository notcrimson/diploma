namespace курсач
{
    partial class Register
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
            System.Windows.Forms.Timer timer1;
            this.Namef = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Namee = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.ConfirmPassword = new System.Windows.Forms.TextBox();
            this.uploadPic = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.nameError = new System.Windows.Forms.Label();
            this.usernameError = new System.Windows.Forms.Label();
            this.confirmpassError = new System.Windows.Forms.Label();
            this.passError = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.SetChildIndex(this.BackButton, 0);
            this.panel2.Controls.SetChildIndex(this.button1, 0);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 9);
            this.label1.Text = "Registration";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Namef
            // 
            this.Namef.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Namef.AutoSize = true;
            this.Namef.Location = new System.Drawing.Point(412, 83);
            this.Namef.Name = "Namef";
            this.Namef.Size = new System.Drawing.Size(66, 22);
            this.Namef.TabIndex = 3;
            this.Namef.Text = "Name";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(412, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Username";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(412, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 22);
            this.label5.TabIndex = 3;
            this.label5.Text = "Password";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.Location = new System.Drawing.Point(412, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 53);
            this.label6.TabIndex = 3;
            this.label6.Text = "Confirm password";
            // 
            // Namee
            // 
            this.Namee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Namee.Location = new System.Drawing.Point(522, 83);
            this.Namee.Name = "Namee";
            this.Namee.Size = new System.Drawing.Size(274, 31);
            this.Namee.TabIndex = 4;
            this.Namee.TextChanged += new System.EventHandler(this.Namee_TextChanged);
            this.Namee.Leave += new System.EventHandler(this.Namee_Leave);
            // 
            // Username
            // 
            this.Username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Username.Location = new System.Drawing.Point(522, 123);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(274, 31);
            this.Username.TabIndex = 5;
            this.Username.TextChanged += new System.EventHandler(this.Username_TextChanged);
            this.Username.Leave += new System.EventHandler(this.Username_Leave);
            // 
            // Password
            // 
            this.Password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Password.Location = new System.Drawing.Point(522, 165);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(277, 31);
            this.Password.TabIndex = 6;
            this.Password.TextChanged += new System.EventHandler(this.Password_TextChanged);
            this.Password.Leave += new System.EventHandler(this.Password_Leave);
            // 
            // ConfirmPassword
            // 
            this.ConfirmPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ConfirmPassword.Location = new System.Drawing.Point(522, 208);
            this.ConfirmPassword.Name = "ConfirmPassword";
            this.ConfirmPassword.Size = new System.Drawing.Size(277, 31);
            this.ConfirmPassword.TabIndex = 7;
            this.ConfirmPassword.TextChanged += new System.EventHandler(this.ConfirmPassword_TextChanged);
            this.ConfirmPassword.Leave += new System.EventHandler(this.ConfirmPassword_Leave);
            // 
            // uploadPic
            // 
            this.uploadPic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uploadPic.Location = new System.Drawing.Point(129, 224);
            this.uploadPic.Name = "uploadPic";
            this.uploadPic.Size = new System.Drawing.Size(130, 33);
            this.uploadPic.TabIndex = 8;
            this.uploadPic.Text = "upload photo";
            this.uploadPic.UseVisualStyleBackColor = true;
            this.uploadPic.Click += new System.EventHandler(this.uploadPic_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::курсач.Properties.Resources.profile_pic;
            this.pictureBox1.Location = new System.Drawing.Point(107, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 164);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(895, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.nameError);
            this.panel3.Controls.Add(this.usernameError);
            this.panel3.Controls.Add(this.confirmpassError);
            this.panel3.Controls.Add(this.passError);
            this.panel3.Controls.Add(this.Namee);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.Namef);
            this.panel3.Controls.Add(this.uploadPic);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.ConfirmPassword);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.Password);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.Username);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 85);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1008, 460);
            this.panel3.TabIndex = 9;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // nameError
            // 
            this.nameError.AutoSize = true;
            this.nameError.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameError.ForeColor = System.Drawing.Color.Red;
            this.nameError.Location = new System.Drawing.Point(840, 89);
            this.nameError.Name = "nameError";
            this.nameError.Size = new System.Drawing.Size(18, 25);
            this.nameError.TabIndex = 9;
            this.nameError.Text = "!";
            this.nameError.Visible = false;
            this.nameError.MouseHover += new System.EventHandler(this.nameError_MouseHover);
            // 
            // usernameError
            // 
            this.usernameError.AutoSize = true;
            this.usernameError.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usernameError.ForeColor = System.Drawing.Color.Red;
            this.usernameError.Location = new System.Drawing.Point(840, 129);
            this.usernameError.Name = "usernameError";
            this.usernameError.Size = new System.Drawing.Size(18, 25);
            this.usernameError.TabIndex = 9;
            this.usernameError.Text = "!";
            this.usernameError.Visible = false;
            this.usernameError.MouseHover += new System.EventHandler(this.usernameError_MouseHover);
            // 
            // confirmpassError
            // 
            this.confirmpassError.AutoSize = true;
            this.confirmpassError.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.confirmpassError.ForeColor = System.Drawing.Color.Red;
            this.confirmpassError.Location = new System.Drawing.Point(840, 214);
            this.confirmpassError.Name = "confirmpassError";
            this.confirmpassError.Size = new System.Drawing.Size(18, 25);
            this.confirmpassError.TabIndex = 9;
            this.confirmpassError.Text = "!";
            this.confirmpassError.Visible = false;
            this.confirmpassError.MouseHover += new System.EventHandler(this.confirmpassError_MouseHover);
            // 
            // passError
            // 
            this.passError.AutoSize = true;
            this.passError.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passError.ForeColor = System.Drawing.Color.Red;
            this.passError.Location = new System.Drawing.Point(840, 171);
            this.passError.Name = "passError";
            this.passError.Size = new System.Drawing.Size(18, 25);
            this.passError.TabIndex = 9;
            this.passError.Text = "!";
            this.passError.Visible = false;
            this.passError.MouseHover += new System.EventHandler(this.passError_MouseHover);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Error;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 595);
            this.Controls.Add(this.panel3);
            this.Name = "Register";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Namef;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Namee;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox ConfirmPassword;
        private System.Windows.Forms.Button uploadPic;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label nameError;
        private System.Windows.Forms.Label usernameError;
        private System.Windows.Forms.Label confirmpassError;
        private System.Windows.Forms.Label passError;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
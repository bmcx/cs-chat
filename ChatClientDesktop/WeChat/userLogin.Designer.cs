namespace WeChat
{
    partial class userLogin
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
            this.btnSignup = new LollipopButton();
            this.btnSignIn = new LollipopButton();
            this.lollipopTextBox1 = new LollipopTextBox();
            this.lollipopLabel1 = new LollipopLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lollipopTextBox2 = new LollipopTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSignup
            // 
            this.btnSignup.BackColor = System.Drawing.Color.Transparent;
            this.btnSignup.BGColor = "#508ef5";
            this.btnSignup.FontColor = "#ffffff";
            this.btnSignup.Location = new System.Drawing.Point(84, 411);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.Size = new System.Drawing.Size(143, 41);
            this.btnSignup.TabIndex = 4;
            this.btnSignup.Text = "Sign Up";
            this.btnSignup.Click += new System.EventHandler(this.lollipopButton1_Click);
            // 
            // btnSignIn
            // 
            this.btnSignIn.BackColor = System.Drawing.Color.Transparent;
            this.btnSignIn.BGColor = "#508ef5";
            this.btnSignIn.FontColor = "#ffffff";
            this.btnSignIn.Location = new System.Drawing.Point(84, 364);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(143, 41);
            this.btnSignIn.TabIndex = 3;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // lollipopTextBox1
            // 
            this.lollipopTextBox1.FocusedColor = "#508ef5";
            this.lollipopTextBox1.FontColor = "#999999";
            this.lollipopTextBox1.IsEnabled = true;
            this.lollipopTextBox1.Location = new System.Drawing.Point(43, 274);
            this.lollipopTextBox1.MaxLength = 32767;
            this.lollipopTextBox1.Multiline = false;
            this.lollipopTextBox1.Name = "lollipopTextBox1";
            this.lollipopTextBox1.ReadOnly = false;
            this.lollipopTextBox1.Size = new System.Drawing.Size(221, 24);
            this.lollipopTextBox1.TabIndex = 2;
            this.lollipopTextBox1.Text = "User Name";
            this.lollipopTextBox1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.lollipopTextBox1.UseSystemPasswordChar = false;
            // 
            // lollipopLabel1
            // 
            this.lollipopLabel1.AutoSize = true;
            this.lollipopLabel1.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lollipopLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel1.Location = new System.Drawing.Point(40, 253);
            this.lollipopLabel1.Name = "lollipopLabel1";
            this.lollipopLabel1.Size = new System.Drawing.Size(0, 17);
            this.lollipopLabel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WeChat.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(95, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lollipopTextBox2
            // 
            this.lollipopTextBox2.FocusedColor = "#508ef5";
            this.lollipopTextBox2.FontColor = "#999999";
            this.lollipopTextBox2.IsEnabled = true;
            this.lollipopTextBox2.Location = new System.Drawing.Point(43, 321);
            this.lollipopTextBox2.MaxLength = 32767;
            this.lollipopTextBox2.Multiline = false;
            this.lollipopTextBox2.Name = "lollipopTextBox2";
            this.lollipopTextBox2.ReadOnly = false;
            this.lollipopTextBox2.Size = new System.Drawing.Size(221, 24);
            this.lollipopTextBox2.TabIndex = 5;
            this.lollipopTextBox2.Text = "PassWord";
            this.lollipopTextBox2.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.lollipopTextBox2.UseSystemPasswordChar = false;
            // 
            // userLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lollipopTextBox2);
            this.Controls.Add(this.btnSignup);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.lollipopTextBox1);
            this.Controls.Add(this.lollipopLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "userLogin";
            this.Size = new System.Drawing.Size(290, 506);
            this.Load += new System.EventHandler(this.userLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private LollipopLabel lollipopLabel1;
        private LollipopTextBox lollipopTextBox1;
        private LollipopButton btnSignIn;
        private LollipopButton btnSignup;
        private LollipopTextBox lollipopTextBox2;
    }
}

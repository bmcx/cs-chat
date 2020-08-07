namespace WeChat
{
    partial class SignUp
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
            this.lollipopTextBox1 = new LollipopTextBox();
            this.lollipopTextBox2 = new LollipopTextBox();
            this.lollipopTextBox3 = new LollipopTextBox();
            this.lollipopTextBox4 = new LollipopTextBox();
            this.lollipopButton1 = new LollipopButton();
            this.SuspendLayout();
            // 
            // lollipopTextBox1
            // 
            this.lollipopTextBox1.FocusedColor = "#508ef5";
            this.lollipopTextBox1.FontColor = "#999999";
            this.lollipopTextBox1.IsEnabled = true;
            this.lollipopTextBox1.Location = new System.Drawing.Point(43, 137);
            this.lollipopTextBox1.MaxLength = 32767;
            this.lollipopTextBox1.Multiline = false;
            this.lollipopTextBox1.Name = "lollipopTextBox1";
            this.lollipopTextBox1.ReadOnly = false;
            this.lollipopTextBox1.Size = new System.Drawing.Size(300, 24);
            this.lollipopTextBox1.TabIndex = 0;
            this.lollipopTextBox1.Text = "First Name";
            this.lollipopTextBox1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.lollipopTextBox1.UseSystemPasswordChar = false;
            // 
            // lollipopTextBox2
            // 
            this.lollipopTextBox2.FocusedColor = "#508ef5";
            this.lollipopTextBox2.FontColor = "#999999";
            this.lollipopTextBox2.IsEnabled = true;
            this.lollipopTextBox2.Location = new System.Drawing.Point(43, 197);
            this.lollipopTextBox2.MaxLength = 32767;
            this.lollipopTextBox2.Multiline = false;
            this.lollipopTextBox2.Name = "lollipopTextBox2";
            this.lollipopTextBox2.ReadOnly = false;
            this.lollipopTextBox2.Size = new System.Drawing.Size(300, 24);
            this.lollipopTextBox2.TabIndex = 1;
            this.lollipopTextBox2.Text = "Last Name";
            this.lollipopTextBox2.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.lollipopTextBox2.UseSystemPasswordChar = false;
            // 
            // lollipopTextBox3
            // 
            this.lollipopTextBox3.FocusedColor = "#508ef5";
            this.lollipopTextBox3.FontColor = "#999999";
            this.lollipopTextBox3.IsEnabled = true;
            this.lollipopTextBox3.Location = new System.Drawing.Point(43, 254);
            this.lollipopTextBox3.MaxLength = 32767;
            this.lollipopTextBox3.Multiline = false;
            this.lollipopTextBox3.Name = "lollipopTextBox3";
            this.lollipopTextBox3.ReadOnly = false;
            this.lollipopTextBox3.Size = new System.Drawing.Size(300, 24);
            this.lollipopTextBox3.TabIndex = 2;
            this.lollipopTextBox3.Text = "E-Mail";
            this.lollipopTextBox3.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.lollipopTextBox3.UseSystemPasswordChar = false;
            // 
            // lollipopTextBox4
            // 
            this.lollipopTextBox4.FocusedColor = "#508ef5";
            this.lollipopTextBox4.FontColor = "#999999";
            this.lollipopTextBox4.IsEnabled = true;
            this.lollipopTextBox4.Location = new System.Drawing.Point(43, 305);
            this.lollipopTextBox4.MaxLength = 32767;
            this.lollipopTextBox4.Multiline = false;
            this.lollipopTextBox4.Name = "lollipopTextBox4";
            this.lollipopTextBox4.ReadOnly = false;
            this.lollipopTextBox4.Size = new System.Drawing.Size(300, 24);
            this.lollipopTextBox4.TabIndex = 3;
            this.lollipopTextBox4.Text = "Password";
            this.lollipopTextBox4.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.lollipopTextBox4.UseSystemPasswordChar = false;
            // 
            // lollipopButton1
            // 
            this.lollipopButton1.BackColor = System.Drawing.Color.Transparent;
            this.lollipopButton1.BGColor = "#508ef5";
            this.lollipopButton1.FontColor = "#ffffff";
            this.lollipopButton1.Location = new System.Drawing.Point(149, 371);
            this.lollipopButton1.Name = "lollipopButton1";
            this.lollipopButton1.Size = new System.Drawing.Size(143, 41);
            this.lollipopButton1.TabIndex = 4;
            this.lollipopButton1.Text = "Submit";
            this.lollipopButton1.Click += new System.EventHandler(this.lollipopButton1_Click);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lollipopButton1);
            this.Controls.Add(this.lollipopTextBox4);
            this.Controls.Add(this.lollipopTextBox3);
            this.Controls.Add(this.lollipopTextBox2);
            this.Controls.Add(this.lollipopTextBox1);
            this.Name = "SignUp";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RightToLeftLayout = true;
            this.Text = "SignUp";
            this.Load += new System.EventHandler(this.Sign_up1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private LollipopTextBox lollipopTextBox1;
        private LollipopTextBox lollipopTextBox2;
        private LollipopTextBox lollipopTextBox3;
        private LollipopTextBox lollipopTextBox4;
        private LollipopButton lollipopButton1;
    }
}
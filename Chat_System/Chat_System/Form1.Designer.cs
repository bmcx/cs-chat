namespace Chat_System
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.User_Name = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Password = new System.Windows.Forms.TextBox();
            this.SignUp = new System.Windows.Forms.Button();
            this.SignIn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(596, 59);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(561, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 27);
            this.button1.TabIndex = 1;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "SIGN IN";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.User_Name);
            this.panel2.Location = new System.Drawing.Point(119, 112);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(248, 43);
            this.panel2.TabIndex = 1;
            // 
            // User_Name
            // 
            this.User_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.User_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.User_Name.Location = new System.Drawing.Point(17, 11);
            this.User_Name.Name = "User_Name";
            this.User_Name.Size = new System.Drawing.Size(193, 13);
            this.User_Name.TabIndex = 0;
            this.User_Name.Text = "User Name";
            this.User_Name.Enter += new System.EventHandler(this.User_Name_Enter);
            this.User_Name.Leave += new System.EventHandler(this.User_Name_Leave);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.Password);
            this.panel3.Location = new System.Drawing.Point(119, 161);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(248, 43);
            this.panel3.TabIndex = 2;
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Password.Location = new System.Drawing.Point(17, 10);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(193, 13);
            this.Password.TabIndex = 1;
            this.Password.Text = "Password";
            this.Password.Enter += new System.EventHandler(this.Password_Enter);
            this.Password.Leave += new System.EventHandler(this.Password_Leave);
            // 
            // SignUp
            // 
            this.SignUp.BackColor = System.Drawing.Color.Yellow;
            this.SignUp.FlatAppearance.BorderSize = 0;
            this.SignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignUp.Location = new System.Drawing.Point(137, 235);
            this.SignUp.Name = "SignUp";
            this.SignUp.Size = new System.Drawing.Size(75, 23);
            this.SignUp.TabIndex = 3;
            this.SignUp.Text = "Sign Up";
            this.SignUp.UseVisualStyleBackColor = false;
            this.SignUp.Click += new System.EventHandler(this.SignUp_Click);
            // 
            // SignIn
            // 
            this.SignIn.BackColor = System.Drawing.Color.Lime;
            this.SignIn.FlatAppearance.BorderSize = 0;
            this.SignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignIn.Location = new System.Drawing.Point(291, 236);
            this.SignIn.Name = "SignIn";
            this.SignIn.Size = new System.Drawing.Size(76, 22);
            this.SignIn.TabIndex = 4;
            this.SignIn.Text = "Sign In";
            this.SignIn.UseVisualStyleBackColor = false;
            this.SignIn.Click += new System.EventHandler(this.SignIn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(597, 299);
            this.ControlBox = false;
            this.Controls.Add(this.SignIn);
            this.Controls.Add(this.SignUp);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox User_Name;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button SignUp;
        private System.Windows.Forms.Button SignIn;
    }
}


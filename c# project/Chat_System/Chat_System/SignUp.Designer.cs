namespace Chat_System
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.First_Name = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Last_Name = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Email = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Password = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.Repassword = new System.Windows.Forms.TextBox();
            this.Submit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 63);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sign Up";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(762, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.First_Name);
            this.panel2.Location = new System.Drawing.Point(264, 119);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(215, 39);
            this.panel2.TabIndex = 1;
            // 
            // First_Name
            // 
            this.First_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.First_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.First_Name.ForeColor = System.Drawing.Color.White;
            this.First_Name.Location = new System.Drawing.Point(15, 12);
            this.First_Name.Name = "First_Name";
            this.First_Name.Size = new System.Drawing.Size(184, 13);
            this.First_Name.TabIndex = 0;
            this.First_Name.Text = "First Name";
            this.First_Name.Enter += new System.EventHandler(this.First_Name_Enter);
            this.First_Name.Leave += new System.EventHandler(this.First_Name_Leave);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.Last_Name);
            this.panel3.Location = new System.Drawing.Point(264, 164);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(215, 39);
            this.panel3.TabIndex = 2;
            // 
            // Last_Name
            // 
            this.Last_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Last_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Last_Name.ForeColor = System.Drawing.Color.White;
            this.Last_Name.Location = new System.Drawing.Point(15, 13);
            this.Last_Name.Name = "Last_Name";
            this.Last_Name.Size = new System.Drawing.Size(184, 13);
            this.Last_Name.TabIndex = 1;
            this.Last_Name.Text = "Last Name";
            this.Last_Name.Enter += new System.EventHandler(this.Last_Name_Enter);
            this.Last_Name.Leave += new System.EventHandler(this.Last_Name_Leave);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.Email);
            this.panel4.Location = new System.Drawing.Point(264, 209);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(215, 39);
            this.panel4.TabIndex = 2;
            // 
            // Email
            // 
            this.Email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Email.ForeColor = System.Drawing.Color.White;
            this.Email.Location = new System.Drawing.Point(15, 13);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(184, 13);
            this.Email.TabIndex = 2;
            this.Email.Text = "E-mail";
            this.Email.Enter += new System.EventHandler(this.Email_Enter);
            this.Email.Leave += new System.EventHandler(this.Email_Leave);
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.Password);
            this.panel5.Location = new System.Drawing.Point(264, 254);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(215, 39);
            this.panel5.TabIndex = 2;
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Password.ForeColor = System.Drawing.Color.White;
            this.Password.Location = new System.Drawing.Point(15, 10);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(184, 13);
            this.Password.TabIndex = 3;
            this.Password.Text = "Password";
            this.Password.Enter += new System.EventHandler(this.Password_Enter);
            this.Password.Leave += new System.EventHandler(this.Password_Leave);
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.Repassword);
            this.panel6.Location = new System.Drawing.Point(264, 299);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(215, 39);
            this.panel6.TabIndex = 2;
            // 
            // Repassword
            // 
            this.Repassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Repassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Repassword.ForeColor = System.Drawing.Color.White;
            this.Repassword.Location = new System.Drawing.Point(15, 11);
            this.Repassword.Name = "Repassword";
            this.Repassword.Size = new System.Drawing.Size(184, 13);
            this.Repassword.TabIndex = 4;
            this.Repassword.Text = "Re-Password";
            this.Repassword.Enter += new System.EventHandler(this.Repassword_Enter);
            this.Repassword.Leave += new System.EventHandler(this.Repassword_Leave);
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.Color.Lime;
            this.Submit.FlatAppearance.BorderSize = 0;
            this.Submit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.Submit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Submit.Location = new System.Drawing.Point(318, 365);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(103, 25);
            this.Submit.TabIndex = 3;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SignUp";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.TextBox First_Name;
        private System.Windows.Forms.TextBox Last_Name;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox Repassword;
    }
}
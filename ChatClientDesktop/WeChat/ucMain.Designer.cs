namespace WeChat
{
    partial class ucMain
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
            this.listOnline = new System.Windows.Forms.ListBox();
            this.lollipopButton1 = new LollipopButton();
            this.SuspendLayout();
            // 
            // listOnline
            // 
            this.listOnline.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listOnline.FormattingEnabled = true;
            this.listOnline.Items.AddRange(new object[] {
            "nimal",
            "kamal",
            "amal"});
            this.listOnline.Location = new System.Drawing.Point(0, 0);
            this.listOnline.Name = "listOnline";
            this.listOnline.Size = new System.Drawing.Size(294, 564);
            this.listOnline.TabIndex = 0;
            this.listOnline.Click += new System.EventHandler(this.listOnline_Click);
            // 
            // lollipopButton1
            // 
            this.lollipopButton1.BackColor = System.Drawing.Color.Transparent;
            this.lollipopButton1.BGColor = "#508ef5";
            this.lollipopButton1.FontColor = "#ffffff";
            this.lollipopButton1.Location = new System.Drawing.Point(148, 477);
            this.lollipopButton1.Name = "lollipopButton1";
            this.lollipopButton1.Size = new System.Drawing.Size(143, 41);
            this.lollipopButton1.TabIndex = 1;
            this.lollipopButton1.Text = "Update Profile";
            this.lollipopButton1.Click += new System.EventHandler(this.lollipopButton1_Click);
            // 
            // ucMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lollipopButton1);
            this.Controls.Add(this.listOnline);
            this.Name = "ucMain";
            this.Size = new System.Drawing.Size(294, 564);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listOnline;
        private LollipopButton lollipopButton1;
    }
}

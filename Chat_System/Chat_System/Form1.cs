using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chat_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void User_Name_Enter(object sender, EventArgs e)
        {
            User_Name.Text = "";
        }

        private void User_Name_Leave(object sender, EventArgs e)
        {
            if (User_Name.Text == "")
            {
                User_Name.Text = "User Name";
            }
        }

        private void Password_Enter(object sender, EventArgs e)
        {
            Password.Text = "";
        }

        private void Password_Leave(object sender, EventArgs e)
        {
            if (Password.Text == "")
            {
                Password.Text = "Password";
            }
        }

        private void SignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp ss = new SignUp();
            ss.Show();
        }

        private void SignIn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main ms = new Main();
            ms.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}

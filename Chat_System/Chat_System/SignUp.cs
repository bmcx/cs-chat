using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Chat_System
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }
        string connectionString = @"(LocalDB)\MSSQLLocalDB  (DESKTOP-50JFPR2\Nelaka)";
        private void Submit_Click(object sender, EventArgs e)
       {
            if (Password.Text != Repassword.Text)
                MessageBox.Show("Password do not Match");
            else
                {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlCommand sqlcmd = new SqlCommand("UserAdd", sqlCon);
                    sqlcmd.CommandType = CommandType.StoredProcedure;
                    sqlcmd.Parameters.AddWithValue("@FirstName", First_Name.Text.Trim());
                    sqlcmd.Parameters.AddWithValue("@LastName", Last_Name.Text.Trim());
                    sqlcmd.Parameters.AddWithValue("@Email", Email.Text.Trim());
                    sqlcmd.Parameters.AddWithValue("@Password", Password.Text.Trim());
                    sqlcmd.Parameters.AddWithValue("@Repassword", Repassword.Text.Trim());
                    sqlcmd.ExecuteNonQuery();

                    ;

                    MessageBox.Show("Welcome to Chat System");
                    Clear();
                }

            }
            void Clear()
            {
                First_Name.Text = Last_Name.Text = Email.Text = Password.Text = Repassword.Text = "";
            }
            this.Hide();
            Main msu = new Main();
            msu.Show();

        }

        private void First_Name_Enter(object sender, EventArgs e)
        {
            First_Name.Text = "";
        }

        private void First_Name_Leave(object sender, EventArgs e)
        {
            if(First_Name.Text == "")
            {
                First_Name.Text = "First Name";
            }
        }

        private void Last_Name_Enter(object sender, EventArgs e)
        {
            Last_Name.Text = "";

        }

        private void Last_Name_Leave(object sender, EventArgs e)
        {
            if (Last_Name.Text == "")
            {
                Last_Name.Text = "Lastt Name";
            }
        }

        private void Email_Enter(object sender, EventArgs e)
        {
            Email.Text = "";
        }

        private void Email_Leave(object sender, EventArgs e)
        {
            if (Email.Text == "")
            {
                Email.Text = "E-mail";
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

        private void Repassword_Enter(object sender, EventArgs e)
        {
            Repassword.Text = "";
        }

        private void Repassword_Leave(object sender, EventArgs e)
        {
            if (Repassword.Text == "")
            {
                Repassword.Text = "Re-Password";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //windows Close Butto X
            this.Close();
        }
    }
}

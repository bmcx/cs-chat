using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeChat
{
    public partial class userLogin : UserControl
    {
        public userLogin()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            frmMain.Instance.Content.Controls.Add(new ucMain() { Dock = DockStyle.Fill });
            frmMain.Instance.Content.Controls[0].SendToBack();
        }

        private void userLogin_Load(object sender, EventArgs e)
        {

        }

        private void lollipopButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp s1 = new SignUp();
            s1.Show();
        }
    }
}

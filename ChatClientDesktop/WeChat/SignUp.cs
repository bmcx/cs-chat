using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeChat
{
    public partial class SignUp : MaterialForm
    {
        public SignUp()
        {
            InitializeComponent();
            MaterialSkinManager manager = MaterialSkinManager.Instance;
            manager.AddFormToManage(this);
            manager.Theme = MaterialSkinManager.Themes.LIGHT;
            manager.ColorScheme = new ColorScheme(Primary.Blue400, Primary.Blue500, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void Sign_up1_Load(object sender, EventArgs e)
        {

        }

        private void lollipopButton1_Click(object sender, EventArgs e)
        {
            frmMain.Instance.Content.Controls.Add(new ucMain() { Dock = DockStyle.Fill });
            frmMain.Instance.Content.Controls[0].SendToBack();

        }
    }
}

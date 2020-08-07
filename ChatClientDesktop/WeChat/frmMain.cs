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
    public partial class frmMain : MaterialForm
    {
        private static frmMain _instance;
        public static frmMain Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new frmMain();
                return _instance;
            }
        }
        public frmMain()
        {
            InitializeComponent();
            MaterialSkinManager manager = MaterialSkinManager.Instance;
            manager.AddFormToManage(this);
            manager.Theme = MaterialSkinManager.Themes.LIGHT;
            manager.ColorScheme = new ColorScheme(Primary.Blue400, Primary.Blue500, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);
        }

        public Panel Content
        {
            get { return MainContainer; }
            set { MainContainer = value; }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            _instance = this;
            MainContainer.Controls.Add(new userLogin() { Dock = DockStyle.Fill });
        }

        private void MainContainer_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

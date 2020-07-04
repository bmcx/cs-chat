using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
              private void button1_Click(object sender, EventArgs e)
            {
                // open file dialog   
                OpenFileDialog open = new OpenFileDialog();
                // image filters  
                open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    // display image in picture box  
                    pictureBox1.Image = new Bitmap(open.FileName);
                    // image file path  
                    textBox1.Text = open.FileName;
                string mob = textBox2.Text;
                string pas = textBox3.Text;
            }
            }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
    }


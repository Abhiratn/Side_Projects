using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void show_btn_Click(object sender, EventArgs e)
        {
            //Show the open file dialogue. if user clicks ok and load the picture user want
            if (openFileDialog1.ShowDialog() == DialogResult.OK) 
            {
                pictureBox1.Load(openFileDialog1.FileName);
            }
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void bg_btn_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.BackColor = colorDialog1.Color;
            }
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cb_1_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_1.Checked)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
        }
    }
}

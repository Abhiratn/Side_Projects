using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            lbl_op.Text = "+";
            double n1 = double.Parse(textBox1.Text);
            double n2 = double.Parse(textBox2.Text);
            double result = n1+n2;
            lbl_res.Text = Convert.ToString(result);
        }

        private void btn_sub_Click(object sender, EventArgs e)
        {
            lbl_op.Text = "-";
            double n1 = double.Parse(textBox1.Text);
            double n2 = double.Parse(textBox2.Text);
            double result = n1 - n2;
            lbl_res.Text = Convert.ToString(result);
        }

        private void btn_mul_Click(object sender, EventArgs e)
        {
            lbl_op.Text = "X";
            double n1 = double.Parse(textBox1.Text);
            double n2 = double.Parse(textBox2.Text);
            double result = n1 * n2;
            lbl_res.Text = Convert.ToString(result);
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            try
            {
                lbl_op.Text = "/";
                double n1 = double.Parse(textBox1.Text);
                double n2 = double.Parse(textBox2.Text);
                if(n2 == 0)
                {
                    throw new DivideByZeroException();
                }
                double result = n1 / n2;
                lbl_res.Text = Convert.ToString(result);
            }
            catch (DivideByZeroException)
            {
                lbl_res.Text = "Cant divide by Zero";
            }


        }

        private void btn_clr_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            lbl_op.Text = "";
            lbl_res.Text = "";
        }
    }
}

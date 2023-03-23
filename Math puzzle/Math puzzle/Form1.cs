using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Math_puzzle
{
    public partial class Form1 : Form
    {
        //randomizer
        Random randomizer = new Random();

        //Integer for addition
        int add1;
        int add2;

        //Integer for subtraction
        int sub1;
        int sub2;

        //Integer for multiplication
        int muland;
        int mulor;

        //Integer for divide
        int divend;
        int divor;

        //timer
        int timeleft;


        //quiz starter
        public void StartTheQuiz()
        {
            //for Addition
            add1 = randomizer.Next(51);
            add2 = randomizer.Next(51);


            plus_left_lbl.Text = add1.ToString();
            plus_right_lbl.Text = add2.ToString();

            sum.Value = 0;

            //for subtraction
            sub1 = randomizer.Next(1, 101);
            sub2 = randomizer.Next(1, sub1);

            sub_left_lbl.Text = sub1.ToString();
            sub_right_lbl.Text = sub2.ToString();

            sub.Value = 0;

            //for multiplication
            muland = randomizer.Next(2, 11);
            mulor = randomizer.Next(2, 11);

            mul_left_lbl.Text = muland.ToString();
            mul_right_lbl.Text = mulor.ToString();

            mul.Value = 0;

            //for division
            divor = randomizer.Next(2, 11);
            int temporaryQuotient = randomizer.Next(2, 11);
            divend = divor * temporaryQuotient;

            div_left_lbl.Text = divend.ToString();
            div_right_lbl.Text = divor.ToString();

            div.Value = 0;

            //start the timer
            timeleft = 30;
            time_lbl.Text = "30 seconds";
            timer1.Start();
        }
        //answer checker
        private bool CheckTheAnswer()
        {
            if ((add1 + add2 == sum.Value && sub1 - sub2 == sub.Value && muland * mulor == mul.Value && divend / divor == div.Value))
                return true;
            else
                return false;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void strt_btn_Click(object sender, EventArgs e)
        {
            StartTheQuiz();
            strt_btn.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CheckTheAnswer())
            {
                timer1.Stop();
                MessageBox.Show("Congrates lad You Win What? Do You want a prize there is non now scram");
                strt_btn.Enabled = true;
            }
            else if (timeleft > 0)
            {
                timeleft = timeleft -1;
                time_lbl.Text = timeleft + "seconds";
            }
            else
            {
                timer1.Stop();
                time_lbl.Text = "Why don't you try again";
                MessageBox.Show("Slow like a turtle dumb lad");
                sum.Value = add1 + add2;
                sub.Value = sub1 - sub2;
                mul.Value = muland * mulor;
                div.Value = divend / divor;
                strt_btn.Enabled = true;
            }
        }
    }
}

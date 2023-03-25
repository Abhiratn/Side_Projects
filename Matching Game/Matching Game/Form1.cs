using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matching_Game
{
    public partial class Form1 : Form
    {
        //Label reference
        //first click
        Label firstClicked = null;

        //second click
        Label secondClicked = null;
        Random random = new Random();
        //adding icons
        List<string> icons = new List<string>()
        {
            "!", "!", "N", "N", ",", ",", "k", "k",
            "b", "b", "v", "v", "%", "%", "Y", "Y"
        };
     private void AssignIconsToSquares() 
        {
         //to set icon in tiles
         foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;
                if (iconLabel != null )
                {
                    int randomNumber = random.Next( icons.Count );
                    iconLabel.Text = icons[randomNumber];
                    iconLabel.ForeColor = iconLabel.BackColor;
                    icons.RemoveAt(randomNumber);
                }
            }
        }
        public Form1()
        {
            InitializeComponent();

            AssignIconsToSquares();
        }

        private void lbl1_click(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;
            if (clickedLabel != null)
            {
                if (clickedLabel.ForeColor == Color.Black)
                    return;

                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;

                    return;
                }
                // second clicked timer part
                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;

                //winnerchecker implementaion
                CheckWinner();

                //matching part
                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }

                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //stop timer
            timer1.Stop();

            //hide both icons
            firstClicked.ForeColor = firstClicked.BackColor;
            secondClicked.ForeColor = secondClicked.BackColor;

            //reset clicks
            firstClicked = null;
            secondClicked = null;
        }
        //winner checker
        private void CheckWinner()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;
                if (iconLabel != null)
                {
                    if (iconLabel.ForeColor == iconLabel.BackColor)
                        return;
                }
            }

            //win msg
            MessageBox.Show("Omedetō You win.", "Hip Hip Hooray");
            Close();
        }
    }
}

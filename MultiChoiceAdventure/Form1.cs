using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiChoiceAdventure
{
    public partial class Form1 : Form
    {
        int scene = 0;
        int keyPresent = 0;
        Random randGen = new Random();
        public Form1()
        {
            InitializeComponent();

            //

            outputLabel.Text = "You begin daydreaming in class, and wake up to a sudden snap of a ruler on your desk. " +
                "\nYou open your eyes, and everyone is missing, with no trace.";
           blueText.Text="Investigate room.";
            redText.Text="Leave Immediately.";
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int randNum = randGen.Next(1, 11);
            if (e.KeyCode == Keys.M) //Red 
            {
                if (scene == 0)
                {
                    scene = 1;
                    outputLabel.Text = "";
                    redText.Text = "";
                    blueText.Text = "";
                }
                else if (scene == 1 | scene == 4)
                {
                    scene = 5;
                    outputLabel.Text = "";
                    redText.Text = "";
                    blueText.Text = "";
                }
                else if (scene == 2)
                {
                    scene = 4;
                    outputLabel.Text = "";
                    redText.Text = "";
                    blueText.Text = "";
                }
                else if (scene == 5)
                {
                    scene = 6;
                    outputLabel.Text = "";
                    redText.Text = "";
                    blueText.Text = "";
                }
                else if (scene == 6)
                {
                    scene = 8;
                    outputLabel.Text = "";
                    redText.Text = "";
                    blueText.Text = "";
                }
                else if (scene == 8)
                {
                    scene = 10;
                    outputLabel.Text = "";
                    redText.Text = "";
                    blueText.Text = "";
                }
                else if (scene == 10)
                {
                    scene = 11;
                    outputLabel.Text = "";
                    redText.Text = "";
                    blueText.Text = "";
                }
                else if (scene == 11)
                {
                    scene = 12;
                    outputLabel.Text = "";
                    redText.Text = "";
                    blueText.Text = "";
                }
                else if (scene == 12)
                {
                    scene = 15;
                    outputLabel.Text = "";
                    redText.Text = "";
                    blueText.Text = "";
                }
                else if (scene == 15)
                {
                    scene = 16;
                    outputLabel.Text = "";
                    redText.Text = "";
                    blueText.Text = "";
                }
                else if (scene == 16)
                {
                    scene = 18;
                    outputLabel.Text = "";
                    redText.Text = "";
                    blueText.Text = "";
                }
                else if (scene == 17)
                {
                    scene = 20;
                    outputLabel.Text = "";
                    redText.Text = "";
                    blueText.Text = "";
                }
                else if (scene == 7|scene == 18 | scene == 19 | scene == 20 | scene == 21|scene ==24)
                {
                    scene = 22;
                    outputLabel.Text = "Restart?";
                    redText.Text = "Yes.";
                    blueText.Text = "No.";
                }
            }
            if (e.KeyCode == Keys.B)
            {
                if (scene == 0)
                {
                    scene = 2;
                }
                else if (scene == 2)
                {
                    scene = 3;
                }
                else if (scene == 3)
                {
                    scene = 1;
                    keyPresent = 1;
                }
                else if (scene == 5|scene == 9|scene == 23)
                {
                    scene = 7;
                }
                else if (scene == 8)
                {
                    scene = 9;
                }
                else if (scene == 10)
                {
                    scene = 13;
                }
                else if (scene == 13)
                {
                    scene = 14;
                }
                else if (scene == 14)
                {
                    if (randNum < 7)
                    {
                        scene = 22;
                    }
                    else
                    {
                        scene = 23;
                    }
                }
                else if (scene == 15)
                {
                    scene = 17;
                }
                else if (scene == 17)
                {
                    scene = 21;
                }
                else if (scene == 16)
                {
                    scene = 19;
                }
                else if (scene == 7|scene == 18 | scene == 19 | scene == 20 | scene == 21|scene == 24)
                {
                    scene = 22;
                    outputLabel.Text = "Restart?";
                    redText.Text = "Yes.";
                    blueText.Text = "No.";
                }
            }
            if (e.KeyCode == Keys.N)
            {
                if (scene == 2)
                {
                    scene = 24;
                }
            }
        }
    }
}

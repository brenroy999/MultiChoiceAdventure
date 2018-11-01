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
            if (e.KeyCode == Keys.M)
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
                }
                else if (scene == 2)
                {
                    scene = 4;
                }
                else if (scene == 5)
                {
                    scene = 6;
                }
                else if (scene == 6)
                {
                    scene = 8;
                }
                else if (scene == 8)
                {
                    scene = 10;
                }
                else if (scene == 10)
                {
                    scene = 11;
                }
                else if (scene == 11)
                {
                    scene = 12;
                }
                else if (scene == 12)
                {
                    scene = 15;
                }
                else if (scene == 15)
                {
                    scene = 16;
                }
                else if (scene == 16)
                {
                    scene = 18;
                }
                else if (scene == 17)
                {
                    scene = 20;
                }
                else if (scene == 18|scene == 19|scene == 20|scene == 21)
                {
                    scene = 22;
                    outputLabel.Text = "Restart?";
                    redText.Text = "Yes.";
                    blueText.Text = "No.";
                }
            }
        }
    }
}

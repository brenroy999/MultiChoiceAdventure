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
        bool keyPresent = false;
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
                    outputLabel.Text = "You run out through the door, looking both ways down the hall," + 
                        "\nstill seeing no one around.";
                    redText.Text = "Continue";
                    blueText.Text = "";
                }
                else if (scene == 1 | scene == 4)
                {
                    scene = 5;
                    outputLabel.Text = "You continue down the hall, and exit the building. " +
                        "\nThe door leaves you in a random field, and the door is gone when you turn around to look.";
                    redText.Text = "Continue traveling straight forward";
                    blueText.Text = "Observe surrounding area";
                }
                else if (scene == 2)
                {
                    scene = 4;
                    outputLabel.Text = "The vent comes off easiky, and you enter the ventilation system.";
                    redText.Text = "Exit into hallway.";
                    blueText.Text = "Continue through vents.";
                }
                else if (scene == 5)
                {
                    scene = 6;
                    outputLabel.Text = "You trip on some sort of root, and close your eyes. " +
                        "\nWhen it feels you’re about to hit the ground, you notice the sensation of high gusts of wind. " +
                        "\nYou’re now on a snowy mountain. Somehow";
                    redText.Text = "";
                    blueText.Text = "";
                }
                else if (scene == 6)
                {
                    scene = 8;
                    outputLabel.Text = "You enter a nearby structure to escape the cold, and come across an armory, " +
                        "\nwith a locked door on the one side.";
                    redText.Text = "Browse Equipment";
                    blueText.Text = "Attempt to unlock door";
                }
                else if (scene == 8)
                {
                    scene = 10;
                    outputLabel.Text = "";
                    redText.Text = "";
                    blueText.Text = "";
                }
                else if (scene ==9)
                {
                    scene = 7;
                    outputLabel.Text = "";
                    redText.Text = "Continue";
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
                    outputLabel.Text = "Obtained key.";
                    redText.Text = "Continue";
                    blueText.Text = "";
                    keyPresent = true;
                }
                else if (scene == 5|scene == 9|scene == 23)
                {
                    scene = 7;
                }
                else if (scene == 8)
                {
                    if (keyPresent == true)
                    {
                        scene = 9;
                        outputLabel.Text = "The door opens, and you're blinded by a bright light. ";
                        redText.Text = "Continue";
                        blueText.Text = "";
                    }
                    else
                    {
                        scene = 10;
                        outputLabel.Text = "";
                    }
                }
                else if (scene == 10)
                {
                    scene = 13;
                }
                else if (scene == 13)
                {
                    scene = 14; ;
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

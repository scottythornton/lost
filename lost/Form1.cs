using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lost
{
    public partial class Form1 : Form
    {
        int scene = 0;

        public Form1()
        {
            InitializeComponent();

            outputLabel1.Text = "Your plane crashed on a island and you are the only " +
                "\nsurvivor";
            redLabel.Text = "Search the plane";
            blueLabel.Text = "Go out and scavenge";
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.R)
            {
                if (scene == 0)
                {
                    scene = 1;
                }
                else if (scene == 1)
                {
                    scene = 3;
                }
                else if (scene == 2)
                {
                    scene = 0;
                }
                else if (scene == 99)
                {
                    this.Close();
                }
                else if (scene == 3)
                {
                    scene = 5;
                }
                else if (scene == 5)
                {
                    scene = 6;
                }
                else if (scene == 4)
                {
                    scene = 0;
                }
                else if (scene == 7)
                {
                    scene = 8;
                }
                else if (scene == 10)
                {
                    scene = 11;
                }
                else if (scene == 12)
                {
                    scene = 14;
                }
                else if (scene == 13)
                {
                    scene = 16;
                }
                else if (scene == 16)
                {
                    scene = 18;
                }
                else if (scene == 8)
                {
                    scene = 0;
                }
                else if (scene == 6)
                {
                    scene = 0;
                }
                else if (scene == 18)
                {
                    scene = 19;
                }
                else if (scene == 14)
                {
                    scene = 0;
                }
                else if (scene == 11)
                {
                    scene = 0;
                }
                else if (scene == 9)
                {
                    scene = 0;
                }
                else if (scene == 15)
                {
                    scene = 0;
                }
                else if (scene == 17)
                {
                    scene = 0;
                }
                else if (scene == 19)
                {
                    scene = 0;
                }
                else if (scene == 20)
                {
                    scene = 0;
                }
            }
            else if (e.KeyCode == Keys.B)
            {
                if (scene == 0)
                {
                    scene = 10;
                }
                else if (scene == 8)
                {
                    scene = 99;
                }
                else if (scene ==2)
                {
                    scene = 99;
                }
                else if (scene == 3)
                {
                    scene = 4;
                }
                else if (scene ==5)
                {
                    scene = 7;
                }
                else if (scene == 1)
                {
                    scene = 2;
                }
                else if (scene == 7)
                {
                    scene = 9;
                }
                else if (scene == 6)
                {
                    scene = 99;
                }
                else if (scene == 10)
                {
                    scene = 12;
                }
                else if (scene == 11)
                {
                    scene = 99;
                }
                else if (scene == 12)
                {
                    scene = 13;
                }
                else if (scene == 9)
                {
                    scene = 99;
                }
                else if (scene == 13)
                {
                    scene = 15;
                }
                else if (scene == 4)
                {
                    scene = 99;
                }
                else if (scene == 16)
                {
                    scene = 17;
                }
                else if (scene == 15)
                {
                    scene = 99;
                }
                else if (scene == 14)
                {
                    scene = 99;
                }
                else if (scene == 17)
                {
                    scene = 99;
                }
                else if (scene == 19)
                {
                    scene = 99;
                }
                else if (scene == 20)
                {
                    scene = 99;
                }
                else if (scene == 18)
                {
                    scene = 20;
                }
            }
            switch (scene)
            {
                case 0:
                    storyPictures.BackgroundImage = null;
                    outputLabel1.Text = "Your plane crashed on a island and you are the only " +
                        "\nsurvivor";
                    redLabel.Text = "Search the plane";
                    blueLabel.Text = "Go out and scavenge";
                    break;
                case 1:
                    outputLabel1.Text = "You find what seems to be water";
                    redLabel.Text = "Leave it";
                    blueLabel.Text = "Drink it";
                    break;
                case 2:
                    outputLabel1.Text = "It's water mixed with a odorless chemical and you " +
                        "\ndie";
                    redLabel.Text = "Play Again";
                    blueLabel.Text = "End";
                    break;
                case 3:
                    outputLabel1.Text = "You keep looking and find some food the flight " +
                        "\nattendants were serving";
                    redLabel.Text = "Take it";
                    blueLabel.Text = "Leave it";
                    break;
                case 4:
                    outputLabel1.Text = "You die of starvation because you couldn't find " +
                        "\nany other food";
                    redLabel.Text = "Play Again";
                    blueLabel.Text = "End";
                    break;
                case 5:
                    outputLabel1.Text = "The food is good. You are stuffed. It's now night " +
                        "\ntime";
                    redLabel.Text = "Sleep on the plane";
                    blueLabel.Text = "Find shelter for the night";
                    break;
                case 6:
                    outputLabel1.Text = "There is still a fire somewhere on the plane and " +
                        "\nthe flame comes in contact with gas, and the plane blows up and " +
                        "\nkills you";
                    redLabel.Text = "Play Again";
                    blueLabel.Text = "End";
                    break;
                case 7:
                    outputLabel1.Text = "You find a good place to stay for the night. It's " +
                        "\nthe next morning";
                    redLabel.Text = "Set up camp";
                    blueLabel.Text = "Call out SOS";
                    break;
                case 8:
                    outputLabel1.Text = "You miss a boat coming by because you were too busy " +
                        "\nsetting up camp and will never be rescued";
                    redLabel.Text = "Play Again";
                    blueLabel.Text = "End";
                    break;
                case 9:
                    outputLabel1.Text = "A rescue boat comes and saves you and you are taken " +
                        "\nhome to your family, YOU WIN!";
                    redLabel.Text = "Play Again";
                    blueLabel.Text = "End";
                    storyPictures.BackgroundImage = Properties.Resources.boat; ;
                    break;
                case 10:
                    outputLabel1.Text = "You find a bush that is rattiling around.";
                    redLabel.Text = "Go investigate the bush";
                    blueLabel.Text = "Go the other way";
                    storyPictures.BackgroundImage = Properties.Resources.bush;
                    break;
                case 11:
                    outputLabel1.Text = "It's a family of black mamba's and they all jump out " +
                        "\nand feed off you";
                    redLabel.Text = "Play Again";
                    blueLabel.Text = "End";
                    storyPictures.BackgroundImage = Properties.Resources.snake;
                    break;
                case 12:
                    storyPictures.BackgroundImage = null;
                    outputLabel1.Text = "You find shelter and food to keep you safe for a few " +
                        "\ndays, but you need water";
                    redLabel.Text = "Go North";
                    blueLabel.Text = "Go South";
                    break;
                case 13:
                    outputLabel1.Text = "You find a lake but hear people yelling in the distance";
                    redLabel.Text = "Go towards the voices";
                    blueLabel.Text = "Run away";
                    break;
                case 14:
                    outputLabel1.Text = "You run into a hippo and it eats you, you are now dead";
                    redLabel.Text = "Play Again";
                    blueLabel.Text = "End";
                    storyPictures.BackgroundImage = Properties.Resources.hippo;
                    break;
                case 15:
                    outputLabel1.Text = "You run into a jaguar and die instantly";
                    redLabel.Text = "Play Again";
                    blueLabel.Text = "End";
                    storyPictures.BackgroundImage = Properties.Resources.jaguar;
                    break;
                case 16:
                    outputLabel1.Text = "You see a huge village with a lot of people with swords " +
                        "\nand spears";
                    redLabel.Text = "Sneak into the main building";
                    blueLabel.Text = "Try and talk to them";
                    storyPictures.BackgroundImage = Properties.Resources.village;
                    break;
                case 17:
                    storyPictures.BackgroundImage = null;
                    outputLabel1.Text = "They get scared and you get captured and eaten alive, " +
                        "\nyou are now dead.";
                    redLabel.Text = "Play Again";
                    blueLabel.Text = "End";
                    break;
                case 18:
                    storyPictures.BackgroundImage = null;
                    outputLabel1.Text = "You see the people doing a ritual but you knock " +
                        "\nsomething over and you are found and captured";
                    redLabel.Text = "Ask to be apart of their tribe";
                    blueLabel.Text = "Take the offer to be sent home in a boat";
                    break;
                case 19:
                    outputLabel1.Text = "They betray you and they kill you and eat you.";
                    redLabel.Text = "Play Again";
                    blueLabel.Text = "End";
                    break;
                case 20:
                    outputLabel1.Text = "You take a boat home and are reunited with your family " +
                        "\nYOU WIN!";
                    redLabel.Text = "Play Again";
                    blueLabel.Text = "End";
                    break;
                case 99:
                    this.Close();
                    break;
            }
        }
    }
}
    

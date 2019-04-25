using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Default_Game
{
    public partial class Form1 : Form
    {
        public System.Windows.Forms.Keys KeyCode { get; }

        public Form1()
        {
            InitializeComponent();

            new Settings();
            new Arena();

            gameTimer.Interval = 30;
            gameTimer.Tick += UpdateScreen;
            gameTimer.Start();

            StartGame();
        }

        public void StartGame()
        {
        }

        public void UpdateScreen(object sender, EventArgs e)
        {
            new Collision_Detector(Settings.Ypos, Settings.Xpos);

            if (Settings.Falling == 16)
            {
                Settings.Falling -= 1;
                Settings.Ypos -= 10; 
            }
            else if (Settings.Falling == 14)
            {
                Settings.Falling -= 1;
                Settings.Ypos -= 10;

            }
            else if (Settings.Falling == 12)
            {
                Settings.Falling -= 1;
                Settings.Ypos -= 5;

            }
            else if (Settings.Falling == 11)
            {
                Settings.Falling -= 1;
                Settings.Ypos -= 5;

            }
            else if (Settings.Falling == 10)
            {
                Settings.Falling -= 1;
                Settings.Ypos += 5;

            }
            else if (Settings.Falling == 7)
            {
                Settings.Falling -= 1;
                Settings.Ypos += 10;

            }
            else if (Settings.Falling == 6)
            {
                Settings.Falling -= 1;
                Settings.Ypos += 10;

            }
            else if (Settings.Falling == 3)
            {
                Settings.Falling -= 1;
                Settings.Ypos += 15;

            }
            else if (Settings.Falling == 2)
            {
                Settings.Falling -= 1;
                Settings.Ypos += 20;

            }
            else if (Settings.Falling > 0)
            {
                Settings.Falling -= 1;

                if (Settings.Facing == "R")
                {
                    for (int i = 0; i < Arena.Building_Count; i++)
                    {
                        Arena.Buildings_X[i] -= Settings.Game_Speed;
                    }
                }
                else if (Settings.Facing == "L")
                {
                    for (int i = 0; i < Arena.Building_Count; i++)
                    {
                        Arena.Buildings_X[i] += Settings.Game_Speed;
                    }
                }
            }

            pbCanvas.Invalidate();

        }

        private void Form1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W && Settings.Falling == 0)
            {
                Settings.Ypos -= 30;
                Settings.Falling += 17;
            }
            if (e.KeyCode == Keys.A)
            {
                if (Settings.Facing == "L")
                {
                    for (int i = 0; i < Arena.Building_Count; i++)
                    {
                        Arena.Buildings_X[i] += Settings.Game_Speed;
                    }
                }

                if (Settings.Facing == "R")
                {
                    Settings.Facing = "F";
                }
                else if (Settings.Facing == "F")
                {
                    Settings.Facing = "L";
                }
            }
            if (e.KeyCode == Keys.S && Settings.Falling == 0)
            {
                if (Settings.Ypos > Settings.base_lvl)
                {
                    Settings.Ypos += 10;
                }
            }
            if (e.KeyCode == Keys.D)
            {
                if (Settings.Facing == "R")
                {
                    for (int i = 0; i < Arena.Building_Count; i++)
                    {
                        Arena.Buildings_X[i] -= Settings.Game_Speed;
                    }
                }

                if (Settings.Facing == "L")
                {
                    Settings.Facing = "F";
                }
                else if (Settings.Facing == "F")
                {
                    Settings.Facing = "R";

                }
            }
        }


        private void pbCanvas_Click(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;

            canvas.FillRectangle(Brushes.SaddleBrown,
                    new Rectangle(Arena.Floor[0], Arena.Floor[1], Arena.Floor[2], Arena.Floor[3]));

            for (int i = 0; i < Arena.Building_Count; i++)
            {
                canvas.FillRectangle(Brushes.Red,
                        new Rectangle(Arena.Buildings_X[i], Arena.Buildings_Y[i], Arena.Buildings_Width[i], Arena.Buildings_Heigth[i]));
            }


            canvas.FillEllipse(Brushes.ForestGreen,
                    new Rectangle(Settings.Xpos,
                                  Settings.Ypos,
                                  /*Width*/ 50, /*Heigth*/ 50));

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Default_Game
{
    class Collision_Detector
    {
        public Collision_Detector(int Y, int X)
        {
            Settings.Y_Up_Distance[1] = 2000000000;

            for (int i = 0; i < Arena.Building_Count; i++) // && Y >=  Arena.Buildings_Y[i] - 10
            {
                if (X > Arena.Buildings_X[i] && X < Arena.Buildings_X[i] + Arena.Buildings_Width[i] && 60 >  (Y - Arena.Buildings_Y[i]) && Settings.Falling <= 10) //&& Y >= Arena.Buildings_Y[i] && Y <= Arena.Buildings_Width[i] + Arena.Buildings_Y[i]
                {
                    Console.WriteLine("Death" + Y);

                    Settings.Ypos = Arena.Buildings_Y[i] - 25;
                    Settings.Current_Base = i;

                    Settings.Falling = 0;
                }
                /*else if (Y != Settings.base_lvl && Settings.Falling == 0)
                {
                    Settings.Ypos = Settings.base_lvl;

                    Settings.Current_Base = 0;
                }*/
            }

            for (int i = 0; i < Arena.Building_Count; i++)
            {
                if (Settings.Falling == 0 && Settings.Ypos == Arena.Buildings_Y[Settings.Current_Base] - 25)
                {
                    Settings.Current_Base = i;
                    break;
                }
                else if (Settings.Falling == 0) Settings.Current_Base = -1;
            }

            if (Settings.Current_Base == -1 && Settings.Falling == 0) Settings.Ypos = Settings.base_lvl;

        }
    }
}

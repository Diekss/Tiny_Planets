using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Default_Game
{
    class Settings
    {
        public static int Xpos { get; set; }
        public static int Ypos { get; set; }
        public static int base_lvl { get; set; }
        public static int Game_Speed { get; set; }
        public static int Falling { get; set; }
        public static string Facing { get; set; }

        public static int[] Y_Up_Distance { get; set; }
        public static int[] X_Up_Distance { get; set; }
        public static int[] Y_Down_Distance { get; set; }
        public static int[] X_Down_Distance { get; set; }
        public static int Current_Base { get; set; }

        public Settings()
        {
            base_lvl = 225;
            Xpos = 350;
            Ypos = base_lvl;
            Game_Speed = 5;
            Falling = 0;
            Facing = "F";

            Y_Up_Distance = new int[2];
            X_Up_Distance = new int[2];
            Y_Down_Distance = new int[2];
            X_Down_Distance = new int[2];
            Current_Base = 0;
        }
    }
}

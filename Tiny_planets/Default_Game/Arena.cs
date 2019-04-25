using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Default_Game
{
    class Arena
    {
        public static int Building_Count { get; set; }
        public static int[] Buildings_X { get; set; }
        public static int[] Buildings_Y { get; set; }
        public static int[] Buildings_Heigth { get; set; }
        public static int[] Buildings_Width { get; set; }
        public static int[] Floor { get; set; }

        public Arena()
        {
            Building_Count = 1;
            Buildings_X = new int[Building_Count];
            Buildings_Y = new int[Building_Count];
            Buildings_Heigth = new int[Building_Count];
            Buildings_Width = new int[Building_Count];
            Floor = new int[4];

            Floor = new int[] { 0, Settings.base_lvl + 50, 1050, 200 };
            Buildings_X = new int[] { 600 };
            Buildings_Y = new int[] { 245 };
            Buildings_Width = new int[] { 200 };
            Buildings_Heigth = new int[] { 30 };
        }
    }
}

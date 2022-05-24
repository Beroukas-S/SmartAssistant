using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartAssistant
{
    static class Program
    {
        public static Boolean plintRoux = false;
        public static Boolean plintPiat = false;
        public static Boolean klimatismos = false;
        public static Boolean kafstiras = false;
        public static Boolean thermos = false;
        public static Boolean tv = false;
        public static Boolean radio = false;
        public static Boolean sittinglights = false;
        public static Boolean kitchenlights = false;
        public static Boolean bedlights = false;
        public static Boolean bathlights = false;
        public static int foodbowl = 80;
        public static int waterbowl = 40;
        public static int food = 1;
        public static int water = 1;
        public static Boolean casual = true;
        public static Boolean sport = true;
        public static Boolean boots = true;
        public static Boolean formal = true;
        public static Boolean football = true;
        public static Boolean basketball = false;
        public static int info = 0;
        public static Boolean zimia = false;

        public static string[,] dayPlan = new string[20, 5]; //test
        public static string[] reminders = new string[5];



        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            for (int i = 0; i < 20; i++) //test
            {
                for (int j = 0; j < 5; j++)
                {
                    dayPlan[i, j] = "";
                }
            }
            for (int i = 0; i < 5; i ++)
            {
                reminders[i] = "";
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace musicApp
{
    static class Program
    {
        public static bool DebugMode = true;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        [STAThread]
        static void Main()
        {
            if (DebugMode) { Console.WriteLine("Hello and welcome to debug mode of the Slap My Meat Audio Mixer"); }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Timeline());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace musicApp.Types.UIElements.WindowManager
{
    public class DesktopEnvironment
    {
        //Store all of the windows in a single object!!!
        public List<Window> windows = new List<Window>();

        public bool WindowExists(Window window)
        {
            return windows.Any(t => t == window);
        }

        public Window AddWindow(Window window)
        {
            if (WindowExists(window))
            {
                if (Program.DebugMode) { Console.WriteLine("Window already exists not needed to create a new window with the name of: " + window.WindowTitle); }
                return null;
            }
            else
            {
                //Create the window then return it
                windows.Add(window);
                if (Program.DebugMode) { Console.WriteLine("A new Window has been sucessfully created!: " + window.WindowTitle); }
                return windows.Find(t => t == window);
            }
        }

        public void RemoveWindow(Window window)
        {
            if (!WindowExists(window))
            {
                if (Program.DebugMode) { Console.WriteLine("That window doesn't exist please try again!"); }
            }
            else
            {
                //Remove the window
                windows.Remove(window);
                if (Program.DebugMode) { Console.WriteLine("That window has now been removed!!"); }
            }
        }
    }
}

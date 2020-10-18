using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace musicApp
{
    public class storeMusic
    {
        public static string filePath = Path.Combine(Directory.GetCurrentDirectory(), "musicFiles");

        //The dumb class to store music that is inputed into this machine manually
        public static void CheckFirst()
        {
            if (!Directory.Exists(filePath))
            {
                Directory.CreateDirectory(filePath);
                if (Program.DebugMode) { Console.WriteLine("Directory doesnt exist for music so creating..."); }
            }
            else
            {
                if (Program.DebugMode) { Console.WriteLine("Directory already exists!!!"); }
            }
        }

        public static void AddMusicFile(string path)
        {
            CheckFirst();
            string newLocation = Path.Combine(filePath, Path.GetFileName(path));
            if (File.Exists(path) && !File.Exists(newLocation))
            {
                //Move the file to the filePath
                File.Copy(path, newLocation);
                if (Program.DebugMode) { Console.WriteLine("The Music file has been moved to this location: " + newLocation + " From " + path); }
            }
            else
            {
                if (Program.DebugMode) { Console.WriteLine("Generally this file doesnt exist!!!"); }
            }
        }
    }
}

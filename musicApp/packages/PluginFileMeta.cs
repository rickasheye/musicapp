using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace musicApp.packages
{
    public class PluginFileMeta
    {
        //This is the dedicated plugin file to launch from
        public string filePath = "no path";
        public float version = 0.1f;
        public string fileName = "untitled";

        //If the application is ever updated try to update the version number
        public static void SaveFile(string filePath, PluginFileMeta metaFile)
        {
            if (Directory.Exists(Path.GetDirectoryName(filePath)))
            {
                //Directory exists continue
                if (File.Exists(filePath))
                {
                    //File already exists so warn the user for overwrite
                    if (Program.DebugMode) { Console.WriteLine("Overwriting the existing metadata file!"); Console.WriteLine("at: " + filePath); }
                }
                else
                {
                    if (Program.DebugMode) { Console.WriteLine("Meta data file doesnt exist???"); }
                }

                File.WriteAllText(filePath, JsonConvert.SerializeObject(metaFile));
            }
            else
            {
                //The directory doesnt exist so exit!!!
                if (Program.DebugMode) { Console.WriteLine("Exiting to write the file as the directory doesnt exist!!!"); }
            }
        }

        public static PluginFileMeta LoadFile(string filePath)
        {
            if (Directory.Exists(Path.GetDirectoryName(filePath)))
            {
                //Directory exists so load the file
                if (File.Exists(filePath))
                {
                    //The file also exists too!!
                    if (Program.DebugMode) { Console.WriteLine("File exist at: " + filePath + "so loading..."); }
                    PluginFileMeta metaData = JsonConvert.DeserializeObject<PluginFileMeta>(File.ReadAllText(filePath));
                    return metaData;
                }
                else
                {
                    if (Program.DebugMode) { Console.WriteLine("This file doesnt exist cancelling..."); }
                    return null;
                }
            }
            else
            {
                if (Program.DebugMode) { Console.WriteLine("The directory for this plugin doesnt exist???"); }
                return null;
            }
        }

        public void WriteVersion(float newVersion)
        {
            version = newVersion;
        }

        public void WriteName(string newName)
        {
            fileName = newName;
        }

        public void WriteFilePath(string newPath)
        {
            filePath = newPath;
        }
    }
}

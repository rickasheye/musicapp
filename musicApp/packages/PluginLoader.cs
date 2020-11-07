using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace musicApp.packages
{
    public class PluginLoader
    {
        List<Plugin> plugins = new List<Plugin>();
        public string pluginDirectory = Path.Combine(Environment.CurrentDirectory, "plugins");

        //This class is responsible for loading all of the plugins and compiling them to a application usable standard!!!
        public void LoadPlugins() {
            //Find the directory and if it doesnt exist create it!
            if(pluginDirectory == null || pluginDirectory == "")
            {
                if (Program.DebugMode) { Console.WriteLine("Plugin directory doesnt exist creating..."); }
                pluginDirectory = Path.Combine(Directory.GetCurrentDirectory(), "/plugins");
                LoadPlugins();
            }
            else
            {
                //Successfully found a folder
                if (Directory.Exists(pluginDirectory))
                {
                    //The Directory exists!
                    if (Program.DebugMode) { Console.WriteLine("Found plugin directory!!!"); }
                    //Check if the sample exists and if not dont create it if its been deleted
                    string metaBoolean = Program.metaFile.getString("awarePluginSampleExists");
                    if (metaBoolean == "")
                    {
                        //It doesnt exist create it.
                        if (Program.DebugMode) { Console.WriteLine("The Sample program doesnt exist so creating..."); }
                        string sampleDirectory = Path.Combine(pluginDirectory, "Sample");
                        if (!Directory.Exists(sampleDirectory))
                        {
                            //Create it
                            Directory.CreateDirectory(sampleDirectory);
                        }
                        //I know i shouldnt but...
                        string sampleMeta = Path.Combine(sampleDirectory, "plugin.meta");
                        if (!File.Exists(sampleMeta))
                        {
                            PluginFileMeta metaFileSample = new PluginFileMeta();
                            metaFileSample.version = Program.programVersion;
                            metaFileSample.fileName = "Sample";
                            metaFileSample.filePath = sampleDirectory;
                            PluginFileMeta.SaveFile(sampleMeta, metaFileSample);
                        }
                        Program.metaFile.writeString("awarePluginSampleExists", "TRUE", true);
                        if (Program.DebugMode) { Console.WriteLine("Finished creating sample program.. and blocked it off!"); }
                    }
                    if (Directory.GetFiles(pluginDirectory).Length <= 0) { return; }
                    foreach(string m in Directory.EnumerateFiles(pluginDirectory))
                    {
                        LoadPlugin(m);
                    }
                }
                else
                {
                    if (Program.DebugMode) { Console.WriteLine("The plugin directory doesnt exist so try again!!!"); }
                    Directory.CreateDirectory(pluginDirectory);
                    LoadPlugins();
                }
            }
        }

        //Load a plugin!!!
        public void LoadPlugin(string filePath)
        {
            //Load an individual plugin!!!

            /**
             * Finding the meta data file
             * and composing it
             **/
            PluginFileMeta metaFileSaved = PluginFileMeta.LoadFile(Path.Combine(filePath, "plugin.meta"));
            if(metaFileSaved != null)
            {
                //The meta file is valid
                if(metaFileSaved.fileName == "Sample")
                {
                    string metaBoolean = Program.metaFile.getString("awarePluginSample");
                    if (metaBoolean.Contains("FALSE") || metaBoolean == "")
                    {
                        MessageBox.Show("The Sample plugin is still avaliable in the plugins folder.\nFinish this message box to disable this reminder.");
                        Program.metaFile.writeString("awarePluginSample", "TRUE", true);
                    }
                }
                else
                {
                    if(metaFileSaved.version >= Program.programVersion)
                    {
                        if (Program.DebugMode) { Console.WriteLine("Its recommended to find a new update of this program since this plugin reads a higher version number, and might not work correctly with an older version."); }
                    }
                    else if(metaFileSaved.version < Program.programVersion)
                    {
                        if (Program.DebugMode) { Console.WriteLine("This plugin's version number is less than this applications version number indicating that this plugin is older than this program."); }
                    }

                    //Load this plugin into matrix!!!!
                    if (!checkPluginExists(new Plugin(metaFileSaved.fileName)))
                    {
                        if (Program.DebugMode) { Console.WriteLine("Adding plugin"); }
                        Plugin newPlugin = new Plugin(metaFileSaved.fileName, metaFileSaved.filePath, true);
                        plugins.Add(newPlugin);
                    }
                    else
                    {
                        if (Program.DebugMode) { Console.WriteLine("That plugin already is registered!"); }
                    }
                }
            }
            else
            {
                if (Program.DebugMode) { Console.WriteLine("The program meta file for this plugin seems to be missing"); }
            }
        }

        //arghhh we gotta check if the plugin exists or not
        public bool checkPluginExists(Plugin plugin)
        {
            bool exists = false;
            foreach(Plugin m in plugins)
            {
                if(m.pluginname == plugin.pluginname)
                {
                    exists = true;
                }
            }
            return exists;
        }
    }
}

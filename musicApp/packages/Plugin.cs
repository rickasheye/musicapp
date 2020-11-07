using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace musicApp.packages
{
    public class Plugin
    {
        //A plugin
        public string pluginname;
        public string pluginpath;
        public string plugincode;
        public bool pluginLoaded = false;

        /// <summary>
        /// Creates a new plugin instance.
        /// </summary>
        /// <param name="name">The name of the plugin</param>
        /// <param name="pluginpath">The path of the plugin</param>
        /// <param name="pluginloaded">If the plugin is loaded or not</param>
        public Plugin(string name, string pluginpath, bool pluginloaded)
        {
            this.pluginname = name;
            this.pluginpath = pluginpath;
            this.pluginLoaded = pluginloaded;
        }

        public Plugin(string name, string pluginpath)
        {
            this.pluginname = name;
            this.pluginpath = pluginpath;
            this.pluginLoaded = false;
        }

        public Plugin(string name)
        {
            this.pluginname = name;
            if (Program.DebugMode) { Console.WriteLine("Its not recommended to actually not use a pluginpath as it makes it useless!"); }
            this.pluginLoaded = false;
        }

        public void RunScript(string[] script)
        {
            for(int i = 0; i < script.Length; i++)
            {
                evalCommand(script[i]);
            }
        }

        public static void evalCommand(string command)
        {
            string[] args = command.Split(' ');
            switch (args[0].ToUpper())
            {
                case "STOP":
                    Environment.Exit(0);
                    break;
                case "ANSWER":
                    if (Program.DebugMode) { Console.WriteLine(String.Concat(args.Where(arg => !arg.Contains("ANSWER")))); }
                    break;
                case "DEBUG":
                    switch (args[1].ToLower())
                    {
                        case "TRUE":
                        case "true":
                            //TRUE
                            Program.DebugMode = true;
                            Program.metaFile.debugMode = true;
                            break;
                        case "FALSE":
                        case "false":
                            //FALSE
                            Program.DebugMode = false;
                            Program.metaFile.debugMode = false;
                            break;
                    }
                    break;
                case "IF":
                    //get the firstVarName
                    string varName1 = args[1].ToLower();
                    string condition = args[2].ToLower();
                    string varName2 = args[3].ToLower();
                    switch (condition)
                    {
                        case "==":
                            //Equals condition
                            if(varName1 == varName2)
                            {
                                //complete
                                evalCommand(string.Join(" ", args).Replace("IF " + varName1 + " " + condition + " " + varName2, ""));
                            }
                            else
                            {
                                if (Program.DebugMode) { Console.WriteLine("An if statement was executed for which it resulted to be incomplete!"); }
                            }
                            break;
                        case "!=":
                            //Not Equal to Condition
                            if(varName1 != varName2)
                            {
                                //complete
                                evalCommand(string.Join(" ", args).Replace("IF " + varName1 + " " + condition + " " + varName2, ""));
                            }
                            else
                            {
                                if (Program.DebugMode) { Console.WriteLine("An if statement was executed for which it resulted to be incomplete!"); }
                            }
                            break;
                        case "poggers":
                            if (Program.DebugMode) { Console.WriteLine("We all know yes poggers but this is not the way to make music!"); }
                            break;
                        default:
                            if (Program.DebugMode) { Console.WriteLine("This condition is not supported: " + condition); }
                            break;
                    }
                    break;
                case "FOR":
                    bool number = int.TryParse(args[1], out int n);
                    if (number)
                    {
                        for(int i = 0; i < n; i++)
                        {
                            evalCommand(string.Concat(string.Join(" ", args).Replace("", "FOR " + args[1])));
                        }
                    }
                    else
                    {
                        if (Program.DebugMode) { Console.WriteLine("The number on this for statement is not a number its a string: " + args[1]); }
                    }
                    break;
                case "SETVAR":
                case "SET":
                case "VAR":
                    //Set a variable
                    if(args[1] != null)
                    {
                        if(args[2] != null)
                        {
                            //execute the code.
                            Program.metaFile.writeString(args[1], args[2], true);
                        }
                        else
                        {
                            if (Program.DebugMode) { Console.WriteLine("You are missing the second argument for which is the value to assign to: " + args[1] + " did not assign"); }
                        }
                    }
                    else
                    {
                        if (Program.DebugMode) { Console.WriteLine("You need a variable name and a variable value to use this!"); }
                    }
                    break;
                case "REPEAT":
                    if (args[1] != null)
                    {
                        evalCommand(String.Concat(args.Where(arg => !arg.Contains("REPEAT"))));
                    }
                    else
                    {
                        if (Program.DebugMode) { Console.WriteLine("Repeat Command needs a command to repeat with."); }
                    }
                    break;
            }
        }
    }
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace musicApp.Types
{
    public class ProgramMeta
    {
        //Another fileType uggggghhhh!!!
        //This saves program data for future reference

        /// <summary>
        /// Dictionary object to store data like enviroment variables to be used globally throughout the code using Program.metaFile
        /// </summary>
        public Dictionary<string, string> dictionary = new Dictionary<string, string>();

        /// <summary>
        /// The outstanding debug variable to really determine if the program is in debug mode or not.
        /// </summary>
        public bool debugMode = false;

        /// <summary>
        /// Returns a string from the dictionary acting as environment variables
        /// </summary>
        /// <param name="name">The name of the variable in the dictionary</param>
        /// <returns>a value according to the name given in the dictionary</returns>
        public string returnString(string name)
        {
            string returnableString = "";
            foreach(string m in dictionary.Keys)
            {
                if(m == name)
                {
                    returnableString = dictionary[m];
                }
            }
            return returnableString;
        }

        /// <summary>
        /// Returns an integer from the dictionary that is acting as environment variables.
        /// </summary>
        /// <param name="name">The name of the variable in the dictionary</param>
        /// <returns>an integer from the dictionary according to the given name.</returns>
        public int returnInt(string name)
        {
            int returnableInteger = 0;
            foreach(string m in dictionary.Keys)
            {
                if(m == name)
                {
                    returnableInteger = int.Parse(dictionary[m]);
                }
            }
            return returnableInteger;
        }

        /// <summary>
        /// Checks if the variable exists in the dictionary.
        /// </summary>
        /// <param name="name">A filter to use to check if the variable name exists within the dictionary</param>
        /// <returns>a boolean to condition whether it exists or not.</returns>
        public bool entryExists(string name)
        {
            bool entryExists = false;
            foreach(string m in dictionary.Keys)
            {
                if(m == name)
                {
                    entryExists = true;
                }
            }
            return entryExists;
        }

        /// <summary>
        /// Writes a string to the dictionary that is used as a replacement enviromental value.
        /// </summary>
        /// <param name="name">what value name to write</param>
        /// <param name="value">what value to write with the dictionary entry</param>
        /// <param name="overwrite">Whether to overwrite an existing entry in the dictionary</param>
        public void writeString(string name, string value, bool overwrite)
        {
            if (!entryExists(name))
            {
                if (Program.DebugMode) { Console.WriteLine("Entry doesnt exist so this is the perfect condition to write an entry!!!"); }
                dictionary.Add(name, value);
            }
            else
            {
                if (overwrite == false)
                {
                    if (Program.DebugMode) { Console.WriteLine("Entry does exist so cancelling!!!"); }
                    return;
                }
                else
                {
                    //Overwrite it
                    if (Program.DebugMode) { Console.WriteLine("Demanded to overwrite this so overwriting..."); }
                    removeString(name);
                    //Once we remove it we want to call this event again to come around...
                    writeString(name, value, false);
                }
            }
        }

        /// <summary>
        /// Writes an integer to the dictionary... but converts itself to string anyway
        /// </summary>
        public void writeInt(string name, int value, bool overwrite)
        {
            writeString(name, value.ToString(), overwrite);
        }

        public void writeInt(string name, int value)
        {
            writeString(name, value.ToString(), false);
        }

        /// <summary>
        /// Remove a string from the dictionary...
        /// </summary>
        /// <param name="name">The name of the value where we should remove it from.</param>
        public void removeString(string name)
        {
            if (entryExists(name))
            {
                if (Program.DebugMode) { Console.WriteLine(name + " exists! so removing it because it was called..."); }
                dictionary.Remove(name);
            }
            else
            {
                if (Program.DebugMode) { Console.WriteLine("nothing to overwrite or remove since it doesnt exist!"); }
            }
        }

        /// <summary>
        /// Get a string and return it from the dictionary
        /// </summary>
        /// <param name="name">What variable name we should use from the dictionary.</param>
        /// <returns>the string that it if it finds in the dictionary</returns>
        public string getString(string name)
        {
            //Find the string and return it
            string findString = "";
            foreach(string m in dictionary.Keys)
            {
                if(m == name)
                {
                    findString = name;
                }
            }
            return findString;
        }

        /// <summary>
        /// Same as getString() but instead it returns in an integer format if possible.
        /// </summary>
        /// <param name="name">The name of the variable</param>
        /// <returns>a integer from the dictionary if it exists!</returns>
        public int getInt(string name)
        {
            return int.Parse(getString(name));
        }

        /// <summary>
        /// Saves the Program Meta File.
        /// </summary>
        /// <param name="filePath">Where to save the file.</param>
        public void SaveData(string filePath)
        {
            if (!File.Exists(filePath))
            {
                if (Program.DebugMode)
                {
                    Console.WriteLine("This program metadata file doesnt exist!");
                }
                CreateData(filePath);
                SaveData(filePath);
            }
            else
            {
                if (Program.DebugMode) { Console.WriteLine("Saving program metadata file!"); }
                //Pretty much this is where we want to save the file
                File.WriteAllText(filePath, JsonConvert.SerializeObject(this));
                if (Program.DebugMode) { Console.WriteLine("The file has been saved!"); }
            }
        }

        /// <summary>
        /// Loads the Program Meta File.
        /// </summary>
        /// <param name="filePath">Where to load from.</param>
        public void LoadData(string filePath)
        {
            if (!File.Exists(filePath))
            {
                if (Program.DebugMode)
                {
                    Console.WriteLine("This program metadata file doesnt exist!");
                }
            }
            else
            {
                if (Program.DebugMode) { Console.WriteLine("Loading program metadata file!"); }
                //Pretty much this is where we want to load the file
                ProgramMeta metaFile = JsonConvert.DeserializeObject<ProgramMeta>(File.ReadAllText(filePath));
                Program.DebugMode = metaFile.debugMode;
                debugMode = metaFile.debugMode;
                dictionary = metaFile.dictionary;
                if (Program.DebugMode) { Console.WriteLine("Finished loading program meta file!!"); }
            }
        }

        /// <summary>
        /// Creates a Program Meta File NOT USED FOR OTHER PURPOSES OTHER THAN IN THIS CLASS!!!
        /// </summary>
        /// <param name="filePath">Where to create the file.</param>
        public void CreateData(string filePath)
        {
            //Hopefully this file will be unused!!!
            //Sad :( it was used...
            if (!File.Exists(filePath))
            {
                //Then the file doesnt exist create
                if (Program.DebugMode) { Console.WriteLine("Program meta data is being created!"); }
                File.CreateText(filePath);
            }
            else
            {
                if (Program.DebugMode) { Console.WriteLine("The file already exists but requested to create so deleting then recreating"); }
                File.Delete(filePath);
                CreateData(filePath);
            }
        }
    }
}

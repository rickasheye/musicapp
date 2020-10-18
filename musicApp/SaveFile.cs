using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace musicApp
{
    public class SaveFile
    {

        [JsonProperty("MusicClasses")]
        public MusicBlock[] blocks;

        public static SaveFile LoadFromFile(string path)
        {
            using(var sr = new StreamReader(path))
            {
                if (Program.DebugMode) { Console.WriteLine("Deserializing file in: " + path); }
                return JsonConvert.DeserializeObject<SaveFile>(sr.ReadToEnd());
            }
        }

        public void SaveToFile(string path)
        {
            using(var sw = new StreamWriter(path))
            {
                sw.Write(JsonConvert.SerializeObject(this));
                if (Program.DebugMode == true) { Console.WriteLine("Saved file in: " + path); }
            }
        }
    }
}

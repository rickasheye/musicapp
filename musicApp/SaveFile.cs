using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace musicApp
{
    class SaveFile
    {

        [JsonProperty("MusicClasses")]
        internal MusicBlock blocks;

        public static SaveFile LoadFromFile(string path)
        {
            using(var sr = new StreamReader(path))
            {
                return JsonConvert.DeserializeObject<SaveFile>(sr.ReadToEnd());
            }
        }

        public void SaveToFile(string path)
        {
            using(var sw = new StreamWriter(path))
            {
                sw.Write(JsonConvert.SerializeObject(this));
            }
        }
    }
}

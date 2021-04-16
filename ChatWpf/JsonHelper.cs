using ChatWpf.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatWpf
{
    public class JsonHelper
    {
        static public void JsonSerialize(string filename, List<User> users)
        {
            var serializer = new JsonSerializer();
            if (!filename.Contains(".json"))
            {
                filename = filename + ".json";
            }
            if (filename.Contains(".json"))
            {
                using (var sw = new StreamWriter(filename))
                {
                    using (var jw = new JsonTextWriter(sw))
                    {
                        jw.Formatting = Newtonsoft.Json.Formatting.Indented;
                        serializer.Serialize(jw, users);
                    }
                }
            }
        }
        static public List<User> JsonDeserialize(string filename)
        {
            User[] userz = null;
            var serializer = new JsonSerializer();

            using (var sr = new StreamReader(filename))
            {
                using (var jr = new JsonTextReader(sr))
                {
                    userz = serializer.Deserialize<User[]>(jr);
                    
                }
            }
            return userz.ToList();
        }
    }
}


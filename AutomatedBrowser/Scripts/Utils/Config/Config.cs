using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Text;

namespace AutomatedBrowser.Scripts.Utils
{
    public class Config
    {
        private JObject json;
        private string location;
        public Config(string dir) {
            location = dir;
            json = JObject.Parse(File.ReadAllText(location + "config.json"));
        }
        public string GetString(string property)
        {
            return (string)json[property];
        }
        public int GetInt(string property)
        {
            return (int)json[property];
        }
        public void SetProperty(string property, string value)
        {
            json[property] = value;
        }
        public void SetProperty(string property, int value)
        {
            json[property] = value;
        }
        public void CreateField()
        {

        }
        public void Save()
        {
            using (StreamWriter file = File.CreateText(location + "config.json"))
            {
                using (JsonTextWriter writer = new JsonTextWriter(file))
                {
                    json.WriteTo(writer);
                }
            }
        }
        public void Load()
        {
            json = JObject.Parse(File.ReadAllText(location + "config.json"));
        }
    }
}

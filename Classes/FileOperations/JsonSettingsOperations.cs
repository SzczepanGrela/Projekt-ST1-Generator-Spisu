using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.IO;
using Generator_Spisu.Classes;

namespace JsonFileOperations
{
   

    public class Attribute
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public bool AllowNull { get; set; }

        public List<string> EnumValues { get; set; }

        public int ColumnWidth { get; set; }

        public bool IsBold { get; set; }
    }

 


    public class Config
    {
        public List<Attribute> Attributes { get; set; }

        //public string HeaderFontSize { get; set; }


    }

    public class JsonConfigLoader
    {
        public Config LoadConfig(string filePath)
        {
            var jsonString = File.ReadAllText(filePath);
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            return JsonSerializer.Deserialize<Config>(jsonString, options);
        }

        public void SaveConfig(Config config, string filePath)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true // makes the json file more readable
            };
            var jsonString = JsonSerializer.Serialize(config, options);
            File.WriteAllText(filePath, jsonString);
        }


    }

    

}

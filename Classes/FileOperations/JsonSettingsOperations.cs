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
    }

    public class JsonSettingsOperations
    {
        
        public List<string> ColumnWidths { get; set; }
        public string HeaderFontSize { get; set; }
        public string HeaderFontColor { get; set; }
        public List<string> EnumValues { get; set; }
        public List<Attribute> Attributes { get; set; }

        public List<string> GetColumnHeaders()
        {
            return Attributes.ConvertAll(x => x.Name);
        }
    }



    public class Config
    {
        public JsonSettingsOperations settings { get; set; }

        
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
    }

    

}

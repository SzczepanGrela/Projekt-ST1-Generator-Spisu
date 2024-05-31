using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.IO;

namespace JsonAttributeSettingss
{
    public class JsonAttributeSettings
    {
        public List<string> ColumnHeaders { get; set; }
        public List<string> ColumnWidths { get; set; }
    }

    public class Config
    {
        public List<string> Exclude { get; set; }
        public JsonAttributeSettings Settings { get; set; }
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

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Generator_Spisu.Classes.FileOperations;
using Generator_Spisu.Classes;
using JsonFileOperations;
using System.Windows.Forms;
using Generator_Spisu.Enums;
using DocumentFormat.OpenXml.ExtendedProperties;


namespace Generator_Spisu.Classes
{
    internal static class AttributeList
    {

        private static List<ProductAttribute> _attributes;

        public delegate void AttributesChangedEventHandler(object sender, EventArgs e);
        public static event AttributesChangedEventHandler AttributesChanged;

        static AttributeList()
        {
            _attributes = new List<ProductAttribute>();
        }

        public static void AddAttribute(ProductAttribute attribute)
        {
            _attributes.Add(attribute);
            OnAttributesChanged(EventArgs.Empty);
        }

        public static void SetAttributes(List<ProductAttribute> attributes)
        {
            _attributes = attributes;
            OnAttributesChanged(EventArgs.Empty);

        }




        public static void RemoveAttribute(ProductAttribute attribute)
        {
            _attributes.Remove(attribute);
            OnAttributesChanged(EventArgs.Empty);
        }

        public static void RemoveAttribute(string name)
        {
            _attributes.RemoveAll(x => x.Name == name);
            OnAttributesChanged(EventArgs.Empty);
        }


        public static void SetAttributesFromSettings()
        {
            try
            {
                JsonConfigLoader loader = new JsonConfigLoader();
                Config config = loader.LoadConfig("../../Settings/Attributes.json");
                List<JsonFileOperations.Attribute> tempAttributes = config.Attributes;

                List<ProductAttribute> productAttributes = new List<ProductAttribute>();
                foreach (JsonFileOperations.Attribute tempAttribute in tempAttributes)
                {
                    ProductAttribute productAttribute = new ProductAttribute(tempAttribute.Name, (AttributeType)Enum.Parse(typeof(AttributeType), tempAttribute.Type), tempAttribute.AllowNull, tempAttribute.EnumValues, tempAttribute.ColumnWidth, tempAttribute.IsBold);
                    productAttribute.EnumValues = tempAttribute.EnumValues;
                    productAttributes.Add(productAttribute);
                }
                _attributes = productAttributes;
            }
            catch (Exception e)
            {
                MessageBox.Show("Błąd wczytywania atrybutów z pliku: " + e.Message);
            }

        }

        public static void SetAttributesToSettings()
        {
            JsonConfigLoader loader = new JsonConfigLoader();
            Config config = new Config();

            config.Attributes = new List<JsonFileOperations.Attribute>();

            foreach (ProductAttribute tempAttribute in _attributes)
            {
                JsonFileOperations.Attribute newAttribute = new JsonFileOperations.Attribute();
                newAttribute.Name = tempAttribute.Name;
                newAttribute.Type = tempAttribute.Type.ToString();
                newAttribute.AllowNull = tempAttribute.CanBeEmpty;
                newAttribute.ColumnWidth = tempAttribute.ColumnWidth;
                newAttribute.IsBold = tempAttribute.IsBold;

                if (tempAttribute.EnumValues != null)
                {
                    newAttribute.EnumValues = tempAttribute.EnumValues;
                }
                else
                {
                    newAttribute.EnumValues = new List<string>();
                }

                config.Attributes.Add(newAttribute);
                
            }

            try
            {
                loader.SaveConfig(config, "../../Settings/Attributes.json");
            }
            catch (Exception e)
            {
                MessageBox.Show("Błąd zapisu atrybutów do pliku: " + e.Message);
            }



        }





        public static List<ProductAttribute> GetAttributes()
        {
            return _attributes;
        }



        private static void OnAttributesChanged(EventArgs e)
        {
            AttributesChanged?.Invoke(null, e);

        }



        internal static List<string> GetAttributesToCsv()
        {
            List<string> CsvLines = new List<string>();


            foreach (ProductAttribute attribute in _attributes)
            {
                string enumValues = "";
                if (attribute.EnumValues != null)
                {
                    foreach (string value in attribute.EnumValues)
                    {
                        enumValues += value + ",";
                    }
                }


                string csvAttribute = "*" + attribute.Name + ";" + attribute.Type + ";" + attribute.CanBeEmpty + ";" + enumValues + ";" + attribute.ColumnWidth + ";" + attribute.IsBold;

                CsvLines.Add(csvAttribute);
            }

            return CsvLines;
        }

        internal static void SetAttributesFromCsv(List<string> lines)
        {


            List<ProductAttribute> productAttributes = new List<ProductAttribute>();

            foreach (string line in lines)
            {
                string[] values = line.Split(';');
                string[] enumValues = values[5].Split(',');

                int columnWidth = values[4] == "" ? 150 : int.Parse(values[4]);

                bool isBold = values[5] == "" ? false : bool.Parse(values[5]);

                ProductAttribute attribute = new ProductAttribute(values[0], (AttributeType)Enum.Parse(typeof(AttributeType), values[1]), bool.Parse(values[2]), enumValues.ToList(), columnWidth, isBold);
                productAttributes.Add(attribute);
            }

            SetAttributes(productAttributes);

        }

        internal static List<string> GetAttributeNames()
        {
            return _attributes.Select(x => x.Name).ToList();
        }



        public static List<int> GetColumnWidths()
        {
            return _attributes.Select(x => x.ColumnWidth).ToList();
        }


    }
}

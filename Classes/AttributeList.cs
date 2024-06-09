using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Generator_Spisu.Classes.FileOperations;
using Generator_Spisu.Classes;
using JsonFileOperations;



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


        public static void SetAttributesFromFile()
        {
            
            
        }


        public static List<ProductAttribute> GetAttributes()
        {
            return _attributes;
        }



        private static void OnAttributesChanged(EventArgs e)
        {
            AttributesChanged?.Invoke(null, e);
            SaveAttributesToFile("attributes.txt"); // Zapis do pliku po każdej zmianie
        }

        private static void SaveAttributesToFile(string filePath)
        {
           
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generator_Spisu.Classes
{
    internal static class AttributeList
    {

        private static List<ProductAttribute> _attributes;

         static AttributeList()
        {
            _attributes = new List<ProductAttribute>();
        }

        public static void AddAttribute(ProductAttribute attribute)
        {
            _attributes.Add(attribute);
        }

        public static void RemoveAttribute(ProductAttribute attribute)
        {
            _attributes.Remove(attribute);
        }

        public static void RemoveAttribute(string name)
        {
            _attributes.RemoveAll(x => x.Name == name);
        }



        public static List<ProductAttribute> GetAttributes()
        {
            return _attributes;
        }



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Generator_Spisu.Classes
{
    public class DynamicProduct
    {
        private readonly Dictionary<ProductAttribute, object> _attributes;

        private int _id;


        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public DynamicProduct()
        {
            _attributes = AttributeList.GetAttributes().ToDictionary(attr => attr, _ => (object)null);

            this.Id = ProductList.GetNextId();
        }

        public DynamicProduct(Dictionary<ProductAttribute, object> attributes)
        {
            _attributes = attributes;
            this.Id = ProductList.GetNextId();
        }


        public DynamicProduct(Dictionary<ProductAttribute, object> attributes, int id)
        {
            _attributes = attributes;
            this.Id = id;
        }


        public DynamicProduct(List <string> values) : this()
        {
            var attributes = AttributeList.GetAttributes();
            if (values.Count != attributes.Count)
            {
                throw new ArgumentException("Number of values must match number of attributes");
            }

            for (var i = 0; i < attributes.Count; i++)
            {
                _attributes[attributes[i]] = values[i];
            }
        }
        
          
        

      

        public object GetAttributeValue(ProductAttribute attribute)
        {
            return _attributes.TryGetValue(attribute, out var value) ? value : null;
        }

        public IEnumerable<KeyValuePair<ProductAttribute, object>> GetAllAttributes()
        {
            return _attributes;
        }

        public string ToString()
        {
            var result = new StringBuilder("Product attributes:\n");
            foreach (var kvp in _attributes)     // kvp - key value pair
            {
                result.AppendLine($"{kvp.Key}: {kvp.Value}");
            }
            return result.ToString();
        }


        public string ToCSVline()
        {
            var result = new StringBuilder();

            result.Append($"{Id}");
            foreach (var kvp in _attributes)
            {
                result.Append($";{kvp.Value}");
            }
            return result.ToString();
        }

    }
}
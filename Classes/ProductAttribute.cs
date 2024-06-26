using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Generator_Spisu.Enums;

namespace Generator_Spisu.Classes
{
    public class ProductAttribute
    {

       private string _name;

       private AttributeType _type;

       private bool _canBeEmpty;

        private List<string> _enumValues;


        public ProductAttribute(string name, AttributeType type, bool canBeEmpty, List<string> enumValues)
        {
            _name = name;
            _type = type;
            _canBeEmpty = canBeEmpty;
            _enumValues = enumValues;
           
        }




        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public AttributeType Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public bool CanBeEmpty
        {
            get { return _canBeEmpty; }
            set { _canBeEmpty = value; }
        }

        public List<string> EnumValues
        {
            get { return _enumValues; }
            set { _enumValues = value; }
        }


        public override bool Equals(object obj)   // i override Equals method to compare two attributes
        {
            if (obj is ProductAttribute other)
            {
                return Name == other.Name && Type == other.Type;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode() ^ Type.GetHashCode();
        }

        public override string ToString()
        {
            return $"Nazwa: {Name}, typ: ({Type})";
        }


    

    }

 
}

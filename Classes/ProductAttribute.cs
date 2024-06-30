using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Presentation;
using Generator_Spisu.Enums;

namespace Generator_Spisu.Classes
{
    public class ProductAttribute
    {
        private Guid _id;   // attributes have to be unique despite having the same name, for dictionary reasons

       private string _name;

       private AttributeType _type;

       private bool _canBeEmpty;

        private List<string> _enumValues;

        private int _columnWidth;

        private bool _isBold;


        public ProductAttribute(string name, AttributeType type, bool canBeEmpty, List<string> enumValues, int columnWidth, bool isBold)
        {
            _name = name;
            _type = type;
            _canBeEmpty = canBeEmpty;
            _enumValues = enumValues;
            _id = Guid.NewGuid();
            _columnWidth = columnWidth;
            _isBold = isBold;
           
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

        public bool IsBold
        {
            get { return _isBold; }
            set { _isBold = value; }
        }

        public int ColumnWidth
        {
            get { return _columnWidth; }
            set { _columnWidth = value; }
        }

        public override bool Equals(object obj)   // i override Equals method to compare two attributes
        {
            if (obj is ProductAttribute other)
            {
                return  this._id == other._id;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return _id.GetHashCode(); 
        }

        public override string ToString()
        {
            return $"Nazwa: {Name}, typ: ({Type})";
        }



    }

 
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generator_Spisu.Classes
{
    public class ProductAttribute
    {

       private string _name;

       private Type _type;


        public ProductAttribute(string name, Type type)
        {
            _name = name;
            _type = type;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public Type Type
        {
            get { return _type; }
            set { _type = value; }
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

    public enum Type
    {
        String,
        Int,
        Double,
        DateTime,
        Bool

    }

     



}

using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generator_Spisu.Classes
{
    public abstract class Product
    {
        private int _id;
   

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
     
      


        public Product()
        {
            this._id = 0;
            

        }

        public Product(int id)
        {

            this._id = id;
        }


        public abstract string ToCSVline();

    }
}

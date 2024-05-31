using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generator_Spisu.Classes
{
    public class Product
    {
        public int _id;
        private string _productname;
        private string _type;
        private int _startquantity;
        private string _startvalue;
        private int _comingquantity;
        private string _comingvalue;
        private int _outgoingquantity;
        private string _outgoingvalue;
        private int _warehousequantity;




        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string ProductName
        {
            get { return _productname; }
            set { _productname = value; }
        }

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public int StartQuantity
        {
            get { return _startquantity; }
            set { _startquantity = value; }
        }

        public string StartValue
        {
            get { return _startvalue; }
            set { _startvalue = value; }
        }

        public int ComingQuantity
        {
            get { return _comingquantity; }
            set { _comingquantity = value; }
        }

        public string ComingValue
        {
            get { return _comingvalue; }
            set { _comingvalue = value; }
        }

        public int OutgoingQuantity
        {
            get { return _outgoingquantity; }
            set { _outgoingquantity = value; }
        }

        public string OutgoingValue
        {
            get { return _outgoingvalue; }
            set { _outgoingvalue = value; }
        }

        public int WarehouseQuantity
        {
            get { return _warehousequantity; }
            set { _warehousequantity = value; }
        }


      


        public Product()
        {
            this._id = 0;
            this._productname = "Example Name";
            this._type = "kg";
            this._startquantity = 0;
            this._startvalue = "0";
            this._comingquantity = 0;
            this._comingvalue = "0";
            this._outgoingquantity = 0;
            this._outgoingvalue = "0";
            this._warehousequantity = 0;


        }

        public Product(string name, int startquantity, string startvalue, int comingquantity, string comingvalue, int outgoingquantity, string outgoingvalue, int warehousequantity, string type, int id)
        {
            this._id = id;
            this._productname = name;
            this._type = type;
            this._startquantity = startquantity;
            this._startvalue = startvalue;
            this._comingquantity = comingquantity;
            this._comingvalue = comingvalue;
            this._outgoingquantity = outgoingquantity;
            this._outgoingvalue = outgoingvalue;
            this._warehousequantity = warehousequantity;

        }


        public string ToCSV()
        {
            return this._productname + ";" + this._type + ";" + this._startquantity + ";" + this._startvalue + ";" + this._comingquantity + ";" + this._comingvalue + ";" + this._outgoingquantity + ";" + this._outgoingvalue + ";" + this._warehousequantity;
        }

    }
}

using Generator_Spisu.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Generator_Spisu.UserControls;
using System.Reflection;

namespace Generator_Spisu.UserControls
{
    public partial class DataSlice : UserControl
    {

        private Product originProduct;


        public DataSlice(Product product)
        {
            this.originProduct = product;
            InitializeComponent();
            

            this.Load += new EventHandler(DataSlice_Load);

        }

        public DataSlice()
        {
            this.originProduct = new Product();
            InitializeComponent();
            
            
        }



        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


        public static List <DataSlice> CreateDataSlices(List <Product> ProductList)
        {

            List<DataSlice> DataSlices = new List<DataSlice>();

            foreach(Product product in ProductList)
            {
                DataSlices.Add(new DataSlice(product));
            }


            return DataSlices;

        }


        private void DataSlice_Load(object sender, EventArgs e)
        {
            FillLabels();
        }

        private void FillLabels()
        {

            PropertyInfo[] properties = typeof(Product).GetProperties();

            foreach(Control control in tableLayoutPanel1.Controls)
            {
                if(control is Label)
                {
                    Label label = (Label)control;

                    foreach(PropertyInfo property in properties)
                    {
                        if(label.Name == property.Name)
                        {
                            label.Text = property.GetValue(originProduct).ToString() ?? "";
                        }
                    }
                }
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            ProductList.RemoveProductFromList(originProduct.Id);
            this.Dispose();
        }
    }
}

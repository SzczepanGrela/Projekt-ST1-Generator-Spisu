using DocumentFormat.OpenXml.Presentation;
using DocumentFormat.OpenXml.Spreadsheet;
using Generator_Spisu.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generator_Spisu.UserControls
{
    public partial class DynamicDataDisplaySlice : UserControl
    {
        DynamicProduct originProduct = new DynamicProduct();

        public DynamicDataDisplaySlice()  // used for creating first slice displaying names of attributes
        {

            InitializeComponent();


            List<string> AttributeNames = new List<string>();

            List<ProductAttribute> attributes = AttributeList.GetAttributes();

            foreach (ProductAttribute attribute in attributes)
            {
                AttributeNames.Add(attribute.Name);
            }

            this.DeleteRecordButton.Visible = false;
            this.EditRecordButton.Visible = false;


            


            FillWithValues( AttributeNames, GetDefaultWidths(AttributeNames.Count));
        }



     /*   public DynamicDataDisplaySlice(List<int> widths)
        { 

            InitializeComponent();


            List<string> values = new List<string>();

            List<ProductAttribute> attributes = AttributeList.GetAttributes();

            foreach (ProductAttribute attribute in attributes)
            {
                values.Add(attribute.Name);
            }

            this.ButtonsPanel.Visible = false;

            if (widths == null)
            {
                widths = new List<int>();
                for (int i = 0; i < values.Count; i++)
                {
                    widths.Add(100);
                }
            }

            FillWithValues(widths, values);
        }*/

       




        public DynamicDataDisplaySlice( List<string> values, List<int> widths=null)
        {

            InitializeComponent();

            if(widths == null)
            {
                widths = GetDefaultWidths(values.Count);
            }

            originProduct = new DynamicProduct(values);

            FillWithValues(values, widths);
        }


        public DynamicDataDisplaySlice(DynamicProduct product, List<int> widths=null)
        {
            InitializeComponent();

            originProduct = product;
            List<string> values = ProductToList(product);

            if(widths == null)
            {
                widths = GetDefaultWidths(values.Count);
            }

            FillWithValues(values, widths);

        }

        

        private List<string> ProductToList(DynamicProduct product)
        {

            List<string> values = new List<string>();

            try
            {


                foreach (KeyValuePair<ProductAttribute, object> kvp in product.GetAllAttributes())
                {
                    values.Add(kvp.Value.ToString());
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Problem z konwersją produktu na listę");
            }

            return values;
        }


        private List<int> GetDefaultWidths(int length) 
        {
            List<int> widths = new List<int>();
            for (int i = 0; i < length; i++)
            {
                widths.Add(100);
            }

            return widths;

        }


        private void FillWithValues( List<string> values, List<int> widths)
        {
            
            List<DataDisplayCell> cells = DataDisplayCell.DataDisplayCellsFactory(values, widths);

            foreach (DataDisplayCell cell in cells)
            {
                
                DataDisplayPanel.Controls.Add(cell);    
            }

        }



        List<DynamicDataDisplaySlice> DynamicDataDisplaySliceFactory(List<int> widths)
        {
            if (ProductList.GetProductsCount() < 1)
            {
                MessageBox.Show("Brak produktów do wyświetlenia");
                return null;
            }
            if (widths.Count <= 0)
            {
                MessageBox.Show("Problem przy wczytaniu szerokości kolumn");
                return null;
            }

            List<List<string>> products = ProductList.GetProductLists();

            List<DynamicDataDisplaySlice> dynamicDataDisplaySlices = new List<DynamicDataDisplaySlice>();

            for (int i = 0; i < products.Count; i++)
            {
                DynamicDataDisplaySlice dynamicDataDisplaySlice = new DynamicDataDisplaySlice(products[i], widths);
                dynamicDataDisplaySlice.Show();
                dynamicDataDisplaySlices.Add(dynamicDataDisplaySlice);
            }


            return dynamicDataDisplaySlices;
        }

        private void DeleteRecordButton_Click(object sender, EventArgs e)
        {
            ProductList.RemoveProductFromList(originProduct.Id);
            this.Dispose();
        }

        private void EditRecordButton_Click(object sender, EventArgs e)
        {
            ProductEdit?.Invoke(this, new DynamicProductEventArgs(originProduct));
        }

        public static event DynamicProductEventHandler ProductEdit;

        public delegate void DynamicProductEventHandler(object sender, DynamicProductEventArgs e);

    }

    public class DynamicProductEventArgs : EventArgs
    {
        public DynamicProduct Product { get; private set; }

        public DynamicProductEventArgs(DynamicProduct product)
        {
            Product = product;
        }
    }

}

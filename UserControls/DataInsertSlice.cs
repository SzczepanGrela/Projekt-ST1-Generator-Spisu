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

namespace Generator_Spisu.UserControls
{
    public partial class DataInsertSlice : UserControl
    {
        public DataInsertSlice()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            addProductToList();


        }


        private void addProductToList()
        {
            try
            {
                AreBoxesEmpty();

                AreBoxesCorrect();

                Product product = GenerateProduct();

                ProductList.AddProductToList(product);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }


            ClearBoxes();
        }



        private Product GenerateProduct()
        {

            Product product = new Product();
            product.Id = ProductList.GetProductsCount()+ 1;
            product.ProductName = this.ProductName.Text;
            product.Type = this.Type.Text;
            product.StartQuantity = int.Parse(this.StartQuantity.Text);
            product.StartValue = this.StartValue.Text;
            product.ComingQuantity = int.Parse(this.ComingQuantity.Text);
            product.ComingValue = this.ComingValue.Text;
            product.OutgoingQuantity = int.Parse(this.OutgoingQuantity.Text);
            product.OutgoingValue = this.OutgoingValue.Text;
            product.WarehouseQuantity = int.Parse(this.WarehouseQuantity.Text);

            return product;
        }


        private void ClearBoxes()
        {
            foreach (Control c in this.tableLayoutPanel1.Controls)
            {
                

                if (c is TextBox)               
                    c.Text = "";
                else if (c is ComboBox)
                    ((ComboBox)c).SelectedIndex = -1;

                
            
            }
        }

        private void AreBoxesEmpty()
        {

            foreach (Control c in this.tableLayoutPanel1.Controls)
            {
                bool TextOrCombo = c is TextBox || c is ComboBox;

                if (TextOrCombo && c.Text == "")
                    throw new Exception("Trzeba wypełnić wszystkie pola");
                
            }



        }

        private void AreBoxesCorrect()
        {

            string[] QuantityStrings = { StartQuantity.Text, ComingQuantity.Text, OutgoingQuantity.Text, WarehouseQuantity.Text };
            string[] PriceStrings = { StartValue.Text, ComingValue.Text, OutgoingValue.Text };



            QuantityStringValidation(QuantityStrings);
            PriceStringValidation(PriceStrings);

        }


        private void PriceStringValidation(params string[] price)
        {

            for (int i = price.Length - 1; i >= 0; i--)
            {
                price[i] = price[i].Replace(".", ",");
                bool IncorrectNumberOfCommas = price[i].Count(c => c == ',') > 1;
                bool IllegalCharacters = price[i].Any(c => !char.IsDigit(c) && c != ',');



                if (IllegalCharacters || IncorrectNumberOfCommas)
                    throw new Exception($"Wprowadzono niepoprawne dane: {price[i]}");

            }

        }


        private void QuantityStringValidation(params string[] quantity)  // params makes it so you can pass multiple arguments or one
        {
            for (int i = quantity.Length - 1; i >= 0; i--)
            {
                bool IllegalCharacters = quantity[i].Any(c => !char.IsDigit(c));

                if (quantity[i].Any(c => !char.IsDigit(c)))
                {
                    throw new Exception($"Wprowadzono niepoprawne dane: {quantity[i]}");
                }
            }


        }




        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }


    }
}

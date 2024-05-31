﻿using Generator_Spisu.Classes;
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

        bool EditMode = false;   // if true, the slice is in edit mode

        int hiddenId = 0;

        public DataInsertSlice()
        {
            InitializeComponent();

            DataSlice.ProductEdit += HandleProductEdit;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                if (EditMode)
                {

                    Product product = GenerateProduct(hiddenId);

                    ProductList.EditProductInList(product);

                    ProductEdited?.Invoke(null, new ProductEditedEventArgs(product));

                    SwitchToNormalMode();


                }
                else
                {
                    addProductToList();
                    ClearBoxes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }


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


            
        }



        private Product GenerateProduct(int hiddenid = 0)
        {
            

            Product product = new Product();
            if (hiddenid == 0) product.Id = ProductList.GetProductsCount() + 1;
            else product.Id = hiddenid;
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



        private void HandleProductEdit(object sender, ProductEditEventArgs e)
        {

            FillBoxes(e.Product);
            hiddenId = e.Product.Id;
            SwitchToEditMode();

        }


        private void FillBoxes(Product product)
        {
            this.ProductName.Text = product.ProductName;
            this.Type.Text = product.Type;
            this.StartQuantity.Text = product.StartQuantity.ToString();
            this.StartValue.Text = product.StartValue;
            this.ComingQuantity.Text = product.ComingQuantity.ToString();
            this.ComingValue.Text = product.ComingValue;
            this.OutgoingQuantity.Text = product.OutgoingQuantity.ToString();
            this.OutgoingValue.Text = product.OutgoingValue;
            this.WarehouseQuantity.Text = product.WarehouseQuantity.ToString();
        }

        private void SwitchToEditMode()
        {
            if (!EditMode)
            {
                EditMode = true;
                OkButton.Font = new Font(OkButton.Font.FontFamily, 10);
                OkButton.Text = "Zatwierdź";
            }
            else
            {
                MessageBox.Show("Spróbowano wejść w tryb edytowania podczas trybu edytowania");
            }
        }

        private void SwitchToNormalMode()
        {
            if (EditMode)
            {
                EditMode = false;
                hiddenId = 0;
                OkButton.Font = new Font(OkButton.Font.FontFamily, 15);
                OkButton.Text = "Ok";
            }
            else
            {
                throw new Exception("Spróbowano wyjść z trybu edytowania podczas trybu normalnego");
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
        public static event EventHandler<ProductEditedEventArgs> ProductEdited;

    }

    public class ProductEditedEventArgs : EventArgs
    {
        public Product Product { get; }

        public ProductEditedEventArgs(Product product)
        {
            Product = product;
        }
    }
}

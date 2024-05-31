﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Generator_Spisu.Classes;
using Generator_Spisu.Classes.FileOperations;
using Generator_Spisu.UserControls;
using WindowsFormsApp1.classes.FileOperations;
using WindowsFormsApp1.interfaces;



namespace Generator_Spisu
{
    public partial class MainWindow : Form
    {
        CsvFileOperations csvFileOperations = new CsvFileOperations();




        public MainWindow()
        {
            InitializeComponent();
            ProductList.ProductAdded += HandleProductAdded;
            DataInsertSlice.ProductEdited += HandleProductEdited;

        }

        private void dataInsertSlice1_Load(object sender, EventArgs e)
        {

        }

        private void HandleProductAdded(object sender, ProductAddedEventArgs e)
        {
            DataSlicePanel.Controls.Add(new DataSlice(e.Product));
        }



        private void HandleProductEdited(object sender, ProductEditedEventArgs e)
        {
            foreach (Control control in DataSlicePanel.Controls)
            {
                if (control is DataSlice)
                {
                    DataSlice dataSlice = (DataSlice)control;
                    if (dataSlice.GetProduct().Id == e.Product.Id)
                    {
                        dataSlice.UpdateProduct(e.Product);
                        return;
                    }
                }
            }
        }


        private void SaveButton_Click(object sender, EventArgs e)
        {


        }

        private void DataSlicePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void zapiszToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ProductList.GetProductsCount() < 1)
            {
                MessageBox.Show("Nie ma nic do zapisania");
                return;
            }
            if (!csvFileOperations.IsConnected())
            {
                DialogResult newSavePath = GetSaveFilePath();

                if (newSavePath == DialogResult.OK) 
                    SaveFile();
            }
            else    

            SaveFile();


        }

        private void zapiszJakoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ProductList.GetProductsCount() < 1)
            {
                MessageBox.Show("Nie ma nic do zapisania");
                return;
            }

            DialogResult newSavePath = GetSaveFilePath();

            if (newSavePath == DialogResult.OK) SaveFile();

        }

        private void otwórzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult newSavePath = GetOpenFilePath();

            if (newSavePath == DialogResult.OK)
            {
                string[] lines = csvFileOperations.ReadFile();

                ClearEverything();


                foreach (string line in lines)
                {
                    ProductList.AddFromCsv(line);

                }
            }
        }


        private void ClearEverything()
        {
            DataSlicePanel.Controls.Clear();
            ProductList.ClearList();

        }

        private DialogResult GetSaveFilePath()
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text files (*.csv)|*.csv";
                saveFileDialog.Title = "Wybierz lokalizację i nazwę pliku";
                saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    csvFileOperations = new CsvFileOperations(saveFileDialog.FileName);

                    return DialogResult.OK;
                }
                else
                {
                    return DialogResult.Cancel;
                }
            }
        }


        private string GetSaveFilePathDocx()
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Word Document (*.docx)|*.docx|All files (*.*)|*.*";
                saveFileDialog.Title = "Wybierz lokalizację i nazwę pliku";
                saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    return saveFileDialog.FileName;

                }

                else return null;


            }
        }



        private DialogResult GetOpenFilePath()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text files (*.csv)|*.csv";
                openFileDialog.Title = "Wybierz plik do otwarcia";
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    csvFileOperations = new CsvFileOperations(openFileDialog.FileName);

                    return DialogResult.OK;
                }
                else
                {
                    return DialogResult.Cancel;
                }
            }
        }


        private void SaveFile()
        {
            string[] lines = ProductList.GetProductCsvList();


            csvFileOperations.WriteFile(lines);


        }

        private void wyczyśćToolStripMenuItem_Click(object sender, EventArgs e)
        {

            // to do: popup do you want to clear everything?
            ClearEverything();
        }

        private void zamknijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // to do: popup do you want to save, are you sure you want to leave
            Application.Exit();
        }

        private void stwórzDocxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DocxGenerator docxGenerator = new DocxGenerator();

            string savePath = GetSaveFilePathDocx();

            if (savePath != null)
            {
                docxGenerator.GenerateDocument(savePath, ProductList.GetProductLists());
            }
        }
    }
}
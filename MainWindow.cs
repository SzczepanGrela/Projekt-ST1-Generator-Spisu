using System;
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
using Generator_Spisu.Enums;
using System.Reflection;

using Generator_Spisu.Forms;



namespace Generator_Spisu
{
    public partial class MainWindow : Form
    {
        CsvFileOperations csvFileOperations = new CsvFileOperations();




        public MainWindow()
        {
            InitializeComponent();

            ProductList.ProductAdded += HandleProductAdded;
 

            AttributeList.SetAttributesFromSettings();
            InitializeUserControls();

            

        }

        private void dataInsertSlice1_Load(object sender, EventArgs e)
        {

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
            ScrollablePanel.Controls.Clear();
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

            // to do: popup do you want to clear everything? ll
            ClearEverything();
        }

        private void zamknijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // to do: popup do you want to save, are you sure you want to leave
            Application.Exit();
        }

        private void stwórzDocxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ProductList.GetProductsCount() < 1)
            {
                MessageBox.Show("Nie ma nic do generowania");
                return;
            }

            DocxGenerator docxGenerator = new DocxGenerator();

            string savePath = GetSaveFilePathDocx();

            if (savePath != null)
            {

                string settingsPath = "../../Settings/Attributes.json";
               
                docxGenerator.GenerateDocument(savePath, ProductList.GetProductLists(), settingsPath);
            }
        }

        private void atrybutyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PropertySettings propertySettingsForm = new PropertySettings();
            propertySettingsForm.ShowDialog();
        }

        private void nowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr =  GetSaveFilePath();
            if (dr == DialogResult.Cancel )
            {
                return;
            }
            ClearEverything();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddAttributeNamesSlice()
        {

            DynamicDataDisplaySlice AttributeNamesSlice = new DynamicDataDisplaySlice();

            
            
            AttributeNamesPanel.Controls.Add(AttributeNamesSlice);

        }

        private void ClearRecords()
        {
            ScrollablePanel.Controls.Clear();

            AddAttributeNamesSlice();

        }

        private void HandleProductAdded(object sender, ProductAddedEventArgs e)
        {

            DynamicDataDisplaySlice slice = new DynamicDataDisplaySlice(e.Product);
            slice.Dock = DockStyle.Top;
            DataSlicePanel.Controls.Add(slice);
        }

        private void InitializeUserControls()
        {

            List<ProductAttribute> attributes = AttributeList.GetAttributes();

            List<AttributeSingleForm> controls = AttributeSingleForm.SingleFormsFactory(attributes);

            foreach (AttributeSingleForm control in controls)
            {
                
                this.AttributesPanel.Controls.Add(control);
               
            }



            AddAttributeNamesSlice();


        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {

            DynamicProduct product = CreateProduct();

            ProductList.AddProductToList(product);
        }

        private DynamicProduct CreateProduct()
        {
           Dictionary<ProductAttribute, object> attributesWithValues = new Dictionary<ProductAttribute, object>();

            foreach (AttributeSingleForm control in AttributesPanel.Controls)
            {

                ProductAttribute key = control.GetProductAttribute();
                var value = control.GetControlValue();

                bool isIncorrectEnum = key.Type == AttributeType.Enum && !key.EnumValues.Contains(value);  
                
                if ( isIncorrectEnum )
                { 
                        MessageBox.Show("Niepoprawna wartość dla atrybutu " + key.Name);
                        return null; 
                }


                bool isEmptyWhenNotAllowed = key.CanBeEmpty == false && (value as string == "" || value == null);

                if (isEmptyWhenNotAllowed)
                {
                    MessageBox.Show("Atrybut " + key.Name + " nie może być pusty");
                    return null;
                }


                bool areTypesMatching = key.Type == control.GetProductAttribute().Type;


                if (areTypesMatching) attributesWithValues.Add(key, value);
                else throw new ArgumentException("Types of control and attribute do not match");


            }

            return  new DynamicProduct(attributesWithValues);

            
        }
    }
}

using Generator_Spisu.Classes;
using Generator_Spisu.Classes.FileOperations;
using Generator_Spisu.Enums;
using Generator_Spisu.Forms;
using Generator_Spisu.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp1.classes.FileOperations;



namespace Generator_Spisu
{
    public partial class MainWindow : Form
    {
        GspFileOperations gspFileOperations = new GspFileOperations();




        public MainWindow()
        {
            InitializeComponent();

            ProductList.ProductAdded += HandleProductAdded;

            DynamicDataDisplaySlice.ProductEdit += HandleProductEdit;

            AttributeList.AttributesChanged += HandleAttributesChanged;




            AttributeList.SetAttributesFromSettings();
            InitializeUserControls();



        }

        private void HandleAttributesChanged(object sender, EventArgs e)
        {
            this.AttributeNamesPanel.Controls.Clear();
            AddAttributeNamesSlice();
            this.AttributesPanel.Controls.Clear();
            InitializeUserControls();
            this.DataSlicePanel.Controls.Clear();

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
            if (!gspFileOperations.IsConnected())
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
                string[] lines = gspFileOperations.ReadFile();


                int i = 0;


                List<string> attributeLinesList = new List<string>();
                while (i < lines.Length && lines[i][0] == '*')
                {
                    string line = lines[i];
                    attributeLinesList.Add(lines[i].Substring(1));
                    i++;
                }

                AttributeList.SetAttributesFromCsv(attributeLinesList);



                ClearEverything();



                while (i < lines.Length)
                {
                    string line = lines[i];
                    string[] values = line.Split(';');

                    Dictionary<ProductAttribute, object> attributesWithValues = new Dictionary<ProductAttribute, object>();

                    for (int j = 1; j < values.Length; j++)
                    {
                        ProductAttribute key = AttributeList.GetAttributes()[j - 1];
                        object value = values[j];

                        attributesWithValues.Add(key, value);
                    }

                    int id = int.Parse(values[0]);

                    DynamicProduct product = new DynamicProduct(attributesWithValues, id);

                    ProductList.AddProductToList(product);

                    i++;
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
                saveFileDialog.Filter = "Text files (*.gsp)|*.gsp";
                saveFileDialog.Title = "Wybierz lokalizację i nazwę pliku";
                saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    gspFileOperations = new GspFileOperations(saveFileDialog.FileName);

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
                openFileDialog.Filter = "Text files (*.gsp)|*.gsp";
                openFileDialog.Title = "Wybierz plik do otwarcia";
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    gspFileOperations = new GspFileOperations(openFileDialog.FileName);

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
            List<string> lines = new List<string>();

            lines = ProductList.GetProductCsvList();

            List<string> attributesLines = AttributeList.GetAttributesToCsv();



            lines.InsertRange(0, attributesLines);

            gspFileOperations.WriteFile(lines.ToArray());


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
            DialogResult dr = GetSaveFilePath();
            if (dr == DialogResult.Cancel)
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

        private void HandleProductEdit(object sender, DynamicProductEventArgs e)
        {
            DynamicProduct product = e.Product;

            FillInsertSliceWithProduct(product);


        }

        private void FillInsertSliceWithProduct(DynamicProduct product)
        {
            foreach (AttributeSingleForm control in AttributesPanel.Controls)
            {
                ProductAttribute key = control.GetProductAttribute();
                object value = product.GetAttributeValue(key);

                control.SetControlValue(value);
            }
        }



        private void HandleProductAdded(object sender, ProductAddedEventArgs e)
        {

            DynamicDataDisplaySlice slice = new DynamicDataDisplaySlice(e.Product);

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

            if(product == null) return;

            ProductList.AddProductToList(product);

            ClearInsertForms();
        }

        private void ClearInsertForms()
        {
            foreach (AttributeSingleForm control in AttributesPanel.Controls)
            {
                control.ClearControl();
            }
        }

        private DynamicProduct CreateProduct()
        {
            Dictionary<ProductAttribute, object> attributesWithValues = new Dictionary<ProductAttribute, object>();

            foreach (AttributeSingleForm control in AttributesPanel.Controls)
            {

                try
                {
                    bool controlValidated = control.ValidateData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return null;
                }
                ProductAttribute key = control.GetProductAttribute();
                var value = control.GetControlValue();



                bool areTypesMatching = key.Type == control.GetProductAttribute().Type;


                if (areTypesMatching) attributesWithValues.Add(key, value);
                else throw new ArgumentException("Types of control and attribute do not match");


            }

            return new DynamicProduct(attributesWithValues);


        }


    }
}

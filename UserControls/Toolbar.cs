/*using Generator_Spisu.Classes;
using Generator_Spisu.Classes.FileOperations;
using Generator_Spisu.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.classes.FileOperations;

namespace Generator_Spisu.UserControls
{
    public partial class Toolbar : UserControl
    {
        CsvFileOperations csvFileOperations = new CsvFileOperations();

        public Toolbar()
        {
            InitializeComponent();
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
            OnClearAllClick(EventArgs.Empty);
        }

        public event EventHandler ClearAllClick;



        protected virtual void OnClearAllClick(EventArgs e)
        {
            ClearAllClick?.Invoke(this, e);
        }
    }


    




}
*/
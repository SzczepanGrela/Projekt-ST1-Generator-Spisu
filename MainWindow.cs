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
using Generator_Spisu.UserControls;


namespace Generator_Spisu
{
    public partial class MainWindow : Form
    {

        public MainWindow()
        {
            InitializeComponent();
            ProductList.ProductAdded += HandleProductAdded;
        }

        private void dataInsertSlice1_Load(object sender, EventArgs e)
        {
           
        }

        private void HandleProductAdded(object sender, ProductAddedEventArgs e)
        {
            DataSlicePanel.Controls.Add(new DataSlice(e.Product));
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {


        }
    }
}

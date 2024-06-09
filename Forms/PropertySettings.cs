using Generator_Spisu.Classes;
using Generator_Spisu.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generator_Spisu.Forms
{
    public partial class PropertySettings : Form
    {
        public PropertySettings()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SaveSettingsButton_Click(object sender, EventArgs e)
        {


            try
            {
                List<ProductAttribute> attributes = new List<ProductAttribute>();

                foreach (AttributeSlice slice in this.SlicePanel.Controls)
                {
                    bool unchangedName = slice.GetAttributeName() == "Przykładowa Nazwa";
                    
                    if (unchangedName) throw new Exception("Przynajmniej jeden nienazwany atrybut");

                    attributes.Append(slice.GetAttribute());

                }

                AttributeList.SetAttributes(attributes);



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MessageLabel_Click(object sender, EventArgs e)
        {

        }

        private void attributeSlice1_Load(object sender, EventArgs e)
        {

        }

        private void addSliceButton_Click(object sender, EventArgs e)
        {
            AttributeSlice newSlice = new AttributeSlice();

            newSlice.Dock = DockStyle.Top;
            newSlice.Visible = true;
            this.SlicePanel.Controls.Add(newSlice);
        }


        
    }
}

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
            this.Load += new EventHandler(PropertySettings_Load);

           
        }

       


        



        private void PropertySettings_Load(object sender, EventArgs e)
        {
            List<ProductAttribute> attributes = AttributeList.GetAttributes();

            List<AttributeSlice> slices = AttributeSlice.AttributeSliceFactory(attributes);

            foreach (AttributeSlice slice in slices)
            {
                slice.Dock = DockStyle.Top;
                slice.Visible = true;
                this.SlicePanel.Controls.Add(slice);
            }

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

        private void SetSettings_Click(object sender, EventArgs e)
        {
           
            SetSettings();
            
        }


        private void LeaveEditModes()
        {
            foreach (AttributeSlice slice in this.SlicePanel.Controls)
            {
                slice.SwitchToDisplayMode();
            }
        }



        private void SetSettings()
        {

           
            try
            {
                LeaveEditModes();

                List<ProductAttribute> attributes = new List<ProductAttribute>();

                foreach (AttributeSlice slice in this.SlicePanel.Controls)
                {
                    bool unchangedName = slice.GetAttributeName() == "Przykładowa Nazwa";

                    if (unchangedName) throw new Exception("Przynajmniej jeden nienazwany atrybut");

                    attributes.Add(slice.GetAttribute());

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

        private void SaveToJsonButton_Click(object sender, EventArgs e)
        {
            SetSettings();

            AttributeList.SetAttributesToSettings();
        }
    }
}

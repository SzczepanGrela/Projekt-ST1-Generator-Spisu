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
using Generator_Spisu.Classes;

namespace Generator_Spisu.UserControls
{
    public partial class AttributeSlice : UserControl
    {

        private SliceMode sliceMode;   // if true, the slice is in edit mode

        private List<string> enumValues;

        public AttributeSlice()
        {
            InitializeComponent();

            this.sliceMode = SliceMode.Edit;
          
            this.AttributeTypeComboBox.SelectedIndex = 0;
        }

        private void SwitchToEditMode()
        {
            this.sliceMode = SliceMode.Edit;
            this.ConfirmAndEditButton.Text = "Zatwierdź";

            this.AttributeNameLabel.Text = this.AttributeNameTextBox.Text;

            this.AttributeNameTextBox.Visible = true;
            this.AttributeNameLabel.Visible = false;

            this.AttributeTypeComboBox.Enabled = true;

            this.CanBeEmptyCheckBox.Enabled = true;

        }

        private void SwitchToDisplayMode()
        {
            this.sliceMode = SliceMode.Display;
            this.ConfirmAndEditButton.Text = "Edytuj";

            
            this.AttributeNameTextBox.Visible = false;
            this.AttributeNameLabel.Visible = true;

            this.AttributeTypeComboBox.Visible = false;
            this.AttributeTypeLabel.Visible = true;

            this.CanBeEmptyCheckBox.Enabled = false;
        }





        private void ConfirmAndEditButton_Click(object sender, EventArgs e)
        {
            if(this.sliceMode == SliceMode.Edit)
            {
                this.SwitchToDisplayMode();
            }
            else if(this.sliceMode == SliceMode.Display)
            {
                this.SwitchToEditMode();
            }
            else
            {
                throw new NotImplementedException();    // if i ever decide to make more modes, i will have to implement them here
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public string GetAttributeName()
        {
            return this.AttributeNameTextBox.Text;
        }

        public AttributeType GetAttributeType()
        {
            
           if (this.AttributeTypeComboBox.Text == "Wybierz typ") throw new ArgumentException("Nie wybrano typu atrybutu");

                AttributeType attributeType = (AttributeType)Enum.Parse(typeof(AttributeType), this.AttributeTypeComboBox.Text);
                return attributeType;

          

        }

        public bool CanBeEmpty()
        {
            if (this.CanBeEmptyCheckBox.Checked)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public ProductAttribute GetAttribute()
        {
            try
            {
                List<string> enumValues = new List<string>();
                if (AttributeTypeComboBox.SelectedIndex == 5)
                {
                    enumValues = this.enumValues;
                }
                return new ProductAttribute(this.GetAttributeName(), this.GetAttributeType(), this.CanBeEmpty(), enumValues);
            }
           catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
            
        }

        private void AttributeTypeLabel_Click(object sender, EventArgs e)
        {

        }

        private void DownArrow_Click(object sender, EventArgs e)
        {
            ShowTypeLabels();
        }

        private void ShowTypeLabels()
        {
            Height = 200;

        }

        private void AddEnumValueButton_Click(object sender, EventArgs e)
        {
            addNewEnumValue();
        }

        private void ClearEnumValuesButton_Click(object sender, EventArgs e)
        {
            clearEnumValues();
        }


        private void addNewEnumValue()
        {


            string newEnumValue = this.newTypeTextBox.Text;

            this.enumValues.Add(newEnumValue);

            this.TypesListLabel.Text += newEnumValue + ", ";
        }

        private void clearEnumValues()
        {
            this.enumValues.Clear();
            this.TypesListLabel.Text = "";
        }
      




    }


    public enum SliceMode
    {
        Edit,
        Display
        
    }
   
}

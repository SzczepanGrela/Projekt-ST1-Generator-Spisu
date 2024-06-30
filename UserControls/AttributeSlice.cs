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
using System.Windows.Forms.VisualStyles;
using Generator_Spisu.Enums;

namespace Generator_Spisu.UserControls
{
    public partial class AttributeSlice : UserControl
    {


        private SliceMode sliceMode;   // if true, the slice is in edit mode

        private bool isExpanded = false;

        private List<string> enumValues = new List<string>();

        public AttributeSlice()
        {
            InitializeComponent();

            this.sliceMode = SliceMode.Edit;

            this.AttributeTypeComboBox.SelectedIndex = 0;
        }

        public AttributeSlice(ProductAttribute attribute)
        {
            InitializeComponent();
            SwitchToDisplayMode();

            this.AttributeNameLabel.Text = attribute.Name;
            this.AttributeTypeComboBox.SelectedIndex = attributeTypeToIndex(attribute.Type);
            this.CanBeEmptyCheckBox.Checked = attribute.CanBeEmpty;
            this.columnWidthUpDown.Value = attribute.ColumnWidth;
            this.isBoldCheckBox.Checked = attribute.IsBold;

            if (attribute.Type == AttributeType.Enum)
            {
                this.enumValues = attribute.EnumValues;
                foreach (string enumValue in attribute.EnumValues)
                {
                    if (this.TypesListTextBox.Text.Length > 0) this.TypesListTextBox.Text += ", ";
                    this.TypesListTextBox.Text += enumValue;
                }
            }


        }

        private int attributeTypeToIndex(AttributeType type)
        {
            switch (type)
            {
                case AttributeType.String:
                    return 0;
                case AttributeType.Int:
                    return 1;
                case AttributeType.Double:
                    return 2;
                case AttributeType.Bool:
                    return 3;
                case AttributeType.DateTime:
                    return 4;
                case AttributeType.Enum:
                    return 5;
                default:
                    throw new NotImplementedException();

            }
        }

        private void SwitchToEditMode()
        {
            this.sliceMode = SliceMode.Edit;
            this.ConfirmAndEditButton.Text = "Zatwierdź";

            this.AttributeNameTextBox.Text = this.AttributeNameLabel.Text;
            this.AttributeNameTextBox.Visible = true;
            this.AttributeNameLabel.Visible = false;


            this.AttributeTypeComboBox.Enabled = true;
            

            this.CanBeEmptyCheckBox.Enabled = true;

            EnableExpandedControls();

        }

        public void SwitchToDisplayMode()
        {
            this.sliceMode = SliceMode.Display;
            this.ConfirmAndEditButton.Text = "Edytuj";

            this.AttributeNameLabel.Text = this.AttributeNameTextBox.Text;
            this.AttributeNameTextBox.Visible = false;
            this.AttributeNameLabel.Visible = true;

            //this.AttributeTypeComboBox.Visible = false;
            //this.AttributeTypeLabel.Visible = true;
            //this.AttributeTypeLabel.Text = this.AttributeTypeComboBox.Text;
            this.AttributeTypeComboBox.Enabled = false;

            this.CanBeEmptyCheckBox.Enabled = false;

            DisableExpandedControls();
        }





        private void DisableExpandedControls()
        {
            this.newTypeTextBox.Enabled = false;
            this.AddEnumValueButton.Enabled = false;
            this.ClearEnumValuesButton.Enabled = false;
        }

        private void EnableExpandedControls()
        {
            this.newTypeTextBox.Enabled = true;
            this.AddEnumValueButton.Enabled = true;
            this.ClearEnumValuesButton.Enabled = true;
        }




        private void ConfirmAndEditButton_Click(object sender, EventArgs e)
        {
            if (this.sliceMode == SliceMode.Edit)
            {
                this.SwitchToDisplayMode();
            }
            else if (this.sliceMode == SliceMode.Display)
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
            return this.AttributeNameLabel.Text;
        }

        public int GetColumnWidth()
        {
          return (int)columnWidthUpDown.Value;
        }

        public bool GetIsBold()
        {
            return this.isBoldCheckBox.Checked;
        }

        public AttributeType GetAttributeType()
        {
            AttributeType attributeType;


            switch (this.AttributeTypeComboBox.SelectedIndex)
            {
                case 0:
                    attributeType = AttributeType.String;
                    break;
                case 1:
                    attributeType = AttributeType.Int;
                    break;
                case 2:
                    attributeType = AttributeType.Double;
                    break;
                case 3:
                    attributeType = AttributeType.Bool;
                    break;
                case 4:
                    attributeType = AttributeType.DateTime;
                    break;
                case 5:
                    attributeType = AttributeType.Enum;
                    break;
                default:
                    throw new NotImplementedException();
            }


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
                    enumValues = this.GetEnumValues();
                }
                return new ProductAttribute(this.GetAttributeName(), this.GetAttributeType(), this.CanBeEmpty(), enumValues, this.GetColumnWidth(), this.GetIsBold());
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }

        }

        private List<string> GetEnumValues()
        {
            string values = this.TypesListTextBox.Text;
            List<string> enumValues = new List<string>();
            enumValues = values.Split(',').ToList();

            return enumValues;
        }

        private void AttributeTypeLabel_Click(object sender, EventArgs e)
        {

        }

        private void Arrow_Click(object sender, EventArgs e)
        {
            if (isExpanded)
            {
                CollapseSlice();
                isExpanded = false;
                this.ArrowLabel.Text = "↓";

            }
            else
            {
                ExpandSlice();
                isExpanded = true;
                this.ArrowLabel.Text = "↑";
            }

        }

        private void ExpandSlice()
        {
            Height = 200;

        }

        private void CollapseSlice()
        {
            Height = 63;
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


            foreach (string enumValue in enumValues)
            {
                if (enumValue == newEnumValue)
                {
                    MessageBox.Show("Wartość już istnieje");
                    return;
                }
            }
            if (enumValues.Count > 0) this.TypesListTextBox.Text += ", ";

            this.TypesListTextBox.Text += newEnumValue;

            this.enumValues.Add(newEnumValue);


        }

        private void clearEnumValues()
        {
            this.enumValues.Clear();
            this.TypesListTextBox.Text = "";
        }



        public static List<AttributeSlice> AttributeSliceFactory(List<ProductAttribute> attributes)
        {
            List<AttributeSlice> slices = new List<AttributeSlice>();
            foreach (ProductAttribute attribute in attributes)
            {
                AttributeSlice slice = new AttributeSlice(attribute);
                slices.Add(slice);
            }

            return slices;
        }



    }


    public enum SliceMode
    {
        Edit,
        Display

    }

}

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
using Generator_Spisu.Enums;

namespace Generator_Spisu.UserControls
{
    public partial class AttributeSingleForm : UserControl
    {
        ProductAttribute originProductAttribute;


        public AttributeSingleForm()
        {
            InitializeComponent();
            originProductAttribute = new ProductAttribute("Name", AttributeType.String, true, null,300, false);

            SetupForm();
            AdjustPanelWidth();
            CenterLabel();
        }

        public AttributeSingleForm(ProductAttribute attribute)
        {
            InitializeComponent();
            originProductAttribute = attribute;
            SetupForm();
            AdjustPanelWidth();
            CenterLabel();
        }



        public static List<AttributeSingleForm> SingleFormsFactory(List<ProductAttribute> productAttributes)
        {

            List<AttributeSingleForm> attributeSingleForms = new List<AttributeSingleForm>();

            try
            {
                foreach (ProductAttribute productAttribute in productAttributes)
                {
                    AttributeSingleForm attributeSingleForm = new AttributeSingleForm(productAttribute);

                    attributeSingleForm.Show();
                    attributeSingleForms.Add(attributeSingleForm);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return attributeSingleForms;
        }



        private void SetupForm()
        {
            Control newControl = null;

            switch (originProductAttribute.Type)
            {
                case AttributeType.String:
                    newControl = new TextBox();
                    break;
                case AttributeType.Int:
                    newControl = new NumericUpDown();
                    ((NumericUpDown)newControl).Maximum = 1000;
                    
                    break;
                case AttributeType.Double:
                    newControl = new CustomNumericUpDown();
                    ((CustomNumericUpDown)newControl).DecimalPlaces = 2;
                    break;
                case AttributeType.DateTime:
                    newControl = new DateTimePicker();
                    break;
                case AttributeType.Bool:
                    newControl = new CheckBox();
                    break;
                case AttributeType.Enum:
                    newControl = new ComboBox();
                    ((ComboBox)newControl).DropDownStyle = ComboBoxStyle.DropDownList;
                    ((ComboBox)newControl).Items.AddRange(originProductAttribute.EnumValues.ToArray());
                    break;
            }

            if (newControl != null)
            {
                newControl.Dock = DockStyle.Fill;
                newControl.Font = new Font("Microsoft Sans Serif", 15);
                newControl.BringToFront();
                newControl.Show();

                this.InsertPanel.Controls.Add(newControl);

                PropertyNameLabel.Text = originProductAttribute.Name;
            }
        }


        private void AdjustPanelWidth()
        {
            int minWidth = 100;
            using (Graphics g = this.CreateGraphics())
            {
                SizeF size = g.MeasureString(this.PropertyNameLabel.Text, this.PropertyNameLabel.Font);
                int suggestedWidth = (int)(Math.Ceiling(size.Width) * 1.2) + this.PropertyNameLabel.Margin.Horizontal;
                this.Width = (suggestedWidth > minWidth) ? suggestedWidth : minWidth;
            }
        }

        private void CenterLabel()
        {
            PropertyNameLabel.AutoSize = true;
            PropertyNameLabel.Location = new Point((this.Width - PropertyNameLabel.Width) / 2, PropertyNameLabel.Location.Y);
        }

        public object GetControlValue()
        {
            if (InsertPanel.Controls.Count <= 0)
            {
                return null;
            }

            Control control = InsertPanel.Controls[0];

            switch (originProductAttribute.Type)
            {
                case AttributeType.String:
                    return ((TextBox)control).Text;
                case AttributeType.Int:
                    return ((NumericUpDown)control).Value;
                case AttributeType.Double:
                    return ((CustomNumericUpDown)control).Value;
                case AttributeType.DateTime:
                    return ((DateTimePicker)control).Value;
                case AttributeType.Bool:
                    return ((CheckBox)control).Checked;
                case AttributeType.Enum:
                    return ((ComboBox)control).SelectedItem;
                default:
                    return null;
            }


        }

        public ProductAttribute GetProductAttribute()
        {
            return originProductAttribute;
        }


        public string GetValueToString()

        {
           var value = GetControlValue();

            if(value is null)
            {
                throw new ArgumentException("Value is null");
            }

            if (value.ToString() is null)
            {
                throw new ArgumentException("Can't convert value to string");
            }

            return value.ToString();

        }

        internal void SetControlValue(object value)
        {
            Control control = InsertPanel.Controls[0]; // Rozważ przekazanie kontrolki jako parametr

            try
            {
                switch (originProductAttribute.Type)
                {
                    case AttributeType.String:
                        control.Text = value as string;
                        break;
                    case AttributeType.Int:
                       
                        var intValue = ConvertToInt(value);

                        if (intValue == null)
                            ((NumericUpDown)control).Value = 0;
                        else ((NumericUpDown)control).Value = (decimal)intValue;

                        break;
                    case AttributeType.Double:
                        var doubleValue = ConvertToDouble(value);

                        if (doubleValue == null)
                            ((NumericUpDown)control).Value = 0;
                        else ((NumericUpDown)control).Value = (decimal)doubleValue;

                        break;
                    case AttributeType.DateTime:
                        if (value is DateTime dateTimeValue)
                            ((DateTimePicker)control).Value = dateTimeValue;
                        break;
                    case AttributeType.Bool:
                        if (value is bool boolValue)
                            ((CheckBox)control).Checked = boolValue;
                        else if (value is null) ((CheckBox)control).Checked = false;
                        break;
                    case AttributeType.Enum:
                        ComboBox comboBox = control as ComboBox;
                        if (comboBox != null && value != null)
                            comboBox.SelectedItem = value.ToString();
                        else if (value is null) comboBox.SelectedIndex = -1;
                        break;
                    default:
                        throw new ArgumentException("Can't convert value to control");
                }
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Failed to set control value. {ex.Message}", ex);
            }
        }



        private int? ConvertToInt(object value)
        {
            if (value is int intValue)
            {
                return intValue;
            }
            else if (value is string stringValue)
            {
                if (int.TryParse(stringValue, out int result))
                {
                    return result;
                }
            }

            return null;
        }


        private double? ConvertToDouble(object value)
        {
            if (value is double doubleValue)
            {
                return doubleValue;
            }
            else if (value is string stringValue)
            {
                if (double.TryParse(stringValue, out double result))
                {
                    return result;
                }
            }

            return null;
        }



        public bool ValidateData()
        {
            if (originProductAttribute.CanBeEmpty == false && (GetControlValue() == null || GetControlValue() == ""))
            {
                throw new ArgumentException($"Kolumna {originProductAttribute.Name} nie może być pusta");
            }

            if (originProductAttribute.Type == AttributeType.Enum)
            {

                var value = GetControlValue();
                if (originProductAttribute.EnumValues.Contains(value.ToString()) == false)
                {
                    throw new ArgumentException($"Wartość {value} nie występuje w dopuszczonych typach");
                }
            }

            return true;
        }


        internal void ClearControl()
        {
            SetControlValue(null);
        }
    }




}

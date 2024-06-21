using DocumentFormat.OpenXml.Bibliography;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generator_Spisu.UserControls
{
    public partial class DataBox : UserControl
    {

        DataBoxType _type = DataBoxType.TextBox;

        Control control = null;

        public DataBox()
        {
            InitializeComponent();
        }

        public DataBox(DataBoxType type, List<string> components = null)
        {
            InitializeComponent();

           
            switch (type)
            {
                case DataBoxType.TextBox:
                    initTextBox();
                   
                    break;

                case DataBoxType.ComboBox:

                    if (components == null)
                        throw new ArgumentNullException("components", "components cannot be null when DataBoxType is ComboBox");

                    initComboBox(components);
                    
                    break;

                case DataBoxType.CheckBox:
                    initCheckBox();
                    
                    break;
            }


        }

        private void initComboBox(List<string> components)
        {
            _type = DataBoxType.ComboBox;

            control = new ComboBox();

            throw new NotImplementedException();
        }

        private void initCheckBox()
        {
            _type = DataBoxType.CheckBox;

            control = new CheckBox();

            throw new NotImplementedException();
        }

        private void initTextBox()
        {
            _type = DataBoxType.TextBox;

            control = new TextBox();


            throw new NotImplementedException();



        }

        public string GetValue()
        {
            
            
                switch (_type)
                {
                    case DataBoxType.TextBox:
                        return control.Text;

                    case DataBoxType.ComboBox:
                        return control.Text;

                    case DataBoxType.CheckBox:
                        return ((CheckBox)control).Checked.ToString();

                    default:
                        throw new NotImplementedException();
                }
            
        }

    }






    public enum DataBoxType
    {
        TextBox,
        ComboBox,
        CheckBox,

    }
}

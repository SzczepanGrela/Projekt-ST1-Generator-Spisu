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
    public partial class CustomNumericUpDown : NumericUpDown
    {
        public CustomNumericUpDown()
        {
            InitializeComponent();
        }
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);

            
            if (e.KeyChar == '.')
            {
               
                SendKeys.Send(",");
                e.Handled = true; 
            }
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);

            
            if (e.KeyCode == Keys.OemPeriod)
            {
                e.SuppressKeyPress = true; 
            }
        }

    }
}

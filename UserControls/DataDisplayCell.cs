using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generator_Spisu.UserControls
{
    public partial class DataDisplayCell : UserControl
    {
        public DataDisplayCell()
        {
            InitializeComponent();
 
        }

        public DataDisplayCell(string value, int width)
        {
            InitializeComponent();
            AdjustWidth(width);
            this.ValueLabel.Text = value;
            CenterLabel();
        }

       

        public DataDisplayCell(string value,int width,  bool isBold, int fontSize)
        {
            InitializeComponent();

            AdjustWidth(width);

            this.ValueLabel.Text = value;
            if (isBold)
            {
                this.ValueLabel.Font = new Font(this.ValueLabel.Font.FontFamily, fontSize, FontStyle.Bold);
            }
            else
            {
                this.ValueLabel.Font = new Font(this.ValueLabel.Font.FontFamily, fontSize, FontStyle.Regular);
            }

            CenterLabel();

        }


        public void SetText(string text)
        {
            this.ValueLabel.Text = text;
            CenterLabel();
        }

        private void CenterLabel()
        {
            ValueLabel.AutoSize = true;
            ValueLabel.Location = new Point((this.Width - ValueLabel.Width) / 2, ValueLabel.Location.Y);
        }


        private void AdjustWidth(int width)
        {
            this.Size = new Size(Width, this.Size.Height);
        }


        public static List<DataDisplayCell> DataDisplayCellsFactory(List<string> values, List<int> widths)
        {

            if (values.Count != widths.Count)
            {
                throw new ArgumentException("Values and widths count mismatch");
            }

            List<DataDisplayCell> cells = new List<DataDisplayCell>();

            for (int i=0; i<values.Count; i++)
            {
                DataDisplayCell cell = new DataDisplayCell(values[i], widths[i]);
                cells.Add(cell);
            }

            return cells;
        }

        public static List<DataDisplayCell> DataDisplayCellsFactory(List<string> values, List<int> widths, bool isBold, int fontsize)
        {

            if (values.Count != widths.Count)
            {
                throw new ArgumentException("Values and widths count mismatch");
            }
            List<DataDisplayCell> cells = new List<DataDisplayCell>();

            for (int i=0;i<values.Count; i++)
            {
                DataDisplayCell cell = new DataDisplayCell(values[i], widths[i], isBold, fontsize);
                cells.Add(cell);
            }

            return cells;
        }



    }
}

namespace Generator_Spisu.UserControls
{
    partial class LegacyDataInsertSlice
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.WarehouseQuantity = new System.Windows.Forms.TextBox();
            this.OutgoingValue = new System.Windows.Forms.TextBox();
            this.OutgoingQuantity = new System.Windows.Forms.TextBox();
            this.ComingValue = new System.Windows.Forms.TextBox();
            this.ComingQuantity = new System.Windows.Forms.TextBox();
            this.StartValue = new System.Windows.Forms.TextBox();
            this.StartQuantity = new System.Windows.Forms.TextBox();
            this.ProductName = new System.Windows.Forms.TextBox();
            this.OkButton = new System.Windows.Forms.Button();
            this.Type = new System.Windows.Forms.ComboBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tableLayoutPanel1.ColumnCount = 10;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0002F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0001F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0001F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0001F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0001F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0001F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0001F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0001F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.999102F));
            this.tableLayoutPanel1.Controls.Add(this.WarehouseQuantity, 8, 0);
            this.tableLayoutPanel1.Controls.Add(this.OutgoingValue, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.OutgoingQuantity, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.ComingValue, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.ComingQuantity, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.StartValue, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.StartQuantity, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.ProductName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.OkButton, 9, 0);
            this.tableLayoutPanel1.Controls.Add(this.Type, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 56);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // WarehouseQuantity
            // 
            this.WarehouseQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.WarehouseQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WarehouseQuantity.Location = new System.Drawing.Point(650, 15);
            this.WarehouseQuantity.Margin = new System.Windows.Forms.Padding(0);
            this.WarehouseQuantity.Name = "WarehouseQuantity";
            this.WarehouseQuantity.Size = new System.Drawing.Size(69, 26);
            this.WarehouseQuantity.TabIndex = 8;
            this.WarehouseQuantity.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // OutgoingValue
            // 
            this.OutgoingValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.OutgoingValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OutgoingValue.Location = new System.Drawing.Point(578, 15);
            this.OutgoingValue.Margin = new System.Windows.Forms.Padding(0);
            this.OutgoingValue.Name = "OutgoingValue";
            this.OutgoingValue.Size = new System.Drawing.Size(69, 26);
            this.OutgoingValue.TabIndex = 7;
            this.OutgoingValue.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // OutgoingQuantity
            // 
            this.OutgoingQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.OutgoingQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OutgoingQuantity.Location = new System.Drawing.Point(506, 15);
            this.OutgoingQuantity.Margin = new System.Windows.Forms.Padding(0);
            this.OutgoingQuantity.Name = "OutgoingQuantity";
            this.OutgoingQuantity.Size = new System.Drawing.Size(69, 26);
            this.OutgoingQuantity.TabIndex = 6;
            this.OutgoingQuantity.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // ComingValue
            // 
            this.ComingValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ComingValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ComingValue.Location = new System.Drawing.Point(434, 15);
            this.ComingValue.Margin = new System.Windows.Forms.Padding(0);
            this.ComingValue.Name = "ComingValue";
            this.ComingValue.Size = new System.Drawing.Size(69, 26);
            this.ComingValue.TabIndex = 5;
            this.ComingValue.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // ComingQuantity
            // 
            this.ComingQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ComingQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ComingQuantity.Location = new System.Drawing.Point(362, 15);
            this.ComingQuantity.Margin = new System.Windows.Forms.Padding(0);
            this.ComingQuantity.Name = "ComingQuantity";
            this.ComingQuantity.Size = new System.Drawing.Size(69, 26);
            this.ComingQuantity.TabIndex = 4;
            this.ComingQuantity.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // StartValue
            // 
            this.StartValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.StartValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StartValue.Location = new System.Drawing.Point(290, 15);
            this.StartValue.Margin = new System.Windows.Forms.Padding(0);
            this.StartValue.Name = "StartValue";
            this.StartValue.Size = new System.Drawing.Size(69, 26);
            this.StartValue.TabIndex = 3;
            this.StartValue.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // StartQuantity
            // 
            this.StartQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.StartQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StartQuantity.Location = new System.Drawing.Point(218, 15);
            this.StartQuantity.Margin = new System.Windows.Forms.Padding(0);
            this.StartQuantity.Name = "StartQuantity";
            this.StartQuantity.Size = new System.Drawing.Size(69, 26);
            this.StartQuantity.TabIndex = 2;
            this.StartQuantity.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ProductName
            // 
            this.ProductName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ProductName.Location = new System.Drawing.Point(3, 15);
            this.ProductName.Margin = new System.Windows.Forms.Padding(0);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(139, 26);
            this.ProductName.TabIndex = 1;
            this.ProductName.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // OkButton
            // 
            this.OkButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OkButton.BackColor = System.Drawing.SystemColors.Info;
            this.OkButton.Location = new System.Drawing.Point(730, 9);
            this.OkButton.Margin = new System.Windows.Forms.Padding(0);
            this.OkButton.MaximumSize = new System.Drawing.Size(60, 40);
            this.OkButton.MinimumSize = new System.Drawing.Size(50, 30);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(58, 37);
            this.OkButton.TabIndex = 9;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = false;
            this.OkButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Type
            // 
            this.Type.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Type.FormattingEnabled = true;
            this.Type.Items.AddRange(new object[] {
            "Kg",
            "L",
            "Szt."});
            this.Type.Location = new System.Drawing.Point(145, 14);
            this.Type.Margin = new System.Windows.Forms.Padding(0);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(70, 28);
            this.Type.TabIndex = 0;
            this.Type.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // bindingSource1
            // 
            this.bindingSource1.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // DataInsertSlice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MinimumSize = new System.Drawing.Size(800, 56);
            this.Name = "DataInsertSlice";
            this.Size = new System.Drawing.Size(800, 56);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ComboBox Type;
        private System.Windows.Forms.TextBox ProductName;
        private System.Windows.Forms.TextBox WarehouseQuantity;
        private System.Windows.Forms.TextBox OutgoingValue;
        private System.Windows.Forms.TextBox OutgoingQuantity;
        private System.Windows.Forms.TextBox ComingValue;
        private System.Windows.Forms.TextBox ComingQuantity;
        private System.Windows.Forms.TextBox StartValue;
        private System.Windows.Forms.TextBox StartQuantity;
        private System.Windows.Forms.Button OkButton;
    }
}

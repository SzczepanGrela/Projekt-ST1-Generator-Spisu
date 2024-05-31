namespace Generator_Spisu.UserControls
{
    partial class DataSlice
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
            this.OutgoingQuantity = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.Label();
            this.StartQuantity = new System.Windows.Forms.Label();
            this.StartValue = new System.Windows.Forms.Label();
            this.ComingQuantity = new System.Windows.Forms.Label();
            this.ComingValue = new System.Windows.Forms.Label();
            this.OutgoingValue = new System.Windows.Forms.Label();
            this.Type = new System.Windows.Forms.Label();
            this.ProductName = new System.Windows.Forms.Label();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.WarehouseQuantity = new System.Windows.Forms.Label();
            this.EditButton = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 12;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.04673F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.18692F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.475963F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.47671F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.47671F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.47671F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.47671F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.47671F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.47671F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.571429F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.142858F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.571429F));
            this.tableLayoutPanel1.Controls.Add(this.OutgoingQuantity, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.Id, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.StartQuantity, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.StartValue, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.ComingQuantity, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.ComingValue, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.OutgoingValue, 8, 0);
            this.tableLayoutPanel1.Controls.Add(this.Type, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.ProductName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.RemoveButton, 11, 0);
            this.tableLayoutPanel1.Controls.Add(this.WarehouseQuantity, 9, 0);
            this.tableLayoutPanel1.Controls.Add(this.EditButton, 10, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(740, 41);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // OutgoingQuantity
            // 
            this.OutgoingQuantity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OutgoingQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OutgoingQuantity.Location = new System.Drawing.Point(464, 0);
            this.OutgoingQuantity.Name = "OutgoingQuantity";
            this.OutgoingQuantity.Size = new System.Drawing.Size(49, 41);
            this.OutgoingQuantity.TabIndex = 7;
            this.OutgoingQuantity.Text = "6";
            this.OutgoingQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Id
            // 
            this.Id.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Id.Location = new System.Drawing.Point(3, 0);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(31, 41);
            this.Id.TabIndex = 0;
            this.Id.Text = " 1";
            this.Id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StartQuantity
            // 
            this.StartQuantity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StartQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StartQuantity.Location = new System.Drawing.Point(244, 0);
            this.StartQuantity.Name = "StartQuantity";
            this.StartQuantity.Size = new System.Drawing.Size(49, 41);
            this.StartQuantity.TabIndex = 3;
            this.StartQuantity.Text = "121";
            this.StartQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StartValue
            // 
            this.StartValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StartValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StartValue.Location = new System.Drawing.Point(299, 0);
            this.StartValue.Name = "StartValue";
            this.StartValue.Size = new System.Drawing.Size(49, 41);
            this.StartValue.TabIndex = 4;
            this.StartValue.Text = "12,50";
            this.StartValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ComingQuantity
            // 
            this.ComingQuantity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComingQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ComingQuantity.Location = new System.Drawing.Point(354, 0);
            this.ComingQuantity.Name = "ComingQuantity";
            this.ComingQuantity.Size = new System.Drawing.Size(49, 41);
            this.ComingQuantity.TabIndex = 5;
            this.ComingQuantity.Text = "10";
            this.ComingQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ComingValue
            // 
            this.ComingValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComingValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ComingValue.Location = new System.Drawing.Point(409, 0);
            this.ComingValue.Name = "ComingValue";
            this.ComingValue.Size = new System.Drawing.Size(49, 41);
            this.ComingValue.TabIndex = 6;
            this.ComingValue.Text = "25,99";
            this.ComingValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OutgoingValue
            // 
            this.OutgoingValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OutgoingValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OutgoingValue.Location = new System.Drawing.Point(519, 0);
            this.OutgoingValue.Name = "OutgoingValue";
            this.OutgoingValue.Size = new System.Drawing.Size(49, 41);
            this.OutgoingValue.TabIndex = 8;
            this.OutgoingValue.Text = "12,30";
            this.OutgoingValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Type
            // 
            this.Type.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Type.Location = new System.Drawing.Point(186, 0);
            this.Type.Margin = new System.Windows.Forms.Padding(0);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(55, 41);
            this.Type.TabIndex = 2;
            this.Type.Text = "szt";
            this.Type.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProductName
            // 
            this.ProductName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ProductName.Location = new System.Drawing.Point(40, 0);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(143, 41);
            this.ProductName.TabIndex = 11;
            this.ProductName.Text = "Nazwa Produktu";
            this.ProductName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RemoveButton
            // 
            this.RemoveButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RemoveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.RemoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RemoveButton.Location = new System.Drawing.Point(689, 5);
            this.RemoveButton.Margin = new System.Windows.Forms.Padding(0);
            this.RemoveButton.MaximumSize = new System.Drawing.Size(60, 40);
            this.RemoveButton.MinimumSize = new System.Drawing.Size(40, 25);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(40, 30);
            this.RemoveButton.TabIndex = 11;
            this.RemoveButton.Text = "X";
            this.RemoveButton.UseVisualStyleBackColor = false;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // WarehouseQuantity
            // 
            this.WarehouseQuantity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WarehouseQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WarehouseQuantity.Location = new System.Drawing.Point(574, 0);
            this.WarehouseQuantity.Name = "WarehouseQuantity";
            this.WarehouseQuantity.Size = new System.Drawing.Size(42, 41);
            this.WarehouseQuantity.TabIndex = 9;
            this.WarehouseQuantity.Text = "5";
            this.WarehouseQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EditButton
            // 
            this.EditButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EditButton.BackColor = System.Drawing.SystemColors.Info;
            this.EditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EditButton.Location = new System.Drawing.Point(629, 5);
            this.EditButton.Margin = new System.Windows.Forms.Padding(0);
            this.EditButton.MaximumSize = new System.Drawing.Size(60, 40);
            this.EditButton.MinimumSize = new System.Drawing.Size(40, 25);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(40, 30);
            this.EditButton.TabIndex = 12;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // DataSlice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MinimumSize = new System.Drawing.Size(740, 30);
            this.Name = "DataSlice";
            this.Size = new System.Drawing.Size(740, 41);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label Id;
        private System.Windows.Forms.Label StartQuantity;
        private System.Windows.Forms.Label StartValue;
        private System.Windows.Forms.Label ComingQuantity;
        private System.Windows.Forms.Label ComingValue;
        private System.Windows.Forms.Label OutgoingQuantity;
        private System.Windows.Forms.Label OutgoingValue;
        private System.Windows.Forms.Label WarehouseQuantity;
        private System.Windows.Forms.Label Type;
        private System.Windows.Forms.Label ProductName;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button EditButton;
    }
}

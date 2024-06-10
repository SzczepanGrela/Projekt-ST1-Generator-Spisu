namespace Generator_Spisu.UserControls
{
    partial class AttributeSlice
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
            this.AttributeNameTextBox = new System.Windows.Forms.TextBox();
            this.AttributeTypeComboBox = new System.Windows.Forms.ComboBox();
            this.CanBeEmptyCheckBox = new System.Windows.Forms.CheckBox();
            this.ConfirmAndEditButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.AttributeNameLabel = new System.Windows.Forms.Label();
            this.AttributeTypeLabel = new System.Windows.Forms.Label();
            this.DownArrow = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TypesListLabel = new System.Windows.Forms.Label();
            this.newTypeTextBox = new System.Windows.Forms.TextBox();
            this.AddEnumValueButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ClearEnumValuesButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AttributeNameTextBox
            // 
            this.AttributeNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AttributeNameTextBox.Location = new System.Drawing.Point(32, 16);
            this.AttributeNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.AttributeNameTextBox.Name = "AttributeNameTextBox";
            this.AttributeNameTextBox.Size = new System.Drawing.Size(186, 29);
            this.AttributeNameTextBox.TabIndex = 0;
            this.AttributeNameTextBox.Text = "Przykładowa Nazwa";
            // 
            // AttributeTypeComboBox
            // 
            this.AttributeTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AttributeTypeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AttributeTypeComboBox.FormattingEnabled = true;
            this.AttributeTypeComboBox.Items.AddRange(new object[] {
            "Wybierz typ",
            "Tekst",
            "Liczba (całkowita)",
            "Liczba (rzeczywista)",
            "Prawda/Fałsz",
            "Data",
            "Typ wybierany"});
            this.AttributeTypeComboBox.Location = new System.Drawing.Point(258, 16);
            this.AttributeTypeComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.AttributeTypeComboBox.Name = "AttributeTypeComboBox";
            this.AttributeTypeComboBox.Size = new System.Drawing.Size(156, 32);
            this.AttributeTypeComboBox.TabIndex = 1;
            // 
            // CanBeEmptyCheckBox
            // 
            this.CanBeEmptyCheckBox.AutoSize = true;
            this.CanBeEmptyCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CanBeEmptyCheckBox.Location = new System.Drawing.Point(480, 18);
            this.CanBeEmptyCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.CanBeEmptyCheckBox.Name = "CanBeEmptyCheckBox";
            this.CanBeEmptyCheckBox.Size = new System.Drawing.Size(172, 28);
            this.CanBeEmptyCheckBox.TabIndex = 2;
            this.CanBeEmptyCheckBox.Text = "Może być puste?";
            this.CanBeEmptyCheckBox.UseVisualStyleBackColor = true;
            // 
            // ConfirmAndEditButton
            // 
            this.ConfirmAndEditButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ConfirmAndEditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ConfirmAndEditButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ConfirmAndEditButton.Location = new System.Drawing.Point(685, 13);
            this.ConfirmAndEditButton.Margin = new System.Windows.Forms.Padding(2);
            this.ConfirmAndEditButton.Name = "ConfirmAndEditButton";
            this.ConfirmAndEditButton.Size = new System.Drawing.Size(93, 36);
            this.ConfirmAndEditButton.TabIndex = 3;
            this.ConfirmAndEditButton.Text = "Zatwierdź";
            this.ConfirmAndEditButton.UseVisualStyleBackColor = false;
            this.ConfirmAndEditButton.Click += new System.EventHandler(this.ConfirmAndEditButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.BackColor = System.Drawing.SystemColors.Control;
            this.RemoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RemoveButton.ForeColor = System.Drawing.Color.Red;
            this.RemoveButton.Location = new System.Drawing.Point(806, 15);
            this.RemoveButton.Margin = new System.Windows.Forms.Padding(2);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(73, 31);
            this.RemoveButton.TabIndex = 4;
            this.RemoveButton.Text = "Usuń";
            this.RemoveButton.UseVisualStyleBackColor = false;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // AttributeNameLabel
            // 
            this.AttributeNameLabel.AutoSize = true;
            this.AttributeNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AttributeNameLabel.Location = new System.Drawing.Point(28, 20);
            this.AttributeNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AttributeNameLabel.Name = "AttributeNameLabel";
            this.AttributeNameLabel.Size = new System.Drawing.Size(181, 24);
            this.AttributeNameLabel.TabIndex = 5;
            this.AttributeNameLabel.Text = "Przykładowa Nazwa";
            this.AttributeNameLabel.Visible = false;
            // 
            // AttributeTypeLabel
            // 
            this.AttributeTypeLabel.AutoSize = true;
            this.AttributeTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AttributeTypeLabel.Location = new System.Drawing.Point(262, 20);
            this.AttributeTypeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AttributeTypeLabel.Name = "AttributeTypeLabel";
            this.AttributeTypeLabel.Size = new System.Drawing.Size(155, 24);
            this.AttributeTypeLabel.TabIndex = 6;
            this.AttributeTypeLabel.Text = "Przykładowy Typ";
            this.AttributeTypeLabel.Visible = false;
            this.AttributeTypeLabel.Click += new System.EventHandler(this.AttributeTypeLabel_Click);
            // 
            // DownArrow
            // 
            this.DownArrow.AutoSize = true;
            this.DownArrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DownArrow.Location = new System.Drawing.Point(431, 10);
            this.DownArrow.Name = "DownArrow";
            this.DownArrow.Size = new System.Drawing.Size(35, 39);
            this.DownArrow.TabIndex = 7;
            this.DownArrow.Text = "↓";
            this.DownArrow.Click += new System.EventHandler(this.DownArrow_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ClearEnumValuesButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.AddEnumValueButton);
            this.panel1.Controls.Add(this.newTypeTextBox);
            this.panel1.Controls.Add(this.TypesListLabel);
            this.panel1.Location = new System.Drawing.Point(32, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(847, 76);
            this.panel1.TabIndex = 8;
            // 
            // TypesListLabel
            // 
            this.TypesListLabel.AutoSize = true;
            this.TypesListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TypesListLabel.Location = new System.Drawing.Point(27, 10);
            this.TypesListLabel.Name = "TypesListLabel";
            this.TypesListLabel.Size = new System.Drawing.Size(0, 20);
            this.TypesListLabel.TabIndex = 0;
            // 
            // newTypeTextBox
            // 
            this.newTypeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.newTypeTextBox.Location = new System.Drawing.Point(356, 45);
            this.newTypeTextBox.Name = "newTypeTextBox";
            this.newTypeTextBox.Size = new System.Drawing.Size(144, 26);
            this.newTypeTextBox.TabIndex = 1;
            // 
            // AddEnumValueButton
            // 
            this.AddEnumValueButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddEnumValueButton.Location = new System.Drawing.Point(528, 43);
            this.AddEnumValueButton.Name = "AddEnumValueButton";
            this.AddEnumValueButton.Size = new System.Drawing.Size(92, 28);
            this.AddEnumValueButton.TabIndex = 2;
            this.AddEnumValueButton.Text = "Dodaj";
            this.AddEnumValueButton.UseVisualStyleBackColor = true;
            this.AddEnumValueButton.Click += new System.EventHandler(this.AddEnumValueButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(98, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dodaj pojedyncze typy wyboru";
            // 
            // ClearEnumValuesButton
            // 
            this.ClearEnumValuesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ClearEnumValuesButton.Location = new System.Drawing.Point(653, 43);
            this.ClearEnumValuesButton.Name = "ClearEnumValuesButton";
            this.ClearEnumValuesButton.Size = new System.Drawing.Size(92, 28);
            this.ClearEnumValuesButton.TabIndex = 4;
            this.ClearEnumValuesButton.Text = "Wyczyść";
            this.ClearEnumValuesButton.UseVisualStyleBackColor = true;
            this.ClearEnumValuesButton.Click += new System.EventHandler(this.ClearEnumValuesButton_Click);
            // 
            // AttributeSlice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DownArrow);
            this.Controls.Add(this.AttributeTypeLabel);
            this.Controls.Add(this.AttributeNameLabel);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.ConfirmAndEditButton);
            this.Controls.Add(this.CanBeEmptyCheckBox);
            this.Controls.Add(this.AttributeTypeComboBox);
            this.Controls.Add(this.AttributeNameTextBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AttributeSlice";
            this.Size = new System.Drawing.Size(900, 149);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AttributeNameTextBox;
        private System.Windows.Forms.ComboBox AttributeTypeComboBox;
        private System.Windows.Forms.CheckBox CanBeEmptyCheckBox;
        private System.Windows.Forms.Button ConfirmAndEditButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Label AttributeNameLabel;
        private System.Windows.Forms.Label AttributeTypeLabel;
        private System.Windows.Forms.Label DownArrow;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddEnumValueButton;
        private System.Windows.Forms.TextBox newTypeTextBox;
        private System.Windows.Forms.Label TypesListLabel;
        private System.Windows.Forms.Button ClearEnumValuesButton;
    }
}

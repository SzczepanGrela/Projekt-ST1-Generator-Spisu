﻿namespace Generator_Spisu.UserControls
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
            this.ArrowLabel = new System.Windows.Forms.Label();
            this.ExpandedPanel = new System.Windows.Forms.Panel();
            this.ClearEnumValuesButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AddEnumValueButton = new System.Windows.Forms.Button();
            this.newTypeTextBox = new System.Windows.Forms.TextBox();
            this.columnWidthUpDown = new System.Windows.Forms.NumericUpDown();
            this.isBoldCheckBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TypesListTextBox = new System.Windows.Forms.RichTextBox();
            this.ExpandedPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.columnWidthUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // AttributeNameTextBox
            // 
            this.AttributeNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AttributeNameTextBox.Location = new System.Drawing.Point(43, 20);
            this.AttributeNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AttributeNameTextBox.Name = "AttributeNameTextBox";
            this.AttributeNameTextBox.Size = new System.Drawing.Size(247, 34);
            this.AttributeNameTextBox.TabIndex = 0;
            this.AttributeNameTextBox.Text = "Przykładowa Nazwa";
            // 
            // AttributeTypeComboBox
            // 
            this.AttributeTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AttributeTypeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AttributeTypeComboBox.FormattingEnabled = true;
            this.AttributeTypeComboBox.Items.AddRange(new object[] {
            "Tekst",
            "Liczba (całkowita)",
            "Liczba (rzeczywista)",
            "Prawda/Fałsz",
            "Data",
            "Typ wybierany"});
            this.AttributeTypeComboBox.Location = new System.Drawing.Point(344, 20);
            this.AttributeTypeComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AttributeTypeComboBox.Name = "AttributeTypeComboBox";
            this.AttributeTypeComboBox.Size = new System.Drawing.Size(207, 37);
            this.AttributeTypeComboBox.TabIndex = 1;
            // 
            // CanBeEmptyCheckBox
            // 
            this.CanBeEmptyCheckBox.AutoSize = true;
            this.CanBeEmptyCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CanBeEmptyCheckBox.Location = new System.Drawing.Point(640, 22);
            this.CanBeEmptyCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CanBeEmptyCheckBox.Name = "CanBeEmptyCheckBox";
            this.CanBeEmptyCheckBox.Size = new System.Drawing.Size(214, 33);
            this.CanBeEmptyCheckBox.TabIndex = 2;
            this.CanBeEmptyCheckBox.Text = "Może być puste?";
            this.CanBeEmptyCheckBox.UseVisualStyleBackColor = true;
            // 
            // ConfirmAndEditButton
            // 
            this.ConfirmAndEditButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ConfirmAndEditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ConfirmAndEditButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ConfirmAndEditButton.Location = new System.Drawing.Point(913, 16);
            this.ConfirmAndEditButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ConfirmAndEditButton.Name = "ConfirmAndEditButton";
            this.ConfirmAndEditButton.Size = new System.Drawing.Size(124, 44);
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
            this.RemoveButton.Location = new System.Drawing.Point(1075, 18);
            this.RemoveButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(97, 38);
            this.RemoveButton.TabIndex = 4;
            this.RemoveButton.Text = "Usuń";
            this.RemoveButton.UseVisualStyleBackColor = false;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // AttributeNameLabel
            // 
            this.AttributeNameLabel.AutoSize = true;
            this.AttributeNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AttributeNameLabel.Location = new System.Drawing.Point(37, 25);
            this.AttributeNameLabel.Name = "AttributeNameLabel";
            this.AttributeNameLabel.Size = new System.Drawing.Size(231, 29);
            this.AttributeNameLabel.TabIndex = 5;
            this.AttributeNameLabel.Text = "Przykładowa Nazwa";
            this.AttributeNameLabel.Visible = false;
            // 
            // ArrowLabel
            // 
            this.ArrowLabel.AutoSize = true;
            this.ArrowLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ArrowLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ArrowLabel.Location = new System.Drawing.Point(575, 20);
            this.ArrowLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ArrowLabel.Name = "ArrowLabel";
            this.ArrowLabel.Size = new System.Drawing.Size(42, 48);
            this.ArrowLabel.TabIndex = 7;
            this.ArrowLabel.Text = "↓";
            this.ArrowLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ArrowLabel.Click += new System.EventHandler(this.Arrow_Click);
            // 
            // ExpandedPanel
            // 
            this.ExpandedPanel.Controls.Add(this.TypesListTextBox);
            this.ExpandedPanel.Controls.Add(this.label2);
            this.ExpandedPanel.Controls.Add(this.isBoldCheckBox);
            this.ExpandedPanel.Controls.Add(this.columnWidthUpDown);
            this.ExpandedPanel.Controls.Add(this.ClearEnumValuesButton);
            this.ExpandedPanel.Controls.Add(this.label1);
            this.ExpandedPanel.Controls.Add(this.AddEnumValueButton);
            this.ExpandedPanel.Controls.Add(this.newTypeTextBox);
            this.ExpandedPanel.Location = new System.Drawing.Point(43, 86);
            this.ExpandedPanel.Margin = new System.Windows.Forms.Padding(4);
            this.ExpandedPanel.Name = "ExpandedPanel";
            this.ExpandedPanel.Size = new System.Drawing.Size(1129, 94);
            this.ExpandedPanel.TabIndex = 8;
            // 
            // ClearEnumValuesButton
            // 
            this.ClearEnumValuesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ClearEnumValuesButton.Location = new System.Drawing.Point(505, 7);
            this.ClearEnumValuesButton.Margin = new System.Windows.Forms.Padding(4);
            this.ClearEnumValuesButton.Name = "ClearEnumValuesButton";
            this.ClearEnumValuesButton.Size = new System.Drawing.Size(123, 34);
            this.ClearEnumValuesButton.TabIndex = 4;
            this.ClearEnumValuesButton.Text = "Wyczyść";
            this.ClearEnumValuesButton.UseVisualStyleBackColor = true;
            this.ClearEnumValuesButton.Click += new System.EventHandler(this.ClearEnumValuesButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(6, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dodaj pojedyncze typy wyboru";
            // 
            // AddEnumValueButton
            // 
            this.AddEnumValueButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddEnumValueButton.Location = new System.Drawing.Point(505, 53);
            this.AddEnumValueButton.Margin = new System.Windows.Forms.Padding(4);
            this.AddEnumValueButton.Name = "AddEnumValueButton";
            this.AddEnumValueButton.Size = new System.Drawing.Size(123, 34);
            this.AddEnumValueButton.TabIndex = 2;
            this.AddEnumValueButton.Text = "Dodaj";
            this.AddEnumValueButton.UseVisualStyleBackColor = true;
            this.AddEnumValueButton.Click += new System.EventHandler(this.AddEnumValueButton_Click);
            // 
            // newTypeTextBox
            // 
            this.newTypeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.newTypeTextBox.Location = new System.Drawing.Point(293, 55);
            this.newTypeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.newTypeTextBox.Name = "newTypeTextBox";
            this.newTypeTextBox.Size = new System.Drawing.Size(191, 30);
            this.newTypeTextBox.TabIndex = 1;
            // 
            // columnWidthUpDown
            // 
            this.columnWidthUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.columnWidthUpDown.Location = new System.Drawing.Point(837, 35);
            this.columnWidthUpDown.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.columnWidthUpDown.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.columnWidthUpDown.Name = "columnWidthUpDown";
            this.columnWidthUpDown.Size = new System.Drawing.Size(70, 30);
            this.columnWidthUpDown.TabIndex = 5;
            this.columnWidthUpDown.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            // 
            // isBoldCheckBox
            // 
            this.isBoldCheckBox.AutoSize = true;
            this.isBoldCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.isBoldCheckBox.Location = new System.Drawing.Point(927, 35);
            this.isBoldCheckBox.Name = "isBoldCheckBox";
            this.isBoldCheckBox.Size = new System.Drawing.Size(196, 30);
            this.isBoldCheckBox.TabIndex = 9;
            this.isBoldCheckBox.Text = "Pogrubiony tekst";
            this.isBoldCheckBox.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(642, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Szerokość kolumny";
            // 
            // TypesListTextBox
            // 
            this.TypesListTextBox.BackColor = System.Drawing.Color.DarkGray;
            this.TypesListTextBox.Enabled = false;
            this.TypesListTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TypesListTextBox.Location = new System.Drawing.Point(3, 2);
            this.TypesListTextBox.Name = "TypesListTextBox";
            this.TypesListTextBox.ReadOnly = true;
            this.TypesListTextBox.Size = new System.Drawing.Size(481, 49);
            this.TypesListTextBox.TabIndex = 11;
            this.TypesListTextBox.Text = "";
            // 
            // AttributeSlice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.ExpandedPanel);
            this.Controls.Add(this.ArrowLabel);
            this.Controls.Add(this.AttributeNameLabel);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.ConfirmAndEditButton);
            this.Controls.Add(this.CanBeEmptyCheckBox);
            this.Controls.Add(this.AttributeTypeComboBox);
            this.Controls.Add(this.AttributeNameTextBox);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AttributeSlice";
            this.Size = new System.Drawing.Size(1198, 82);
            this.ExpandedPanel.ResumeLayout(false);
            this.ExpandedPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.columnWidthUpDown)).EndInit();
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
        private System.Windows.Forms.Label ArrowLabel;
        private System.Windows.Forms.Panel ExpandedPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddEnumValueButton;
        private System.Windows.Forms.TextBox newTypeTextBox;
        private System.Windows.Forms.Button ClearEnumValuesButton;
        private System.Windows.Forms.RichTextBox TypesListTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox isBoldCheckBox;
        private System.Windows.Forms.NumericUpDown columnWidthUpDown;
    }
}

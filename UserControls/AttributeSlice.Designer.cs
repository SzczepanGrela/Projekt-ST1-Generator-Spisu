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
            this.SuspendLayout();
            // 
            // AttributeNameTextBox
            // 
            this.AttributeNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AttributeNameTextBox.Location = new System.Drawing.Point(32, 16);
            this.AttributeNameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            "Data"});
            this.AttributeTypeComboBox.Location = new System.Drawing.Point(258, 16);
            this.AttributeTypeComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AttributeTypeComboBox.Name = "AttributeTypeComboBox";
            this.AttributeTypeComboBox.Size = new System.Drawing.Size(156, 32);
            this.AttributeTypeComboBox.TabIndex = 1;
            // 
            // CanBeEmptyCheckBox
            // 
            this.CanBeEmptyCheckBox.AutoSize = true;
            this.CanBeEmptyCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CanBeEmptyCheckBox.Location = new System.Drawing.Point(480, 18);
            this.CanBeEmptyCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.ConfirmAndEditButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.RemoveButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            // 
            // AttributeSlice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AttributeTypeLabel);
            this.Controls.Add(this.AttributeNameLabel);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.ConfirmAndEditButton);
            this.Controls.Add(this.CanBeEmptyCheckBox);
            this.Controls.Add(this.AttributeTypeComboBox);
            this.Controls.Add(this.AttributeNameTextBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AttributeSlice";
            this.Size = new System.Drawing.Size(900, 63);
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
    }
}

namespace Generator_Spisu.UserControls
{
    partial class AttributeSingleForm
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
            this.InsertPanel = new System.Windows.Forms.Panel();
            this.TextPanel = new System.Windows.Forms.Panel();
            this.PropertyNameLabel = new System.Windows.Forms.Label();
            this.TextPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // InsertPanel
            // 
            this.InsertPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.InsertPanel.Location = new System.Drawing.Point(0, 49);
            this.InsertPanel.Name = "InsertPanel";
            this.InsertPanel.Size = new System.Drawing.Size(186, 51);
            this.InsertPanel.TabIndex = 0;
            // 
            // TextPanel
            // 
            this.TextPanel.Controls.Add(this.PropertyNameLabel);
            this.TextPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextPanel.Location = new System.Drawing.Point(0, 0);
            this.TextPanel.Name = "TextPanel";
            this.TextPanel.Size = new System.Drawing.Size(186, 49);
            this.TextPanel.TabIndex = 1;
            // 
            // PropertyNameLabel
            // 
            this.PropertyNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PropertyNameLabel.AutoSize = true;
            this.PropertyNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PropertyNameLabel.Location = new System.Drawing.Point(51, 11);
            this.PropertyNameLabel.Name = "PropertyNameLabel";
            this.PropertyNameLabel.Size = new System.Drawing.Size(79, 26);
            this.PropertyNameLabel.TabIndex = 2;
            this.PropertyNameLabel.Text = "Nazwa";
            // 
            // AttributeSingleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TextPanel);
            this.Controls.Add(this.InsertPanel);
            this.Name = "AttributeSingleForm";
            this.Size = new System.Drawing.Size(186, 100);
            this.TextPanel.ResumeLayout(false);
            this.TextPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel InsertPanel;
        private System.Windows.Forms.Panel TextPanel;
        private System.Windows.Forms.Label PropertyNameLabel;
    }
}

namespace Generator_Spisu.UserControls
{
    partial class DataDisplayCell
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
            this.ValueLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ValueLabel
            // 
            this.ValueLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ValueLabel.AutoSize = true;
            this.ValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ValueLabel.Location = new System.Drawing.Point(18, 27);
            this.ValueLabel.MinimumSize = new System.Drawing.Size(46, 20);
            this.ValueLabel.Name = "ValueLabel";
            this.ValueLabel.Size = new System.Drawing.Size(53, 22);
            this.ValueLabel.TabIndex = 0;
            this.ValueLabel.Text = "value";
            // 
            // DataDisplayCell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.ValueLabel);
            this.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.MinimumSize = new System.Drawing.Size(50, 77);
            this.Name = "DataDisplayCell";
            this.Size = new System.Drawing.Size(92, 75);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ValueLabel;
    }
}

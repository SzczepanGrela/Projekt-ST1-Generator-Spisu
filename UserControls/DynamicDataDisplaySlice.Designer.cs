namespace Generator_Spisu.UserControls
{
    partial class DynamicDataDisplaySlice
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
            this.DeleteRecordButton = new System.Windows.Forms.Button();
            this.EditRecordButton = new System.Windows.Forms.Button();
            this.ButtonsPanel = new System.Windows.Forms.Panel();
            this.DataDisplayPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ButtonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DeleteRecordButton
            // 
            this.DeleteRecordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DeleteRecordButton.Location = new System.Drawing.Point(9, 16);
            this.DeleteRecordButton.Name = "DeleteRecordButton";
            this.DeleteRecordButton.Size = new System.Drawing.Size(48, 48);
            this.DeleteRecordButton.TabIndex = 0;
            this.DeleteRecordButton.Text = "X";
            this.DeleteRecordButton.UseVisualStyleBackColor = true;
            // 
            // EditRecordButton
            // 
            this.EditRecordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EditRecordButton.Location = new System.Drawing.Point(70, 25);
            this.EditRecordButton.Name = "EditRecordButton";
            this.EditRecordButton.Size = new System.Drawing.Size(80, 30);
            this.EditRecordButton.TabIndex = 1;
            this.EditRecordButton.Text = "Edytuj";
            this.EditRecordButton.UseVisualStyleBackColor = true;
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.Controls.Add(this.EditRecordButton);
            this.ButtonsPanel.Controls.Add(this.DeleteRecordButton);
            this.ButtonsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ButtonsPanel.Location = new System.Drawing.Point(0, 0);
            this.ButtonsPanel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.Size = new System.Drawing.Size(162, 77);
            this.ButtonsPanel.TabIndex = 2;
            // 
            // DataDisplayPanel
            // 
            this.DataDisplayPanel.AutoSize = true;
            this.DataDisplayPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataDisplayPanel.Location = new System.Drawing.Point(162, 0);
            this.DataDisplayPanel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.DataDisplayPanel.MinimumSize = new System.Drawing.Size(530, 77);
            this.DataDisplayPanel.Name = "DataDisplayPanel";
            this.DataDisplayPanel.Size = new System.Drawing.Size(568, 77);
            this.DataDisplayPanel.TabIndex = 0;
            this.DataDisplayPanel.WrapContents = false;
            // 
            // DynamicDataDisplaySlice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Controls.Add(this.DataDisplayPanel);
            this.Controls.Add(this.ButtonsPanel);
            this.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.Name = "DynamicDataDisplaySlice";
            this.Size = new System.Drawing.Size(730, 77);
            this.ButtonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DeleteRecordButton;
        private System.Windows.Forms.Button EditRecordButton;
        private System.Windows.Forms.Panel ButtonsPanel;
        private System.Windows.Forms.FlowLayoutPanel DataDisplayPanel;
    }
}

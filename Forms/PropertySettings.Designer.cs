namespace Generator_Spisu.Forms
{
    partial class PropertySettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MessageLabel = new System.Windows.Forms.Label();
            this.SetAttributesButton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SaveToJsonButton = new System.Windows.Forms.Button();
            this.addSliceButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SlicePanel = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MessageLabel.Location = new System.Drawing.Point(412, 32);
            this.MessageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(474, 39);
            this.MessageLabel.TabIndex = 0;
            this.MessageLabel.Text = "Nazwij atrybuty i nadaj im typy";
            this.MessageLabel.Click += new System.EventHandler(this.MessageLabel_Click);
            // 
            // SetAttributesButton
            // 
            this.SetAttributesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SetAttributesButton.Location = new System.Drawing.Point(592, 16);
            this.SetAttributesButton.Margin = new System.Windows.Forms.Padding(4);
            this.SetAttributesButton.Name = "SetAttributesButton";
            this.SetAttributesButton.Size = new System.Drawing.Size(151, 64);
            this.SetAttributesButton.TabIndex = 1;
            this.SetAttributesButton.Text = "Ustaw";
            this.SetAttributesButton.UseVisualStyleBackColor = true;
            this.SetAttributesButton.Click += new System.EventHandler(this.SetSettings_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(415, 73);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 20);
            this.label11.TabIndex = 31;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.SaveToJsonButton);
            this.panel2.Controls.Add(this.addSliceButton);
            this.panel2.Controls.Add(this.SetAttributesButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 677);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1309, 100);
            this.panel2.TabIndex = 33;
            // 
            // SaveToJsonButton
            // 
            this.SaveToJsonButton.BackColor = System.Drawing.Color.MistyRose;
            this.SaveToJsonButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SaveToJsonButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SaveToJsonButton.Location = new System.Drawing.Point(1125, 23);
            this.SaveToJsonButton.Margin = new System.Windows.Forms.Padding(4);
            this.SaveToJsonButton.Name = "SaveToJsonButton";
            this.SaveToJsonButton.Size = new System.Drawing.Size(125, 52);
            this.SaveToJsonButton.TabIndex = 3;
            this.SaveToJsonButton.Text = "Zapisz";
            this.SaveToJsonButton.UseVisualStyleBackColor = false;
            this.SaveToJsonButton.Click += new System.EventHandler(this.SaveToJsonButton_Click);
            // 
            // addSliceButton
            // 
            this.addSliceButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.addSliceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addSliceButton.ForeColor = System.Drawing.Color.Bisque;
            this.addSliceButton.Location = new System.Drawing.Point(59, 23);
            this.addSliceButton.Margin = new System.Windows.Forms.Padding(4);
            this.addSliceButton.Name = "addSliceButton";
            this.addSliceButton.Size = new System.Drawing.Size(125, 52);
            this.addSliceButton.TabIndex = 2;
            this.addSliceButton.Text = "Dodaj";
            this.addSliceButton.UseVisualStyleBackColor = false;
            this.addSliceButton.Click += new System.EventHandler(this.addSliceButton_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.MessageLabel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1309, 100);
            this.panel3.TabIndex = 34;
            // 
            // SlicePanel
            // 
            this.SlicePanel.AutoScroll = true;
            this.SlicePanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SlicePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SlicePanel.Location = new System.Drawing.Point(0, 100);
            this.SlicePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SlicePanel.Name = "SlicePanel";
            this.SlicePanel.Size = new System.Drawing.Size(1309, 577);
            this.SlicePanel.TabIndex = 35;
            // 
            // PropertySettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 777);
            this.Controls.Add(this.SlicePanel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label11);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PropertySettings";
            this.Text = "PropertySettings";
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MessageLabel;
        private System.Windows.Forms.Button SetAttributesButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel SlicePanel;
        private System.Windows.Forms.Button addSliceButton;
        private System.Windows.Forms.Button SaveToJsonButton;
    }
}
namespace Generator_Spisu
{
    partial class MainWindow
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

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nowyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszJakoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zamknijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wyczyśćToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stwórzDocxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ustawieniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atrybutyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oAplikacjiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informacjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.SplitContainer = new System.Windows.Forms.SplitContainer();
            this.AttributesPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ButtonPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ScrollablePanel = new System.Windows.Forms.Panel();
            this.AttributeNamesPanel = new System.Windows.Forms.Panel();
            this.DataSlicePanel = new System.Windows.Forms.Panel();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).BeginInit();
            this.SplitContainer.Panel1.SuspendLayout();
            this.SplitContainer.Panel2.SuspendLayout();
            this.SplitContainer.SuspendLayout();
            this.ButtonPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.ScrollablePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.generujToolStripMenuItem,
            this.ustawieniaToolStripMenuItem,
            this.oAplikacjiToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip2.Size = new System.Drawing.Size(782, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nowyToolStripMenuItem,
            this.zapiszToolStripMenuItem,
            this.zapiszToolStripMenuItem1,
            this.zapiszJakoToolStripMenuItem,
            this.zamknijToolStripMenuItem,
            this.wyczyśćToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // nowyToolStripMenuItem
            // 
            this.nowyToolStripMenuItem.Name = "nowyToolStripMenuItem";
            this.nowyToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.nowyToolStripMenuItem.Text = "Nowy";
            this.nowyToolStripMenuItem.Click += new System.EventHandler(this.nowyToolStripMenuItem_Click);
            // 
            // zapiszToolStripMenuItem
            // 
            this.zapiszToolStripMenuItem.Name = "zapiszToolStripMenuItem";
            this.zapiszToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.zapiszToolStripMenuItem.Text = "Otwórz";
            this.zapiszToolStripMenuItem.Click += new System.EventHandler(this.otwórzToolStripMenuItem_Click);
            // 
            // zapiszToolStripMenuItem1
            // 
            this.zapiszToolStripMenuItem1.Name = "zapiszToolStripMenuItem1";
            this.zapiszToolStripMenuItem1.Size = new System.Drawing.Size(132, 22);
            this.zapiszToolStripMenuItem1.Text = "Zapisz";
            this.zapiszToolStripMenuItem1.Click += new System.EventHandler(this.zapiszToolStripMenuItem_Click);
            // 
            // zapiszJakoToolStripMenuItem
            // 
            this.zapiszJakoToolStripMenuItem.Name = "zapiszJakoToolStripMenuItem";
            this.zapiszJakoToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.zapiszJakoToolStripMenuItem.Text = "Zapisz jako";
            this.zapiszJakoToolStripMenuItem.Click += new System.EventHandler(this.zapiszJakoToolStripMenuItem_Click);
            // 
            // zamknijToolStripMenuItem
            // 
            this.zamknijToolStripMenuItem.Name = "zamknijToolStripMenuItem";
            this.zamknijToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.zamknijToolStripMenuItem.Text = "Zamknij";
            this.zamknijToolStripMenuItem.Click += new System.EventHandler(this.zamknijToolStripMenuItem_Click);
            // 
            // wyczyśćToolStripMenuItem
            // 
            this.wyczyśćToolStripMenuItem.Name = "wyczyśćToolStripMenuItem";
            this.wyczyśćToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.wyczyśćToolStripMenuItem.Text = "Wyczyść";
            this.wyczyśćToolStripMenuItem.Click += new System.EventHandler(this.wyczyśćToolStripMenuItem_Click);
            // 
            // generujToolStripMenuItem
            // 
            this.generujToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stwórzDocxToolStripMenuItem});
            this.generujToolStripMenuItem.Name = "generujToolStripMenuItem";
            this.generujToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.generujToolStripMenuItem.Text = "Generuj";
            // 
            // stwórzDocxToolStripMenuItem
            // 
            this.stwórzDocxToolStripMenuItem.Name = "stwórzDocxToolStripMenuItem";
            this.stwórzDocxToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.stwórzDocxToolStripMenuItem.Text = "Stwórz docx";
            this.stwórzDocxToolStripMenuItem.Click += new System.EventHandler(this.stwórzDocxToolStripMenuItem_Click);
            // 
            // ustawieniaToolStripMenuItem
            // 
            this.ustawieniaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atrybutyToolStripMenuItem});
            this.ustawieniaToolStripMenuItem.Name = "ustawieniaToolStripMenuItem";
            this.ustawieniaToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.ustawieniaToolStripMenuItem.Text = "Ustawienia";
            // 
            // atrybutyToolStripMenuItem
            // 
            this.atrybutyToolStripMenuItem.Name = "atrybutyToolStripMenuItem";
            this.atrybutyToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.atrybutyToolStripMenuItem.Text = "Atrybuty";
            this.atrybutyToolStripMenuItem.Click += new System.EventHandler(this.atrybutyToolStripMenuItem_Click);
            // 
            // oAplikacjiToolStripMenuItem
            // 
            this.oAplikacjiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informacjeToolStripMenuItem});
            this.oAplikacjiToolStripMenuItem.Name = "oAplikacjiToolStripMenuItem";
            this.oAplikacjiToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.oAplikacjiToolStripMenuItem.Text = "Info";
            // 
            // informacjeToolStripMenuItem
            // 
            this.informacjeToolStripMenuItem.Name = "informacjeToolStripMenuItem";
            this.informacjeToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.informacjeToolStripMenuItem.Text = "O aplikacji";
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ConfirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ConfirmButton.Location = new System.Drawing.Point(333, 4);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(122, 32);
            this.ConfirmButton.TabIndex = 2;
            this.ConfirmButton.Text = "Zatwierdź";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // SplitContainer
            // 
            this.SplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.SplitContainer.Location = new System.Drawing.Point(0, 0);
            this.SplitContainer.Name = "SplitContainer";
            this.SplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SplitContainer.Panel1
            // 
            this.SplitContainer.Panel1.Controls.Add(this.AttributesPanel);
            this.SplitContainer.Panel1.Controls.Add(this.ButtonPanel);
            this.SplitContainer.Panel1.Controls.Add(this.menuStrip2);
            this.SplitContainer.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            this.SplitContainer.Panel1MinSize = 150;
            // 
            // SplitContainer.Panel2
            // 
            this.SplitContainer.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.SplitContainer.Size = new System.Drawing.Size(784, 460);
            this.SplitContainer.SplitterDistance = 164;
            this.SplitContainer.TabIndex = 0;
            // 
            // AttributesPanel
            // 
            this.AttributesPanel.AutoScroll = true;
            this.AttributesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AttributesPanel.Location = new System.Drawing.Point(0, 24);
            this.AttributesPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AttributesPanel.Name = "AttributesPanel";
            this.AttributesPanel.Size = new System.Drawing.Size(782, 96);
            this.AttributesPanel.TabIndex = 4;
            this.AttributesPanel.WrapContents = false;
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.Controls.Add(this.ConfirmButton);
            this.ButtonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtonPanel.Location = new System.Drawing.Point(0, 120);
            this.ButtonPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.Size = new System.Drawing.Size(782, 42);
            this.ButtonPanel.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.ScrollablePanel, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(782, 290);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ScrollablePanel
            // 
            this.ScrollablePanel.AutoScroll = true;
            this.ScrollablePanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ScrollablePanel.Controls.Add(this.DataSlicePanel);
            this.ScrollablePanel.Controls.Add(this.AttributeNamesPanel);
            this.ScrollablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScrollablePanel.Location = new System.Drawing.Point(20, 0);
            this.ScrollablePanel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.ScrollablePanel.Name = "ScrollablePanel";
            this.ScrollablePanel.Size = new System.Drawing.Size(742, 290);
            this.ScrollablePanel.TabIndex = 0;
            // 
            // AttributeNamesPanel
            // 
            this.AttributeNamesPanel.AutoScroll = true;
            this.AttributeNamesPanel.AutoSize = true;
            this.AttributeNamesPanel.BackColor = System.Drawing.SystemColors.Highlight;
            this.AttributeNamesPanel.Location = new System.Drawing.Point(0, 0);
            this.AttributeNamesPanel.Margin = new System.Windows.Forms.Padding(0);
            this.AttributeNamesPanel.Name = "AttributeNamesPanel";
            this.AttributeNamesPanel.Size = new System.Drawing.Size(742, 77);
            this.AttributeNamesPanel.TabIndex = 0;
            // 
            // DataSlicePanel
            // 
            this.DataSlicePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataSlicePanel.AutoScroll = true;
            this.DataSlicePanel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.DataSlicePanel.Location = new System.Drawing.Point(0, 77);
            this.DataSlicePanel.Name = "DataSlicePanel";
            this.DataSlicePanel.Size = new System.Drawing.Size(742, 213);
            this.DataSlicePanel.TabIndex = 1;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 460);
            this.Controls.Add(this.SplitContainer);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(800, 497);
            this.Name = "MainWindow";
            this.Text = "Generator Spisu";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.SplitContainer.Panel1.ResumeLayout(false);
            this.SplitContainer.Panel1.PerformLayout();
            this.SplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).EndInit();
            this.SplitContainer.ResumeLayout(false);
            this.ButtonPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ScrollablePanel.ResumeLayout(false);
            this.ScrollablePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem zapiszJakoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generujToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stwórzDocxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oAplikacjiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informacjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zamknijToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wyczyśćToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ustawieniaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atrybutyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nowyToolStripMenuItem;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.SplitContainer SplitContainer;
        private System.Windows.Forms.Panel ButtonPanel;
        private System.Windows.Forms.FlowLayoutPanel AttributesPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel ScrollablePanel;
        private System.Windows.Forms.Panel AttributeNamesPanel;
        private System.Windows.Forms.Panel DataSlicePanel;
    }
}


namespace TornadoCapture_v2
{
    partial class Mainform
    {

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainform));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToClipboardToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flipHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.flipVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.flipBoth = new System.Windows.Forms.ToolStripMenuItem();
            this.rotateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Rotate90 = new System.Windows.Forms.ToolStripMenuItem();
            this.Rotate180 = new System.Windows.Forms.ToolStripMenuItem();
            this.Rotate270 = new System.Windows.Forms.ToolStripMenuItem();
            this.oCRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.websiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "Click for more instructions";
            this.notifyIcon1.BalloonTipTitle = "How-To:";
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Click for more instructions";
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(86, 26);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShowShortcutKeys = false;
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(85, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 362);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(546, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.copyToClipboardToolStripMenuItem,
            this.pictureToolStripMenuItem,
            this.oCRToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(546, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.printToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.dateiToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.openToolStripMenuItem.Text = "&Save as (S)";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.printToolStripMenuItem.Text = "&Print (P)";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.closeToolStripMenuItem.Text = "&Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // copyToClipboardToolStripMenuItem
            // 
            this.copyToClipboardToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToClipboardToolStripMenuItem1});
            this.copyToClipboardToolStripMenuItem.Name = "copyToClipboardToolStripMenuItem";
            this.copyToClipboardToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.copyToClipboardToolStripMenuItem.Text = "Edit";
            // 
            // copyToClipboardToolStripMenuItem1
            // 
            this.copyToClipboardToolStripMenuItem1.Name = "copyToClipboardToolStripMenuItem1";
            this.copyToClipboardToolStripMenuItem1.Size = new System.Drawing.Size(224, 22);
            this.copyToClipboardToolStripMenuItem1.Text = "&Copy to clipboard (STRG+C)";
            this.copyToClipboardToolStripMenuItem1.Click += new System.EventHandler(this.copyToClipboardToolStripMenuItem1_Click);
            // 
            // pictureToolStripMenuItem
            // 
            this.pictureToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resizeToolStripMenuItem,
            this.invertToolStripMenuItem,
            this.flipToolStripMenuItem,
            this.rotateToolStripMenuItem});
            this.pictureToolStripMenuItem.Name = "pictureToolStripMenuItem";
            this.pictureToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.pictureToolStripMenuItem.Text = "Image";
            // 
            // resizeToolStripMenuItem
            // 
            this.resizeToolStripMenuItem.Name = "resizeToolStripMenuItem";
            this.resizeToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.resizeToolStripMenuItem.Text = "&Resize (R)";
            this.resizeToolStripMenuItem.Click += new System.EventHandler(this.resizeToolStripMenuItem_Click);
            // 
            // invertToolStripMenuItem
            // 
            this.invertToolStripMenuItem.Name = "invertToolStripMenuItem";
            this.invertToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.invertToolStripMenuItem.Text = "&Invert (I)";
            this.invertToolStripMenuItem.Click += new System.EventHandler(this.invertToolStripMenuItem_Click);
            // 
            // flipToolStripMenuItem
            // 
            this.flipToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.flipHorizontal,
            this.flipVertical,
            this.flipBoth});
            this.flipToolStripMenuItem.Name = "flipToolStripMenuItem";
            this.flipToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.flipToolStripMenuItem.Text = "&Flip";
            // 
            // flipHorizontal
            // 
            this.flipHorizontal.Name = "flipHorizontal";
            this.flipHorizontal.Size = new System.Drawing.Size(129, 22);
            this.flipHorizontal.Text = "&Horizontal";
            this.flipHorizontal.Click += new System.EventHandler(this.flipHorizontal_Click);
            // 
            // flipVertical
            // 
            this.flipVertical.Name = "flipVertical";
            this.flipVertical.Size = new System.Drawing.Size(129, 22);
            this.flipVertical.Text = "&Vertical";
            this.flipVertical.Click += new System.EventHandler(this.flipVertical_Click);
            // 
            // flipBoth
            // 
            this.flipBoth.Name = "flipBoth";
            this.flipBoth.Size = new System.Drawing.Size(129, 22);
            this.flipBoth.Text = "&Both";
            this.flipBoth.Click += new System.EventHandler(this.flipBoth_Click);
            // 
            // rotateToolStripMenuItem
            // 
            this.rotateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Rotate90,
            this.Rotate180,
            this.Rotate270});
            this.rotateToolStripMenuItem.Name = "rotateToolStripMenuItem";
            this.rotateToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.rotateToolStripMenuItem.Text = "R&otate";
            // 
            // Rotate90
            // 
            this.Rotate90.Name = "Rotate90";
            this.Rotate90.Size = new System.Drawing.Size(97, 22);
            this.Rotate90.Text = "&90°";
            this.Rotate90.Click += new System.EventHandler(this.Rotate90_Click);
            // 
            // Rotate180
            // 
            this.Rotate180.Name = "Rotate180";
            this.Rotate180.Size = new System.Drawing.Size(97, 22);
            this.Rotate180.Text = "1&80°";
            this.Rotate180.Click += new System.EventHandler(this.Rotate180_Click);
            // 
            // Rotate270
            // 
            this.Rotate270.Name = "Rotate270";
            this.Rotate270.Size = new System.Drawing.Size(97, 22);
            this.Rotate270.Text = "2&70°";
            this.Rotate270.Click += new System.EventHandler(this.Rotate270_Click);
            // 
            // oCRToolStripMenuItem
            // 
            this.oCRToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tryToolStripMenuItem,
            this.languageToolStripMenuItem});
            this.oCRToolStripMenuItem.Name = "oCRToolStripMenuItem";
            this.oCRToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.oCRToolStripMenuItem.Text = "OCR";
           
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // zoomToolStripMenuItem
            // 
            this.zoomToolStripMenuItem.Checked = true;
            this.zoomToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            this.zoomToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.zoomToolStripMenuItem.Text = "&Zoom (F)";
            this.zoomToolStripMenuItem.Click += new System.EventHandler(this.zoomToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerToolStripMenuItem,
            this.websiteToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // registerToolStripMenuItem
            // 
            this.registerToolStripMenuItem.Enabled = false;
            this.registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            this.registerToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.registerToolStripMenuItem.Text = "&Check for updates";
            this.registerToolStripMenuItem.Visible = false;
            // 
            // websiteToolStripMenuItem
            // 
            this.websiteToolStripMenuItem.Name = "websiteToolStripMenuItem";
            this.websiteToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.websiteToolStripMenuItem.Text = "&Website";
            this.websiteToolStripMenuItem.Click += new System.EventHandler(this.websiteToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(546, 332);
            this.panel1.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(546, 332);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            this.languageToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.languageToolStripMenuItem.Text = "Language";
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 384);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Mainform";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TornadoCapture 3.5";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Mainform_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Mainform_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Mainform_KeyPress);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.NotifyIcon notifyIcon1;
        internal System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        internal System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        internal System.Windows.Forms.StatusStrip statusStrip1;
        internal System.Windows.Forms.MenuStrip menuStrip1;
        internal System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem copyToClipboardToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem copyToClipboardToolStripMenuItem1;
        internal System.Windows.Forms.ToolStripMenuItem pictureToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem resizeToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem invertToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem flipToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem flipHorizontal;
        internal System.Windows.Forms.ToolStripMenuItem flipVertical;
        internal System.Windows.Forms.ToolStripMenuItem flipBoth;
        internal System.Windows.Forms.ToolStripMenuItem rotateToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem Rotate90;
        internal System.Windows.Forms.ToolStripMenuItem Rotate180;
        internal System.Windows.Forms.ToolStripMenuItem Rotate270;
        internal System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem registerToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem websiteToolStripMenuItem;
        internal System.Windows.Forms.Timer timer1;
        internal System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.ComponentModel.IContainer components;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem oCRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
    }
}


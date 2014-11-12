namespace TornadoCapture_v2
{
    partial class OCRMask
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OCRMask));
            this.buttonClipboard = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.textresult = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // buttonClipboard
            // 
            this.buttonClipboard.Location = new System.Drawing.Point(303, 212);
            this.buttonClipboard.Name = "buttonClipboard";
            this.buttonClipboard.Size = new System.Drawing.Size(128, 23);
            this.buttonClipboard.TabIndex = 0;
            this.buttonClipboard.Text = "&copy to clipboard";
            this.buttonClipboard.UseVisualStyleBackColor = true;
            this.buttonClipboard.Click += new System.EventHandler(this.buttonClipboard_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(12, 212);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(124, 23);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.Text = "clo&se";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // textresult
            // 
            this.textresult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textresult.Location = new System.Drawing.Point(12, 12);
            this.textresult.Name = "textresult";
            this.textresult.ReadOnly = true;
            this.textresult.Size = new System.Drawing.Size(419, 194);
            this.textresult.TabIndex = 2;
            this.textresult.Text = "";
            // 
            // OCRMask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 247);
            this.Controls.Add(this.textresult);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonClipboard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OCRMask";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "OCR Result";
            this.Load += new System.EventHandler(this.OCRMask_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonClipboard;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.RichTextBox textresult;
    }
}
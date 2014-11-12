namespace TornadoCapture
{
    partial class Infoform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Infoform));
            this.buttonDoSelect = new System.Windows.Forms.Button();
            this.labelStart = new System.Windows.Forms.Label();
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.labelSelection2Clipboard = new System.Windows.Forms.Label();
            this.labelSelection2File = new System.Windows.Forms.Label();
            this.checkboxShowNextTime = new System.Windows.Forms.CheckBox();
            this.groupBoxInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDoSelect
            // 
            this.buttonDoSelect.BackColor = System.Drawing.Color.MediumAquamarine;
            this.buttonDoSelect.BackgroundImage = global::TornadoCapture.Properties.Resources.fenster_auswahlbox3;
            this.buttonDoSelect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonDoSelect.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonDoSelect.Location = new System.Drawing.Point(12, 25);
            this.buttonDoSelect.Name = "buttonDoSelect";
            this.buttonDoSelect.Size = new System.Drawing.Size(77, 79);
            this.buttonDoSelect.TabIndex = 12;
            this.buttonDoSelect.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonDoSelect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonDoSelect.UseVisualStyleBackColor = false;
            this.buttonDoSelect.Click += new System.EventHandler(this.btnDoSelect_Click);
            // 
            // labelStart
            // 
            this.labelStart.AutoSize = true;
            this.labelStart.Location = new System.Drawing.Point(9, 9);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(71, 13);
            this.labelStart.TabIndex = 30;
            this.labelStart.Text = "Start capture:";
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.Controls.Add(this.labelSelection2Clipboard);
            this.groupBoxInfo.Controls.Add(this.labelSelection2File);
            this.groupBoxInfo.Location = new System.Drawing.Point(104, 25);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Size = new System.Drawing.Size(257, 79);
            this.groupBoxInfo.TabIndex = 43;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "Use these shortcuts from anywhere in Windows:";
            // 
            // labelSelection2Clipboard
            // 
            this.labelSelection2Clipboard.AutoSize = true;
            this.labelSelection2Clipboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelection2Clipboard.Location = new System.Drawing.Point(22, 27);
            this.labelSelection2Clipboard.Name = "labelSelection2Clipboard";
            this.labelSelection2Clipboard.Size = new System.Drawing.Size(214, 13);
            this.labelSelection2Clipboard.TabIndex = 43;
            this.labelSelection2Clipboard.Text = "CTRL+ALT+C: selection to clipboard";
            // 
            // labelSelection2File
            // 
            this.labelSelection2File.AutoSize = true;
            this.labelSelection2File.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelection2File.Location = new System.Drawing.Point(22, 47);
            this.labelSelection2File.Name = "labelSelection2File";
            this.labelSelection2File.Size = new System.Drawing.Size(180, 13);
            this.labelSelection2File.TabIndex = 44;
            this.labelSelection2File.Text = "CTRL+ALT+D: selection to file";
            // 
            // checkboxShowNextTime
            // 
            this.checkboxShowNextTime.AutoSize = true;
            this.checkboxShowNextTime.Location = new System.Drawing.Point(206, 110);
            this.checkboxShowNextTime.Name = "checkboxShowNextTime";
            this.checkboxShowNextTime.Size = new System.Drawing.Size(158, 17);
            this.checkboxShowNextTime.TabIndex = 44;
            this.checkboxShowNextTime.Text = "Show this &window at startup";
            this.checkboxShowNextTime.UseVisualStyleBackColor = true;
            this.checkboxShowNextTime.CheckedChanged += new System.EventHandler(this.checkboxShowNextTime_CheckedChanged);
            // 
            // Infoform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 138);
            this.Controls.Add(this.checkboxShowNextTime);
            this.Controls.Add(this.groupBoxInfo);
            this.Controls.Add(this.labelStart);
            this.Controls.Add(this.buttonDoSelect);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Infoform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TornadoCapture 3.5";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Infoform_FormClosed);
            this.Load += new System.EventHandler(this.Infoform_Load);
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDoSelect;
        private System.Windows.Forms.Label labelStart;
        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.Label labelSelection2Clipboard;
        private System.Windows.Forms.Label labelSelection2File;
        private System.Windows.Forms.CheckBox checkboxShowNextTime;
    }
}
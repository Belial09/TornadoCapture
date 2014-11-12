namespace TornadoCapture_v2.Forms
{
    partial class ResizeImage
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtHeightStatic = new System.Windows.Forms.TextBox();
            this.txtWidthStatic = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rbtStatic = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPercentHeight = new System.Windows.Forms.TextBox();
            this.txtPercentWidth = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rbtPercent = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblCurrentSize = new System.Windows.Forms.Label();
            this.lblNewSize = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdClose = new System.Windows.Forms.Button();
            this.cmdResize = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtHeightStatic);
            this.groupBox1.Controls.Add(this.txtWidthStatic);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.rbtStatic);
            this.groupBox1.Location = new System.Drawing.Point(11, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 58);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txtHeightStatic
            // 
            this.txtHeightStatic.Location = new System.Drawing.Point(188, 26);
            this.txtHeightStatic.Name = "txtHeightStatic";
            this.txtHeightStatic.Size = new System.Drawing.Size(48, 20);
            this.txtHeightStatic.TabIndex = 10;
            this.txtHeightStatic.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumbersChecked);
            // 
            // txtWidthStatic
            // 
            this.txtWidthStatic.Location = new System.Drawing.Point(55, 26);
            this.txtWidthStatic.Name = "txtWidthStatic";
            this.txtWidthStatic.Size = new System.Drawing.Size(48, 20);
            this.txtWidthStatic.TabIndex = 9;
            this.txtWidthStatic.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumbersChecked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(144, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Height:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Width:";
            // 
            // rbtStatic
            // 
            this.rbtStatic.AutoSize = true;
            this.rbtStatic.Checked = true;
            this.rbtStatic.Location = new System.Drawing.Point(10, 0);
            this.rbtStatic.Name = "rbtStatic";
            this.rbtStatic.Size = new System.Drawing.Size(85, 17);
            this.rbtStatic.TabIndex = 1;
            this.rbtStatic.TabStop = true;
            this.rbtStatic.Text = "&Set new size";
            this.rbtStatic.UseVisualStyleBackColor = true;
            this.rbtStatic.Click += new System.EventHandler(this.SetRadioButton);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtPercentHeight);
            this.groupBox2.Controls.Add(this.txtPercentWidth);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.rbtPercent);
            this.groupBox2.Location = new System.Drawing.Point(11, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(264, 64);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(242, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "%";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(109, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "%";
            // 
            // txtPercentHeight
            // 
            this.txtPercentHeight.Enabled = false;
            this.txtPercentHeight.Location = new System.Drawing.Point(188, 27);
            this.txtPercentHeight.Name = "txtPercentHeight";
            this.txtPercentHeight.Size = new System.Drawing.Size(48, 20);
            this.txtPercentHeight.TabIndex = 14;
            this.txtPercentHeight.Text = "100";
            this.txtPercentHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumbersChecked);
            // 
            // txtPercentWidth
            // 
            this.txtPercentWidth.Enabled = false;
            this.txtPercentWidth.Location = new System.Drawing.Point(55, 27);
            this.txtPercentWidth.Name = "txtPercentWidth";
            this.txtPercentWidth.Size = new System.Drawing.Size(48, 20);
            this.txtPercentWidth.TabIndex = 13;
            this.txtPercentWidth.Text = "100";
            this.txtPercentWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumbersChecked);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(144, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Height:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Width:";
            // 
            // rbtPercent
            // 
            this.rbtPercent.AutoSize = true;
            this.rbtPercent.Location = new System.Drawing.Point(10, 0);
            this.rbtPercent.Name = "rbtPercent";
            this.rbtPercent.Size = new System.Drawing.Size(187, 17);
            this.rbtPercent.TabIndex = 0;
            this.rbtPercent.TabStop = true;
            this.rbtPercent.Text = "New size as &percentage of original";
            this.rbtPercent.UseVisualStyleBackColor = true;
            this.rbtPercent.Click += new System.EventHandler(this.SetRadioButton);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblCurrentSize);
            this.groupBox3.Controls.Add(this.lblNewSize);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(11, 142);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(264, 64);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // lblCurrentSize
            // 
            this.lblCurrentSize.AutoSize = true;
            this.lblCurrentSize.Location = new System.Drawing.Point(79, 39);
            this.lblCurrentSize.Name = "lblCurrentSize";
            this.lblCurrentSize.Size = new System.Drawing.Size(60, 13);
            this.lblCurrentSize.TabIndex = 3;
            this.lblCurrentSize.Text = "1440 x 900";
            // 
            // lblNewSize
            // 
            this.lblNewSize.AutoSize = true;
            this.lblNewSize.Location = new System.Drawing.Point(79, 17);
            this.lblNewSize.Name = "lblNewSize";
            this.lblNewSize.Size = new System.Drawing.Size(0, 13);
            this.lblNewSize.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Current size:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "New size:";
            // 
            // cmdClose
            // 
            this.cmdClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdClose.Location = new System.Drawing.Point(9, 212);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(75, 23);
            this.cmdClose.TabIndex = 3;
            this.cmdClose.Text = "Close";
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // cmdResize
            // 
            this.cmdResize.Location = new System.Drawing.Point(200, 212);
            this.cmdResize.Name = "cmdResize";
            this.cmdResize.Size = new System.Drawing.Size(75, 23);
            this.cmdResize.TabIndex = 3;
            this.cmdResize.Text = "Resize";
            this.cmdResize.UseVisualStyleBackColor = true;
            this.cmdResize.Click += new System.EventHandler(this.cmdResize_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ResizeImage
            // 
            this.AcceptButton = this.cmdResize;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdClose;
            this.ClientSize = new System.Drawing.Size(285, 245);
            this.Controls.Add(this.cmdResize);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "ResizeImage";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Resize...";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ResizeImage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdClose;
        private System.Windows.Forms.Button cmdResize;
        private System.Windows.Forms.TextBox txtHeightStatic;
        private System.Windows.Forms.TextBox txtWidthStatic;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbtStatic;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPercentHeight;
        private System.Windows.Forms.TextBox txtPercentWidth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rbtPercent;
        private System.Windows.Forms.Label lblCurrentSize;
        private System.Windows.Forms.Label lblNewSize;
        private System.Windows.Forms.Timer timer1;

    }
}
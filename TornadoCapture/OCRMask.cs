using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TornadoCapture_v2
{
    public partial class OCRMask : Form
    {
        private readonly string _result;

        public OCRMask(String result)
        {
            InitializeComponent();
            _result = result;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonClipboard_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textresult.Text);
        }

        private void OCRMask_Load(object sender, EventArgs e)
        {
            textresult.Text = _result;
        }

    }
}

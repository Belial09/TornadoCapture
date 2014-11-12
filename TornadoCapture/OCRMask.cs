#region

using System;
using System.Windows.Forms;

#endregion

namespace TornadoCapture
{
    public partial class OCRMask : Form
    {
        private readonly string _result;

        public OCRMask(String result)
        {
            InitializeComponent();
            _result = result;
        }

        private void OCRMask_Load(object sender, EventArgs e)
        {
            textresult.Text = _result;
        }

        private void buttonClipboard_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textresult.Text);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
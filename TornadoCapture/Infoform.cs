#region

using System;
using System.Windows.Forms;

#endregion

namespace TornadoCapture
{
    public partial class Infoform : Form
    {
        public enum InfoBoxAction
        {
            None,
            Capture2Clipboard,
            Capture2File
        }

        public bool Started = false;

        public Infoform()
        {
            InitializeComponent();
            Action = InfoBoxAction.None;
        }

        public InfoBoxAction Action { get; set; }

        private void Infoform_FormClosed(object sender, FormClosedEventArgs e)
        {
            Started = false;
        }

        private void Infoform_Load(object sender, EventArgs e)
        {
            checkboxShowNextTime.Checked = Settings.Default.ShowInfoAtStartup;
            Started = true;
        }

        private void btnDoSelect_Click(object sender, EventArgs e)
        {
            Action = InfoBoxAction.Capture2Clipboard;
            Close();
        }

        private void checkboxShowNextTime_CheckedChanged(object sender, EventArgs e)
        {
            if (Started)
            {
                Settings.Default.ShowInfoAtStartup = checkboxShowNextTime.Checked;
                Settings.Default.Save();
            }
        }
    }
}
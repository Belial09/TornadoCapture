using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Tesseract;
using TornadoCapture_v2.Forms;
using TornadoCapture_v2.Klassen;
using TornadoCapture_v2.Properties;
using ImageFormat = System.Drawing.Imaging.ImageFormat;

namespace TornadoCapture_v2
{
    public partial class Mainform : Form
    {
        private const int ALT = 0x0001;
        private const int CTRL = 0x0002;
        private const int WmHotkeyMsgID = 0x0312;
        private const int GwlExstyle = -20;
        private const int WsExToolwindow = 0x00000080;
        private const string Website = "http://www.easytornado.com";
        private readonly Infoform _info = new Infoform();
        private ArrayList _myRegisteredHotkeys;

        public Mainform()
        {
            InitializeComponent();
            _myRegisteredHotkeys = new ArrayList();
            var myHotkey = new RegGlobaleHotkey(CTRL + ALT, Keys.D, this);
            myHotkey.Register();
            _myRegisteredHotkeys.Add(myHotkey);
            myHotkey = new RegGlobaleHotkey(CTRL + ALT, Keys.C, this);
            myHotkey.Register();
            _myRegisteredHotkeys.Add(myHotkey);
            notifyIcon1.Visible = true;

            // verstecken durch diesen Aufruf
            ThreadHelper.CaptureForms = new ArrayList();
            ThreadHelper.Captionmode = ThreadHelper.CaptionMode.Area;
            ThreadHelper.Resultmode = ThreadHelper.ResultMode.Normal;

            SetWindowLong(Handle, GwlExstyle, GetWindowLong(Handle, GwlExstyle) | WsExToolwindow);

            if (InfoStarted == false && Settings.Default.ShowInfoAtStartup)
            {
                ShowInfoBox();
            }

            var buttonTags = Enum.GetNames(typeof (Enums.OcrLanguages));
            oCRToolStripMenuItem.DropDownItems.Clear();
            buttonTags = buttonTags.OrderBy(x => x.ToString()).ToArray();
            
            foreach (var buttonTag in buttonTags)
            {
                var enumval = Enums.EnumFromString<Enums.OcrLanguages>(buttonTag);
                var desc = Enums.GetEnumDescription(enumval);
                var toolstripItem = new ToolStripMenuItem(desc, null, ToolStripMenuItem_Click) {Tag = enumval};
                oCRToolStripMenuItem.DropDownItems.Add(toolstripItem);
            }

        }

        public static bool InfoStarted { get; set; }

        [DllImport("user32.dll")]
        private static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        protected override void WndProc(ref Message m)
        {
            //STRG + C =  llparam=0x430003
            //STRG + D =  lparam=0x440003
            if (m.Msg == WmHotkeyMsgID && ThreadHelper.CaptureIsOn == false)
            {
                if (m.LParam == (IntPtr) 0x440003)
                {
                    ThreadHelper.PressedKey = 0x440003;
                    ThreadHelper.CaptureIsOn = true;
                    var mySelection = new Square();
                    mySelection.ShowDialog();

                    ThreadHelper.CaptureIsOn = false;
                }
                else if (m.LParam == (IntPtr) 0x430003)
                {
                    ThreadHelper.PressedKey = 0x430003;
                    ThreadHelper.CaptureIsOn = true;
                    var mySelection = new Square();
                    mySelection.ShowDialog();
                    ThreadHelper.CaptureIsOn = false;
                }
            }
            base.WndProc(ref m);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (RegGlobaleHotkey myKey in _myRegisteredHotkeys)
            {
                myKey.Unregister();
            }
            _myRegisteredHotkeys = null;
        }

        private void Mainform_Load(object sender, EventArgs e)
        {
            if (ThreadHelper.MyScreenshot != null)
            {
                pictureBox1.Image = ThreadHelper.MyScreenshot;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _info.Close();
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var resources = new ComponentResourceManager(typeof (Mainform));

            if (ThreadHelper.CaptureForms == null) return;
            foreach (Form form in ThreadHelper.CaptureForms)
            {
                form.FormBorderStyle = FormBorderStyle.Sizable;
                form.Icon = ((Icon) (resources.GetObject("notifyIcon1.Icon")));
            }
        }

        private void Rotate90_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = ImageManipulation.RotateImage(pictureBox1.Image, ImageManipulation.RotateMode.Ninetee);
        }

        private void Rotate180_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = ImageManipulation.RotateImage(pictureBox1.Image,
                ImageManipulation.RotateMode.OneHundretEighty);
        }

        private void Rotate270_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = ImageManipulation.RotateImage(pictureBox1.Image,
                ImageManipulation.RotateMode.TwoHundredSeventy);
        }

        private void Mainform_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 102 || e.KeyChar == 170)
            {
                if (pictureBox1.SizeMode == PictureBoxSizeMode.Zoom)
                {
                    pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
                }
                else if (pictureBox1.SizeMode == PictureBoxSizeMode.CenterImage)
                {
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
            else if (e.KeyChar == 105 || e.KeyChar == 73)
            {
                pictureBox1.Image = ImageManipulation.InvertImage(pictureBox1.Image);
            }
            else if (e.KeyChar == 114 || e.KeyChar == 82)
            {
                var myResizeForm = new ResizeImage();
                myResizeForm.SetPicture(pictureBox1.Image, this);
                myResizeForm.ShowDialog();
            }
            else if (e.KeyChar == 115 || e.KeyChar == 83)
            {
                openToolStripMenuItem_Click(null, null);
            }
            else if (e.KeyChar == 112 || e.KeyChar == 80)
            {
                printDocument1.OriginAtMargins = true;
                printDialog1.Document = printDocument1;
                if (printDialog1.ShowDialog() == DialogResult.OK)
                {
                    printDialog1.Document.Print();
                }
            }
        }

        private void zoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var myItem = (ToolStripMenuItem) sender;
            if (pictureBox1.SizeMode == PictureBoxSizeMode.Zoom)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
                myItem.Checked = false;
            }
            else if (pictureBox1.SizeMode == PictureBoxSizeMode.CenterImage)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                myItem.Checked = true;
            }
        }

        private void flipHorizontal_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = ImageManipulation.FlipImage(pictureBox1.Image, ImageManipulation.FlipMode.Horizontal);
        }

        private void flipVertical_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = ImageManipulation.FlipImage(pictureBox1.Image, ImageManipulation.FlipMode.Vertical);
        }

        private void flipBoth_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = ImageManipulation.FlipImage(pictureBox1.Image, ImageManipulation.FlipMode.Both);
        }

        private void invertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = ImageManipulation.InvertImage(pictureBox1.Image);
        }

        private void copyToClipboardToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Clipboard.SetImage(pictureBox1.Image);
        }

        private void Mainform_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.C)
            {
                Clipboard.SetImage(pictureBox1.Image);
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _info.Close();
            Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Reset();
            saveFileDialog1.Filter =
                @"PNG Image|*.png|Bitmap Image|*.bmp|Gif Image|*.gif|JPEG Image|*.jpg|TIFF Image|*.tiff|Icon|*.ico";
            saveFileDialog1.ShowDialog();
            if (string.IsNullOrEmpty(saveFileDialog1.FileName)) return;
            switch (saveFileDialog1.FilterIndex)
            {
                case 1:
                    pictureBox1.Image.Save(saveFileDialog1.FileName, ImageFormat.Png);
                    break;
                case 2:
                    pictureBox1.Image.Save(saveFileDialog1.FileName, ImageFormat.Bmp);
                    break;
                case 3:
                    pictureBox1.Image.Save(saveFileDialog1.FileName, ImageFormat.Gif);
                    break;
                case 4:
                    pictureBox1.Image.Save(saveFileDialog1.FileName, ImageFormat.Jpeg);
                    break;
                case 5:
                    pictureBox1.Image.Save(saveFileDialog1.FileName, ImageFormat.Tiff);
                    break;
                case 6:
                    pictureBox1.Image.Save(saveFileDialog1.FileName, ImageFormat.Icon);
                    break;
            }
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDocument1.OriginAtMargins = true;
            printDialog1.Document = printDocument1;
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDialog1.Document.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(pictureBox1.Image, 0, 0);
        }

        private void resizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var myResizeForm = new ResizeImage();
            myResizeForm.SetPicture(pictureBox1.Image, this);
            myResizeForm.ShowDialog();
        }

        private void ShowInfoBox()
        {
            if (_info != null && InfoStarted == false && _info.Started == false)
            {
                InfoStarted = true;
                _info.ShowDialog();

                if (_info != null && _info.Action == Infoform.InfoBoxAction.Capture2Clipboard)
                {
                    var mySelection = new Square();
                    mySelection.ShowDialog();
                }
            }
        }

        private void websiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(Website);
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                InfoStarted = false;
                ShowInfoBox();
            }
        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var realSender = sender as ToolStripMenuItem;
            if (realSender != null)
            {
                DoOCR(realSender.Tag.ToString());
            }
        }

        private void DoOCR(string tag)
        {
            if (tag != string.Empty)
            {
                try
                {
                    var path = Path.Combine(Application.StartupPath, @"tessdata");
                    Console.WriteLine(path);
                    using (var engine = new TesseractEngine(path, tag.ToLower(), EngineMode.Default))
                    {
                        using (var img = new Bitmap(pictureBox1.Image))
                        {
                            using (var page = engine.Process(img))
                            {
                                var text = page.GetText();
                                if (text != String.Empty)
                                {
                                    using (var frm = new OCRMask(text))
                                    {
                                        frm.ShowDialog();
                                    }
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            } 
        }

    }
}
#region

using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

#endregion

namespace TornadoCapture
{
    public partial class Square : Form
    {
        private readonly int screenHeight;
        private readonly int screenLeft;
        private readonly int screenTop;
        private readonly int screenWidth;


        private Rectangle backupRect;
        private int initialX;
        private int initialY;
        private bool isDown;

        public Square()
        {
            InitializeComponent();
            screenLeft = SystemInformation.VirtualScreen.Left;
            screenTop = SystemInformation.VirtualScreen.Top;
            screenWidth = SystemInformation.VirtualScreen.Width;
            screenHeight = SystemInformation.VirtualScreen.Height;
            typeof (Panel).InvokeMember("DoubleBuffered",
                BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, this,
                new object[] {true});
            UpdateStyles();
            Cursor = Cursors.Hand;
        }

        public Image CaptureScreen()
        {
            if (backupRect.Width <= 0 || backupRect.Height <= 0)
            {
                return null;
            }

            var bmp = new Bitmap(screenWidth, screenHeight);
            using (var g = Graphics.FromImage(bmp))
            {
                g.CopyFromScreen(screenLeft, screenTop, 0, 0, bmp.Size);
            }
            return bmp.Clone(backupRect, PixelFormat.Undefined);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            ThreadHelper.CaptureIsOn = false;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        //Get the device component of the window to allow drawing on the title bar and frame


        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            isDown = true;
            initialX = e.X;
            initialY = e.Y;
            IntPtr m_WndHdc;
            m_WndHdc = GetWindowDC(Handle);
            var g = Graphics.FromHdc(m_WndHdc);
            g.Clear(Color.LightGray);
            Invalidate();
            g.Dispose();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            IntPtr m_WndHdc;
            if (isDown)
            {
                m_WndHdc = GetWindowDC(Handle);
                var g = Graphics.FromHdc(m_WndHdc);

                var EraserPen = new Pen(BackColor, 10);
                var eraserBrush = new SolidBrush(BackColor);

                g.DrawRectangle(EraserPen, backupRect);
                g.FillRectangle(eraserBrush, backupRect);

                var rect = new Rectangle(Math.Min(e.X, initialX), Math.Min(e.Y, initialY), Math.Abs(e.X - initialX),
                    Math.Abs(e.Y - initialY));
                backupRect = rect;

                var peeen = new Pen(Color.Red, 8);
                var TransparentBrush = new SolidBrush(Color.Fuchsia);
                peeen.DashStyle = DashStyle.Dot;
                g.DrawRectangle(peeen, rect);
                g.FillRectangle(TransparentBrush, rect);

                ReleaseDC(Handle, m_WndHdc);
                g.Dispose();
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            isDown = false;
            MakeScreenshot();
        }

        [DllImport("User32.dll")]
        public static extern IntPtr GetWindowDC(IntPtr hWnd);

        private void MakeScreenshot()
        {
            if (ThreadHelper.PressedKey == 0x430003)
            {
                ThreadHelper.MyScreenshot = CaptureScreen();
                if (ThreadHelper.MyScreenshot != null)
                {
                    Clipboard.SetImage(ThreadHelper.MyScreenshot);
                }

                Hide();
            }
            else
            {
                switch (ThreadHelper.Resultmode)
                {
                    case ThreadHelper.ResultMode.Clipboard:
                        ThreadHelper.MyScreenshot = CaptureScreen();
                        Clipboard.SetImage(ThreadHelper.MyScreenshot = CaptureScreen());
                        Hide();
                        break;
                    case ThreadHelper.ResultMode.Normal:
                        ThreadHelper.MyScreenshot = CaptureScreen();
                        Hide();
                        var myResult = new Mainform {notifyIcon1 = {Visible = false}};
                        ThreadHelper.CaptureForms.Add(myResult);
                        myResult.Show();
                        myResult.ShowInTaskbar = true;
                        myResult.WindowState = FormWindowState.Normal;
                        break;
                }
            }
        }

        [DllImport("User32.dll")]
        public static extern int ReleaseDC(IntPtr hWnd, IntPtr hDC);

        private void Square_Load(object sender, EventArgs e)
        {
            Left = screenLeft;
            Top = screenTop;
            Width = screenWidth;
            Height = screenHeight;
            DoubleBuffered = true;
            Opacity = .50;
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.None;
            TopMost = true;
            WinApi.SetWinFullScreen(Handle);
        }
    }
}
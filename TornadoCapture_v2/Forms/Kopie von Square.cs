//using System;
//using System.Drawing;
//using System.Drawing.Drawing2D;
//using System.Drawing.Imaging;
//using System.IO;
//using System.Linq;
//using System.Windows.Forms;

//namespace TornadoCapture_v2
//    {
//        public partial class Square : Form
//        {
//        internal int TopLeftX = 0;
//        internal int TopLeftY = 0;
//        internal int BottomRightX = 0;
//        internal int BottomRightY = 0;
//            private Screen activeScreen; 

//        #region:::::::::::::::::::::::::::::::::::::::::::Form level declarations:::::::::::::::::::::::::::::::::::::::::::

//        /// <summary>
//        /// 
//        /// </summary>
//        private enum CursPos
//        {
//            WithinSelectionArea = 0,
//            OutsideSelectionArea,
//            TopLine,
//            BottomLine,
//            LeftLine,
//            RightLine,
//            TopLeft,
//            TopRight,
//            BottomLeft,
//            BottomRight
//            }

//        /// <summary>
//        /// 
//        /// </summary>
//        private enum ClickAction
//        {
//            NoClick = 0,
//            Dragging,
//            Outside,
//            TopSizing,
//            BottomSizing,
//            LeftSizing,
//            TopLeftSizing,
//            BottomLeftSizing,
//            RightSizing,
//            TopRightSizing,
//            BottomRightSizing
//            }


//        private bool LeftButtonDown = false;
//        private bool RectangleDrawn = false;
//        //private bool ReadyToDrag = false;

//        private Point ClickPoint = new Point();
//        private Point CurrentTopLeft = new Point();
//        private Point CurrentBottomRight = new Point();
//        private Point DragClickRelative = new Point();

//        private readonly Graphics g;
//        private readonly Pen MyPen = new Pen(Color.Red, 10);
//        private readonly SolidBrush TransparentBrush = new SolidBrush(Color.Fuchsia); //Color.Transparent
//        private readonly Pen EraserPen = new Pen(Color.LightGray, 10);
//        private readonly SolidBrush eraserBrush = new SolidBrush(Color.LightGray);

//        /// <summary>
//        /// Löst das <see cref="E:System.Windows.Forms.Control.MouseClick"/>-Ereignis aus.
//        /// </summary>
//        /// <param name="e">Ein <see cref="T:System.Windows.Forms.MouseEventArgs"/>, das die Ereignisdaten enthält.</param>
//        protected override void OnMouseClick(MouseEventArgs e)
//            {

//            if (e.Button == MouseButtons.Right)
//                {
//                e = null;
//                }
//            base.OnMouseClick(e);

//            }

//        /// <summary>
//        /// Gets or sets the instance ref.
//        /// </summary>
//        /// <value>
//        /// The instance ref.
//        /// </value>
//        internal Form InstanceRef { get; set; }

//        #endregion

//        #region:::::::::::::::::::::::::::::::::::::::::::Mouse Event Handlers & Drawing Initialization:::::::::::::::::::::::::::::::::::::::::::
//        /// <summary>
//        /// Initializes a new instance of the <see cref="Square"/> class.
//        /// </summary>
//        public Square(Screen _scr)
//        {
//            Graphics gr = CreateGraphics();
//            g = gr;
//            InstanceRef = null;

//            InitializeComponent();

//            //activeScreen = _scr;
//            var scr = Screen.AllScreens[0];

//            var biggestHeight = Screen.AllScreens.Select(x => x.Bounds.Height).OrderBy(x=>x).FirstOrDefault();
//            var biggestWidth = Screen.AllScreens.Select(x => x.Bounds.Width).OrderBy(x => x).FirstOrDefault();
//            var widthCombined = Screen.AllScreens.Sum(scrn => scrn.Bounds.Width);

//            //var scr = _scr; // Screen.FromPoint(Cursor.Position);
//            //this.Size = new Size(widthCombined, biggestHeight);


//            this.TopMost = true;
//            Cursor = Cursors.Hand;

//            this.Left = 0;
//            this.Top = 0;
//            this.Width = biggestWidth;
//            this.Height = biggestHeight + 200;
//            //this.Left = 0;
//            //this.Top = 0;
//            //this.Bounds = new Rectangle(0, 0, Size.Width,Size.Height);
//            EnableDoubleBuffering();

//            this.TopMost = true;
//            this.FormBorderStyle = FormBorderStyle.None;
//            //this.WindowState = FormWindowState.Maximized;
//            //this.Location = scr.Bounds.Location;
//            this.StartPosition = FormStartPosition.Manual;


//            MouseDown += mouse_Click;
//            MouseDoubleClick += mouse_DClick;
//            MouseUp += mouse_Up;
//            MouseMove += mouse_Move;
//            MyPen.DashStyle = DashStyle.Dot;
//            g = CreateGraphics();
//            }
//        #endregion

//        #region:::::::::::::::::::::::::::::::::::::::::::Mouse Buttons:::::::::::::::::::::::::::::::::::::::::::
//        /// <summary>
//        /// Handles the DClick event of the mouse control.
//        /// </summary>
//        /// <param name="sender">The source of the event.</param>
//        /// <param name="e">The <see cref="System.Windows.Forms.MouseEventArgs"/> instance containing the event data.</param>
//        private void mouse_DClick(object sender, MouseEventArgs e)
//            {
//            if (RectangleDrawn && (CursorPosition() == CursPos.WithinSelectionArea || CursorPosition() == CursPos.OutsideSelectionArea))
//                {

//                RefreshSelection();
//                }
//            }

//        /// <summary>
//        /// Handles the Click event of the mouse control.
//        /// </summary>
//        /// <param name="sender">The source of the event.</param>
//        /// <param name="e">The <see cref="System.Windows.Forms.MouseEventArgs"/> instance containing the event data.</param>
//        private void mouse_Click(object sender, MouseEventArgs e)
//            {
//            if (e.Button == MouseButtons.Left)
//                {
//                LeftButtonDown = true;
//                ClickPoint = new Point(MousePosition.X, MousePosition.Y);

//                if (RectangleDrawn)
//                    {
//                        DragClickRelative.X = Cursor.Position.X - CurrentTopLeft.X;
//                        DragClickRelative.Y = Cursor.Position.Y - CurrentTopLeft.Y;
//                    }

//                }
//            }

//        /// <summary>
//        /// Handles the Up event of the mouse control.
//        /// </summary>
//        /// <param name="sender">The source of the event.</param>
//        /// <param name="e">The <see cref="System.Windows.Forms.MouseEventArgs"/> instance containing the event data.</param>
//        private void mouse_Up(object sender, MouseEventArgs e)
//            {
//            RectangleDrawn = true;
//            LeftButtonDown = false;
//            MakeScreenshot();
//            }
//        #endregion

//        /// <summary>
//        /// Refreshes the selection.
//        /// </summary>
//        private void RefreshSelection()
//        {
//            TopLeftX = CurrentTopLeft.X;
//            TopLeftY = CurrentTopLeft.Y;
//            BottomRightX = CurrentBottomRight.X;
//            BottomRightY = CurrentBottomRight.Y;
//        }

//        /// <summary>
//        /// Handles the Move event of the mouse control.
//        /// </summary>
//        /// <param name="sender">The source of the event.</param>
//        /// <param name="e">The <see cref="System.Windows.Forms.MouseEventArgs"/> instance containing the event data.</param>
//        private void mouse_Move(object sender, MouseEventArgs e)
//            {

//            if (LeftButtonDown && !RectangleDrawn)
//            {
//            DrawSelection();
//            }
//            }

//        /// <summary>
//        /// Cursors the position.
//        /// </summary>
//        /// <returns></returns>
//        private CursPos CursorPosition()
//            {
//                Console.WriteLine("Cursor.Position.X :" + Cursor.Position.X);
//                Console.WriteLine("CurrentTopLeft.X :" + CurrentTopLeft.X);
//                Console.WriteLine("Cursor.Position.Y :" + Cursor.Position.Y);
//                Console.WriteLine("CurrentTopLeft.Y :" + CurrentTopLeft.Y);


//                if (((Cursor.Position.X > CurrentTopLeft.X - 0 && Cursor.Position.X < CurrentTopLeft.X + 0)) && ((Cursor.Position.Y > CurrentTopLeft.Y + 0) && (Cursor.Position.Y < CurrentBottomRight.Y - 0)))
//                {
//                Cursor = Cursors.SizeWE;
//                return CursPos.LeftLine;
//                }
//            if (((Cursor.Position.X >= CurrentTopLeft.X - 0 && Cursor.Position.X <= CurrentTopLeft.X + 0)) && ((Cursor.Position.Y >= CurrentTopLeft.Y - 0) && (Cursor.Position.Y <= CurrentTopLeft.Y + 0)))
//                {
//                Cursor = Cursors.SizeNWSE;
//                return CursPos.TopLeft;
//                }
//            if (((Cursor.Position.X >= CurrentTopLeft.X - 0 && Cursor.Position.X <= CurrentTopLeft.X + 0)) && ((Cursor.Position.Y >= CurrentBottomRight.Y - 0) && (Cursor.Position.Y <= CurrentBottomRight.Y + 0)))
//                {
//                Cursor = Cursors.SizeNESW;
//                return CursPos.BottomLeft;
//                }
//            if (((Cursor.Position.X > CurrentBottomRight.X - 0 && Cursor.Position.X < CurrentBottomRight.X + 0)) && ((Cursor.Position.Y > CurrentTopLeft.Y + 0) && (Cursor.Position.Y < CurrentBottomRight.Y - 0)))
//                {
//                Cursor = Cursors.SizeWE;
//                return CursPos.RightLine;
//                }
//            if (((Cursor.Position.X >= CurrentBottomRight.X - 0 && Cursor.Position.X <= CurrentBottomRight.X + 0)) && ((Cursor.Position.Y >= CurrentTopLeft.Y - 0) && (Cursor.Position.Y <= CurrentTopLeft.Y + 0)))
//                {
//                Cursor = Cursors.SizeNESW;
//                return CursPos.TopRight;
//                }
//            if (((Cursor.Position.X >= CurrentBottomRight.X - 0 && Cursor.Position.X <= CurrentBottomRight.X + 0)) && ((Cursor.Position.Y >= CurrentBottomRight.Y - 0) && (Cursor.Position.Y <= CurrentBottomRight.Y + 0)))
//                {
//                Cursor = Cursors.SizeNWSE;
//                return CursPos.BottomRight;
//                }
//            if (((Cursor.Position.Y > CurrentTopLeft.Y - 0) && (Cursor.Position.Y < CurrentTopLeft.Y + 0)) && ((Cursor.Position.X > CurrentTopLeft.X + 0 && Cursor.Position.X < CurrentBottomRight.X - 0)))
//                {
//                Cursor = Cursors.SizeNS;
//                return CursPos.TopLine;
//                }
//            if (((Cursor.Position.Y > CurrentBottomRight.Y - 0) && (Cursor.Position.Y < CurrentBottomRight.Y + 0)) && ((Cursor.Position.X > CurrentTopLeft.X + 0 && Cursor.Position.X < CurrentBottomRight.X - 0)))
//                {
//                Cursor = Cursors.SizeNS;
//                return CursPos.BottomLine;
//                }
//            if (
//                (Cursor.Position.X >= CurrentTopLeft.X + 0 && Cursor.Position.X <= CurrentBottomRight.X - 0) && (Cursor.Position.Y >= CurrentTopLeft.Y + 0 && Cursor.Position.Y <= CurrentBottomRight.Y - 0))
//                {
//                Cursor = Cursors.Hand;
//                return CursPos.WithinSelectionArea;
//                }
//            Cursor = Cursors.No;
//            return CursPos.OutsideSelectionArea;
//            }


//        /// <summary>
//        /// Draws the selection.
//        /// </summary>
//        private void DrawSelection()
//            {
//            Cursor = Cursors.Hand;

//            //Erase the previous rectangle

//            g.DrawRectangle(EraserPen, CurrentTopLeft.X, CurrentTopLeft.Y, CurrentBottomRight.X - CurrentTopLeft.X, CurrentBottomRight.Y - CurrentTopLeft.Y);
//            g.FillRectangle(eraserBrush, CurrentTopLeft.X, CurrentTopLeft.Y, CurrentBottomRight.X - CurrentTopLeft.X, CurrentBottomRight.Y - CurrentTopLeft.Y);

//            //Calculate X Coordinates
//            if (Cursor.Position.X < ClickPoint.X)
//                {
//                CurrentTopLeft.X = Cursor.Position.X;
//                CurrentBottomRight.X = ClickPoint.X;
//                }
//            else
//                {
//                CurrentTopLeft.X = ClickPoint.X;
//                CurrentBottomRight.X = Cursor.Position.X;
//                }

//            //Calculate Y Coordinates
//            if (Cursor.Position.Y < ClickPoint.Y)
//                {
//                CurrentTopLeft.Y = Cursor.Position.Y;
//                CurrentBottomRight.Y = ClickPoint.Y;
//                }
//            else
//                {
//                CurrentTopLeft.Y = ClickPoint.Y;
//                CurrentBottomRight.Y = Cursor.Position.Y;
//                }

//            //Draw a new rectangle
//            g.DrawRectangle(MyPen, CurrentTopLeft.X, CurrentTopLeft.Y, CurrentBottomRight.X - CurrentTopLeft.X, CurrentBottomRight.Y - CurrentTopLeft.Y);
//            g.FillRectangle(TransparentBrush, CurrentTopLeft.X, CurrentTopLeft.Y, CurrentBottomRight.X - CurrentTopLeft.X, CurrentBottomRight.Y - CurrentTopLeft.Y);
//            RefreshSelection();
//            }

//        /// <summary>
//        /// Handles the Load event of the Square control.
//        /// </summary>
//        /// <param name="sender">The source of the event.</param>
//        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
//        private void Square_Load(object sender, EventArgs e)
//        {

//        }

//        /// <summary>
//        /// Enables the double buffering.
//        /// </summary>
//        public void EnableDoubleBuffering()
//        {
//            SetStyle(ControlStyles.UserPaint, true);
//            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
//            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
//            SetStyle(ControlStyles.DoubleBuffer |
//               ControlStyles.UserPaint |
//               ControlStyles.AllPaintingInWmPaint,
//               true);
//            UpdateStyles();
//        }

//        /// <summary>
//        /// Checks the ESC.
//        /// </summary>
//        /// <param name="sender">The sender.</param>
//        /// <param name="e">The <see cref="System.Windows.Forms.KeyEventArgs"/> instance containing the event data.</param>
//        private void CheckESC(object sender, KeyEventArgs e)
//        {
//            if (e.KeyCode == Keys.Escape) { Close(); }
//        }

//        /// <summary>
//        /// Finisheds the specified sender.
//        /// </summary>
//        /// <param name="sender">The sender.</param>
//        /// <param name="e">The <see cref="System.Windows.Forms.MouseEventArgs"/> instance containing the event data.</param>
//        private void Finished(object sender, MouseEventArgs e)
//        {
//            g.FillRectangle(TransparentBrush, CurrentTopLeft.X, CurrentTopLeft.Y, CurrentBottomRight.X - CurrentTopLeft.X, CurrentBottomRight.Y - CurrentTopLeft.Y);
//        }

//        /// <summary>
//        /// Makes the screenshot.
//        /// </summary>
//        private void MakeScreenshot()
//        {
//            if (ThreadHelper._PressedKey == 0x430003)
//            {
//                ThreadHelper._myScreenshot = CaptureScreen();
//                Clipboard.SetImage(ThreadHelper._myScreenshot = CaptureScreen());
//                Hide();
//            }
//            else
//            {
//                switch (ThreadHelper._resultmode)
//                {
//                    case ThreadHelper.ResultMode.Clipboard:
//                        ThreadHelper._myScreenshot = CaptureScreen();
//                        Clipboard.SetImage(ThreadHelper._myScreenshot = CaptureScreen());
//                        Hide();
//                        break;
//                    case ThreadHelper.ResultMode.Normal:
//                        ThreadHelper._myScreenshot = CaptureScreen();
//                        Hide();
//                        Mainform myResult = new Mainform {notifyIcon1 = {Visible = false}};
//                        ThreadHelper._captureForms.Add(myResult);
//                        myResult.Show();
//                        myResult.ShowInTaskbar = true;
//                        myResult.WindowState = FormWindowState.Normal;
//                        break;
//                }
//            }
//        }

//        /// <summary>
//        /// Captures the screen.
//        /// </summary>
//        /// <returns></returns>
//        public Image CaptureScreen()
//        {
//            Bitmap b = new Bitmap(SystemInformation.VirtualScreen.Width, SystemInformation.VirtualScreen.Height);
//            Graphics g = Graphics.FromImage(b);
//            g.CopyFromScreen(0, 0, 0, 0, b.Size);
//            g.Dispose();

//            MemoryStream myStream = ImageManipulation.CropImage(b, CurrentTopLeft.X, CurrentTopLeft.Y, CurrentBottomRight.X, CurrentBottomRight.Y, ImageFormat.Png);
//            return Image.FromStream(myStream);
//        }

//        /// <summary>
//        /// Handles the FormClosing event of the Square control.
//        /// </summary>
//        /// <param name="sender">The source of the event.</param>
//        /// <param name="e">The <see cref="System.Windows.Forms.FormClosingEventArgs"/> instance containing the event data.</param>
//        private void Square_FormClosing(object sender, FormClosingEventArgs e)
//        {
//            ThreadHelper._CaptureIsON = false;
//        }
//    }
//}


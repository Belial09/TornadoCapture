#region

using System;
using System.Collections;
using System.Drawing;

#endregion

namespace TornadoCapture.Klassen
{
    internal static class ThreadHelper
    {
        internal static ArrayList CaptureForms;
        internal static CaptionMode Captionmode;
        internal static ResultMode Resultmode;
        internal static Image MyScreenshot;
        internal static bool CaptureIsOn;
        internal static Int32 PressedKey;

        internal enum CaptionMode
        {
            Fullscreen = 0,
            Area = 1,
            Window = 2
        }

        internal enum ResultMode
        {
            Normal = 0,
            Clipboard = 1,
            Database = 2,
            File = 3,
            Printer = 4
        }
    }
}
#region

using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;

#endregion

namespace TornadoCapture.Klassen
{
    internal static class ImageManipulation
    {
        private static MemoryStream CropAndResizeImage(Image img, int targetWidth, int targetHeight, int x1, int y1,
            int x2, int y2, ImageFormat imageFormat)
        {
            if (targetHeight == 0)
            {
                targetHeight = 1;
            }
            if (targetWidth == 0)
            {
                targetWidth = 1;
            }
            var bmp = new Bitmap(targetWidth, targetHeight);
            var g = Graphics.FromImage(bmp);

            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;
            g.CompositingQuality = CompositingQuality.HighQuality;

            var width = x2 - x1;
            var height = y2 - y1;

            g.DrawImage(img, new Rectangle(0, 0, targetWidth, targetHeight), x1, y1, width, height, GraphicsUnit.Pixel);
            g.Dispose();
            var memStream = new MemoryStream();
            bmp.Save(memStream, imageFormat);
            return memStream;
        }

        internal static MemoryStream CropImage(Image img, int x1, int y1, int x2, int y2, ImageFormat imageFormat)
        {
            return CropAndResizeImage(img, x2 - x1, y2 - y1, x1, y1, x2, y2, imageFormat);
        }

        internal static Image FlipImage(Image myImage, FlipMode myFlipmode)
        {
            var ret = myImage;
            switch (myFlipmode)
            {
                case FlipMode.Horizontal:
                    ret.RotateFlip(RotateFlipType.RotateNoneFlipX);
                    break;
                case FlipMode.Vertical:
                    ret.RotateFlip(RotateFlipType.RotateNoneFlipY);
                    break;
                case FlipMode.Both:
                    ret.RotateFlip(RotateFlipType.RotateNoneFlipXY);
                    break;
            }
            return ret;
        }

        internal static Image InvertImage(Image myImage)
        {
            var invertedBmp = new Bitmap(myImage.Width, myImage.Height);

            //Setup color matrix
            var clrMatrix =
                new ColorMatrix(new[]
                {
                    new float[] {-1, 0, 0, 0, 0}, new float[] {0, -1, 0, 0, 0}, new float[] {0, 0, -1, 0, 0},
                    new float[] {0, 0, 0, 1, 0}, new float[] {1, 1, 1, 0, 1}
                });

            using (var attr = new ImageAttributes())
            {
                //Attach matrix to image attributes
                attr.SetColorMatrix(clrMatrix);

                using (var g = Graphics.FromImage(invertedBmp))
                {
                    g.DrawImage(myImage, new Rectangle(0, 0, myImage.Width, myImage.Height), 0, 0, myImage.Width,
                        myImage.Height, GraphicsUnit.Pixel, attr);
                }
            }

            return invertedBmp;
        }

        internal static Image ResizeImage(Image imgToResize, Size size)
        {
            var b = new Bitmap(size.Width, size.Height);
            var g = Graphics.FromImage(b);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;

            g.DrawImage(imgToResize, 0, 0, size.Width, size.Height);
            g.Dispose();

            return b;
        }

        internal static Image RotateImage(Image myImage, RotateMode myRotatemode)
        {
            var ret = myImage;
            switch (myRotatemode)
            {
                case RotateMode.Ninetee:
                    ret.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    break;
                case RotateMode.OneHundretEighty:
                    ret.RotateFlip(RotateFlipType.Rotate180FlipNone);
                    break;
                case RotateMode.TwoHundredSeventy:
                    ret.RotateFlip(RotateFlipType.Rotate270FlipNone);
                    break;
            }
            return ret;
        }

        internal enum FlipMode
        {
            Horizontal = 0,
            Vertical = 1,
            Both = 2
        }

        internal enum RotateMode
        {
            Ninetee = 0,
            OneHundretEighty = 1,
            TwoHundredSeventy = 2,
        }
    }
}
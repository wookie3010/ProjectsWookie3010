using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ImageHelpers
{
    public static class ImageSizeConverter
    {
        static ImageSizeConverter() {}

        // ===============================================

        public static ImageData ResizeImage(ImageData imageData, Size newSize)
        {
            Bitmap b = new Bitmap(imageData.Image, newSize);
            using (Graphics g = Graphics.FromImage(b))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.PixelOffsetMode = PixelOffsetMode.HighQuality;
                Rectangle r = new Rectangle(new Point(0, 0), newSize);
                g.DrawImage(b, r);
                return new ImageData(imageData.FilePath, b);
            }            
        }

        // ---------------------------

        public static ImageData ResizeImage(ImageData imageData)
        {
            Size newSize = new Size((int)(imageData.Image.Width*0.2), (int)(imageData.Image.Height*0.2));
            Bitmap b = new Bitmap(imageData.Image, newSize);
            using (Graphics g = Graphics.FromImage(b))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.InterpolationMode = InterpolationMode.NearestNeighbor;
                g.PixelOffsetMode = PixelOffsetMode.HighQuality;
                Rectangle r = new Rectangle(new Point(0, 0), newSize);
                g.DrawImage(b, r);
                return new ImageData(imageData.FilePath, b);
            }            
        }
    }
}

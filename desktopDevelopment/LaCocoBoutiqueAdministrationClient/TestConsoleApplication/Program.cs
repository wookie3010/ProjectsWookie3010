using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;

namespace TestConsoleApplication
{
    public class Program
    {
        static void Main(string[] args)
        {
            Image image = Image.FromFile(@"D:\kellers\projects\testEnvironment\TestApp\ImageConverterForm\files\DSC_0263.jpg");
            Size newSize = new Size((int)(image.Width * 0.2), (int)(image.Height * 0.2));
            Bitmap b = new Bitmap(image, newSize);
            using (Graphics g = Graphics.FromImage(b))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.PixelOffsetMode = PixelOffsetMode.HighQuality;
                Rectangle r = new Rectangle(new Point(0, 0), newSize);
                g.DrawImage(b, r);
            }            
        }
    }
}

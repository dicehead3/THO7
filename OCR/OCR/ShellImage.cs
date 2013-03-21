using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCR
{
    /// <Author>
    /// Erwin Bonnet
    /// </Author>
    public class ShellImage
    {
        private byte[] imageData;
        private int offset;
        private int w, h, w3;

        public ShellImage(Bitmap bmp)
        {
            Bitmap b = CropAndResize(bmp);
            w = b.Width;
            h = b.Height;
            w3 = w * 3;
            imageData = new byte[w3 * h];
            BitmapData data = b.LockBits(new Rectangle(0, 0, b.Width, b.Height), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            offset = data.Stride - w3;

            unsafe
            {
                byte* ptr = (byte*)data.Scan0.ToPointer();
                int p = 0;
                for (int y = 0; y < h; y++, ptr += offset)
                {
                    for (int x = 0; x < w3; x++, ptr++, p++)
                    {
                        imageData[p] = *ptr;
                    }
                }
            }
            b.UnlockBits(data);
        }

        public int Width
        {
            get { return w; }
        }
        public int WidthX3
        {
            get { return w3; }
        }
        public int Height
        {
            get { return h; }
        }

        public byte Get(int x, int y)
        {
            return imageData[y * w3 + x];
        }

        private Bitmap CropAndResize(Bitmap b)
        {
            Bitmap res = new Bitmap(161, 182);
            using (Graphics g = Graphics.FromImage(res))
                g.DrawImage(b, 0, 0, 161, 182);

            int xL = b.Width, yT = b.Height, xR = 0, yB = 0;

            for(int y = 0; y < res.Height; y++)
                for (int x = 0; x < res.Width; x++)
                {
                    Color c = res.GetPixel(x, y);
                    if (c.R > 127 && c.G > 127 && c.B > 127) continue;
                    if (x < xL) xL = x;
                    if (x > xR) xR = x;
                    if (y < yT) yT = y;
                    if (y > yB) yB = y;
                }

            Rectangle cropRect = new Rectangle(xL, yT, xR - xL, yB - yT);
            Bitmap cropped = res.Clone(cropRect, res.PixelFormat);
            res = new Bitmap(106, 124);
            using (Graphics g = Graphics.FromImage(res))
                g.DrawImage(cropped, 0, 0, 106, 124);
           // res.Save(Form1.fileName + ".cr.bmp", ImageFormat.Bmp);
            return res;
        }
    }
}

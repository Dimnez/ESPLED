using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ambient
{
    sealed class Win32
    {
        [DllImport("user32.dll")]
        static extern IntPtr GetDC(IntPtr hwnd);

        [DllImport("user32.dll")]
        static extern Int32 ReleaseDC(IntPtr hwnd, IntPtr hdc);

        [DllImport("gdi32.dll")]
        static extern uint GetPixel(IntPtr hdc, int nXPos, int nYPos);

        static public System.Drawing.Color GetPixelColor(int x, int y)
        {
            IntPtr hdc = GetDC(IntPtr.Zero);
            uint pixel = GetPixel(hdc, x, y);
            ReleaseDC(IntPtr.Zero, hdc);
            Color color = Color.FromArgb((int)(pixel & 0x000000FF),
                         (int)(pixel & 0x0000FF00) >> 8,
                         (int)(pixel & 0x00FF0000) >> 16);
            return color;
        }
    }

    
    public  class Extensions
    {
        //Source: https://stackoverflow.com/questions/1195064/fastest-image-resizing-in-net
        public static Bitmap ResizeImage(Image img, int width, int height)
        {
            Bitmap b = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage((Image)b))
            {
                g.DrawImage(img, 0, 0, width, height);
            }

            return b;
        }

        public static List<Color> GetColorsFromScreen(int num)
        {
            List<Color> ret = new List<Color>();

            Point topLeft = new Point(0, 0);
            Point bottomRight = new Point(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            Rectangle rect = new Rectangle(topLeft, new Size(bottomRight.X - topLeft.X, bottomRight.Y - topLeft.Y));

            Bitmap ss = new Bitmap(rect.Width, rect.Height);
            Graphics gfx = Graphics.FromImage(ss);
            try
            {
                gfx.CopyFromScreen(topLeft, new Point(0, 0), rect.Size);
            }
            catch (Exception)
            {
                gfx.Clear(Color.Black);
            }
            gfx.Dispose();

            Bitmap c = ResizeImage(ss, (num * 5) + 20, 100);
            ss.Dispose();

            for (int i = 0; i < num; i++)
            {
                ret.Add(c.GetPixel((i * 5) + 10, 30));
            }

            return ret;
        }
    }
}

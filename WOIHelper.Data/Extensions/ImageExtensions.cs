using System.Drawing;
using System.Drawing.Imaging;

namespace WOIHelper.Data.Extensions
{
    public static class ImageExtensions
    {
        public static Bitmap ConvertToFormat(this Image image, PixelFormat format)
        {
            var copy = new Bitmap(image.Width, image.Height, format);

            using (var gr = Graphics.FromImage(copy))
            {
                gr.DrawImage(image, new Rectangle(0, 0, copy.Width, copy.Height));
            }

            return copy;
        }
    }
}
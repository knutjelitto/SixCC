using SixTools.Tiles;
using System.Drawing;

#pragma warning disable CA1416 // Validate platform compatibility

namespace SixTools.Formats.RailSvg
{
    public class SvgDimmer : Dimmer, IDisposable
    {
        private readonly Graphics Graphics;
        private readonly Font MonoFont;
        private readonly Font PropFont;
        private bool disposed;

        public SvgDimmer()
        {
            annotation_height = 1;

            Graphics = Graphics.FromImage(new Bitmap(1, 1));
            MonoFont = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold);
            PropFont = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Regular);
        }

        void IDisposable.Dispose()
        {
            if (!disposed)
            {
                disposed = true;
                MonoFont.Dispose();
                PropFont.Dispose();
                Graphics.Dispose();
                GC.SuppressFinalize(this);
            }
        }

        public override Dimension Monospace(string text)
        {
            var size = Graphics.MeasureString(text, MonoFont).Width;

            var w = Math.Max(3, (int)Math.Ceiling(size / 10));

            return new Dimension()
            {
                Width = w,
                Ascender = 1,
                Descender = 1
            };
        }

        public override Dimension SansSerif(string text)
        {
            var size = Graphics.MeasureString(text, PropFont).Width;

            var w = (int)Math.Ceiling(size / 10);

            /* even numbers only, for sake of visual rhythm */
            if ((w & 1) != 0)
            {
                w++;
            }

            return new Dimension()
            {
                Width = w,
                Ascender = 1,
                Descender = 1
            };
        }
    }
}

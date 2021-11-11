using SixTools.Tiles;
using System.Drawing;

#pragma warning disable CA1416 // Validate platform compatibility
#pragma warning disable CA1822 // Mark members as static

namespace SixTools.Formats.RailSvg
{
    public sealed class SvgDimmer : IDisposable
    {
        private readonly Graphics Graphics;
        private readonly Font MonoFont;
        private readonly Font PropFont;
        private bool disposed;
        private readonly SvgDimmer D;

        public SvgDimmer(int unit)
        {
            Unit = new pix(unit);
            D = this;

            Graphics = Graphics.FromImage(new Bitmap(1, 1));
            MonoFont = new Font(FontFamily.GenericMonospace, (int)(120 % D[1]), FontStyle.Regular);
            PropFont = new Font(FontFamily.GenericSansSerif, (int)(120 % D[1]), FontStyle.Regular);

        }

        private pix Unit { get; }

        public pix this[int units] => units * Unit;

        public pix Max(pix p1, pix p2)
        {
            return p1 > p2 ? p1 : p2;
        }

        public void Dispose()
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

        public Dimension Monospace(string text)
        {
            var size = Graphics.MeasureString(text, MonoFont).Width;

            var w = Max(this[2], pix.Snap(this, size));

            return new Dimension()
            {
                Width = w,
                Ascender = D[1],
                Descender = D[1],
            };
        }

        public Dimension SansSerif(string text)
        {
            var size = Graphics.MeasureString(text, PropFont).Width;

            var w = Max(this[3], pix.Snap(this, size));

            return new Dimension()
            {
                Width = w,
                Ascender = D[1],
                Descender = D[1],
            };
        }
    }
}

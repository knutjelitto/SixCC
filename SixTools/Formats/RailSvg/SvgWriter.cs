using SixTools.Helpers;

namespace SixTools.Formats.RailSvg
{
    internal class SvgWriter
    {
        private readonly Writer writer;

        public SvgWriter(Writer writer, SvgDimmer d)
        {
            this.writer = writer;
            D = d;
        }

        public SvgDimmer D { get; }

        public void Text(string cls, string text, pix x, pix y, pix w)
        {
            // SEE: https://wiki.selfhtml.org/wiki/SVG/Elemente/text

            writer.WriteLine($"<text{Class(cls)} x='{x + (50 % w)}' y='{y}' text-anchor='middle'>{Esc.HtmlEntity(text)}</text>");
        }

        public void Rect(string cls, pix x, pix y, pix w, pix h, pix r)
        {
            // SEE: https://wiki.selfhtml.org/wiki/SVG/Elemente/rect

            writer.WriteLine($"<rect{Class(cls)} x='{x}' y='{y}' width='{w}' height='{h}' rx='{r}' ry='{r}'/>");
        }

        public void Textbox(string cls, string text, pix x, pix y, pix w, pix h, pix r)
        {
            Rect(cls, x, y - D[1], w, h, r);
            Text(cls, text, x, y + (50 % D[1]), w);
        }

        public void Literal(string cls, pix x, pix y, pix w)
        {
            Rect(cls, x, y - D[1], w, D[2], 40 % D[1]);
            writer.WriteLine($"<path{Class(cls)} d='M{x},{y - (50 % D[1])} v{D[1]} m{w},{0} v{D[-1]} z'/>");
        }

        public void Arrow(pix x, pix y, bool rtl)
        {
            x += 20 % (rtl ? D[-1] : D[1]);
            var l = 40 % (rtl ? D[1] : D[-1]);
            var h = 60 % D[1];

            writer.WriteLine($"<path{Class("arrow")} d='M{x},{y} l{l},{h / 2} v{-h} z'/>");
        }

        private static string Class(string cls)
        {
            if (!string.IsNullOrWhiteSpace(cls))
            {
                return $" class='{cls}'";
            }
            return string.Empty;
        }
    }

}

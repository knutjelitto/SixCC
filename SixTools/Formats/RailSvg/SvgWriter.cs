namespace SixTools.Formats.RailSvg
{
    internal class SvgWriter
    {
        public SvgWriter(Writer writer)
        {
            this.writer = writer;
        }

        private readonly Writer writer;

        public void Text(int x, int y, int w, string text, string cls)
        {
            // SEE: https://wiki.selfhtml.org/wiki/SVG/Elemente/text

            writer.WriteLine($"<text{Cls(cls)} x='{x + (w / 2)}' y='{y}' text-anchor='middle'>{text}</text>");
        }

        public void Rect(int x, int y, int w, int h, int r, string cls)
        {
            // SEE: https://wiki.selfhtml.org/wiki/SVG/Elemente/rect

            writer.WriteLine($"<rect{Cls(cls)} x='{x}' y='{y}' height='{h}' width='{w}' rx='{r}' ry='{r}'/>");
        }

        public void Textbox(string text, int x, int y, int w, int h, int r, string klass)
        {
            Rect(x, y - 10, w, h, r, klass);
            Text(x, y + 4, w, text, klass);
        }

        public void Diamond(int x, int y, int w, string cls)
        {
            writer.WriteLine($"<path{Cls(cls)} d='M{x},{y} l{5},{-10} h{w - 10} l{5},{10} l{-5},{10} h{-(w - 10)} z'/>");
        }

        public void Arrow(int x, int y, bool rtl)
        {
            /* XXX: should be markers, but aren't for RFC 7996 */
            // SEE: https://datatracker.ietf.org/doc/html/rfc7996
            /* 2 for optical correction */

            var h = 6;

            writer.WriteLine($"<path{Cls("arrow")} d='M{x + (rtl ? -2 : 2)} {y} l{(rtl ? 4 : -4)} {h / 2} v{-h} z'/>");
        }

        private static string Cls(string cls)
        {
            if (!string.IsNullOrWhiteSpace(cls))
            {
                return $" class='{cls}'";
            }
            return string.Empty;
        }
    }

}

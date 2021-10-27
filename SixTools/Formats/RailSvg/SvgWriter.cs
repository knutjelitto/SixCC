using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixTools.Formats.RailSvg
{
    internal class SvgWriter
    {
        public SvgWriter(Writer writer)
        {
            this.writer = writer;
        }

        private readonly Writer writer;

        public void Text(int x, int y, int w, string text, string klass)
        {
            // SEE: https://wiki.selfhtml.org/wiki/SVG/Elemente/text

            writer.WriteLine($"<text x='{x + (w / 2)}' y='{y}' text-anchor='middle'{Cls(klass)}>{text}</text>");
        }

        public void Rect(int x, int y, int w, int h, int r, string klass)
        {
            // SEE: https://wiki.selfhtml.org/wiki/SVG/Elemente/rect

            writer.WriteLine($"<rect x='{x}' y='{y}' height='{h}' width='{w}' rx='{r}' ry='{r}'{Cls(klass)}/>");
        }

        public void Diam(int x, int y, int w, string cls)
        {
            writer.Write($"<path d='M{x},{y + 10} l{5},{-10} h{w - 10} l{5},{10} l{-5},{10} h{-(w - 10)} z'{Cls(cls)}/>");
        }

        public void Textbox(string text, int x, int y, int w, int h, int r, string klass)
        {
            Rect(x, y - 10, w, h, r, klass);
            Text(x, y + 4, w, text, klass);
        }

        public void Diamond(int x, int y, int w, string klass)
        {
            Diam(x, y - 10, w, klass);
        }

        public void Arrow(int x, int y, bool rtl)
        {
            /* XXX: should be markers, but aren't for RFC 7996 */
            // SEE: https://datatracker.ietf.org/doc/html/rfc7996
            /* 2 for optical correction */

            var h = 6;

            writer.WriteLine($"<path d='M{x + (rtl ? -2 : 2)} {y} l{(rtl ? 4 : -4)} {h / 2} v{-h} z' class='arrow'/>");
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

using SixTools.Tiles;
using System.Drawing;

#pragma warning disable IDE0066 // Convert switch statement to expression
#pragma warning disable CA1416 // Validate platform compatibility

namespace SixTools.Formats
{
    public class SvgDimmer : Dimmer
    {
        public SvgDimmer()
        {
            literal_padding = 0;
            rule_padding = 0;
            prose_padding = 0;
            annotation_height = 1;
            ci_marker = 2;
            ellipsis_depth = 1;
        }

        public override Dimension Monospace(string text)
        {
#if true
            SizeF size;
            using (var g = Graphics.FromImage(new Bitmap(1, 1)))
            {
                using var f = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold);
                size = g.MeasureString(text, f);
            }

            var w = Math.Max(2,  (int)Math.Ceiling(size.Width / 10));

            if (w < 2)
            {
                Assert(true);
            }

            return new Dimension()
            {
                Width = w,
                Ascender = 1,
                Descender = 1
            };
#else
            double n;

            n = 0.0;

            for (var i = 0; i < text.Length; i++)
            {
                var c = text[i];

                if (c is '\t' or '\a')
                {
                    n += 4.00;
                    continue;
                }

                if (c is < (char)32 or (char)127 or (>= (char)128 and < (char)160))
                {
                    n += 2.93; /* <XY> */
                    continue;
                }

                n += 1.0;
            }

            var w = (int)Math.Ceiling(n);

            return new Dimension()
            {
                Width = w + 1,
                Ascender = 1,
                Descender = 1
            };
#endif
        }

        public override Dimension SansSerif(string text)
        {
#if true
            SizeF size;
            using (var g = Graphics.FromImage(new Bitmap(1, 1)))
            {
                using var f = new Font(FontFamily.GenericSansSerif, 10);
                size = g.MeasureString(text, f);
            }

            var w = (int)Math.Ceiling(size.Width / 10);

            /* even numbers only, for sake of visual rhythm */
            if ((w & 1) != 0)
            {
                w++;
            }

            if (w < 2)
            {
                Assert(true);
            }

            return new Dimension()
            {
                Width = w,
                Ascender = 1,
                Descender = 1
            };
#else

            var n = 0.0;

            /* estimate a proportional width */

            for (var i = 0; i < text.Length; i += 1)
            {
                switch (char.ToLowerInvariant(text[i]))
                {
                    case '|':
                        n += 0.3;
                        break;

                    case 't':
                        n += 0.45;
                        break;

                    case 'f':
                    case 'i':
                    case 'j':
                    case 'l':
                        n += 0.5;
                        break;

                    case '(':
                    case ')':
                    case 'I':
                        n += 0.55;
                        break;

                    case ' ':
                        n += 0.6;
                        break;

                    case 'm':
                        n += 1.25;
                        break;

                    case 'w':
                        n += 1.2;
                        break;

                    case '0':
                    case '1':
                    case '2':
                    case '3':
                    case '4':
                    case '5':
                    case '6':
                    case '7':
                    case '8':
                    case '9':
                        n += 0.75;
                        break;

                    default:
                        n += 0.8;
                        break;
                }

                if (char.IsUpper(text[i]))
                {
                    n += 0.25;
                }
            }

            var w = (int)Math.Ceiling(n);

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
#endif
        }
    }
}

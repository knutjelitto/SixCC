namespace SixTools.Formats.RailSvg
{
    internal class RenderContext
    {
        public pix x;
        public pix y;
        public readonly SvgPath path = new();
        public string RefBase = string.Empty;

        public void Reset(string refBase = "")
        {
            x = pix.zero;
            y = pix.zero;
            path.Clear();
            RefBase = refBase;
        }

        public void HLineMove(pix n)
        {
            path.AddH(x, y, n);
            x += n;
        }

        public void VLine(pix n, bool up)
        {
            if (up)
            {
                path.AddV(x, y + n, -n);
            }
            else
            {
                path.AddV(x, y, n);
            }
        }

        public void RenderPaths(Writer writer)
        {
            var p = path.ExtractOne();
            while (p != null)
            {
                writer.Write($"<path class='rail' d='M{p.x1},{p.y1}");
                do
                {
                    switch (p)
                    {
                        case PathH h:
                            writer.Write($" h{h.n}");
                            break;
                        case PathV v:
                            writer.Write($" v{v.n}");
                            break;
                        case PathQ q:
                            writer.Write($" q{q.rx},{q.ry},{q.mx},{q.my}");
                            break;
                        default:
                            throw new InvalidOperationException();
                    }

                    p = path.ExtractNext(p.x2, p.y2);

                }
                while (p != null);

                writer.WriteLine("'/>");

                p = path.ExtractOne();
            }
        }
    }
}

#pragma warning disable CA1051 // Do not declare visible instance fields
#pragma warning disable CA1822 // Mark members as static
#pragma warning disable IDE1006 // Naming Styles

namespace SixTools.Formats.RailSvg
{
    public abstract class PathXY
    {
        protected PathXY(pix x, pix y)
        {
            x1 = x;
            y1 = y;
        }

        public readonly pix x1;
        public readonly pix y1;
        public abstract pix x2 { get; }
        public abstract pix y2 { get; }

        public abstract (pix x, pix y) Move();
    }

    public class PathH : PathXY
    {
        public PathH(pix x, pix y, pix n)
            : base(x, y)
        {
            this.n = n;
        }

        public pix n;
        public override pix x2 => x1 + n;
        public override pix y2 => y1;
        public override (pix x, pix y) Move()
        {
            return (x1 + n, y1);
        }
    }

    public class PathV : PathXY
    {
        public PathV(pix x, pix y, pix n)
            : base(x, y)
        {
            this.n = n;
        }

        public readonly pix n;
        public override pix x2 => x1;
        public override pix y2 => y1 + n;

        public override (pix x, pix y) Move()
        {
            return (x1, y1 + n);
        }
    }

    public class PathQ : PathXY
    {
        public PathQ(pix x, pix y, pix rx, pix ry, pix mx, pix my)
            : base(x, y)
        {
            this.rx = rx;
            this.ry = ry;
            this.mx = mx;
            this.my = my;
        }

        public override pix x2 => x1 + mx;
        public override pix y2 => y1 + my;

        public readonly pix rx;
        public readonly pix ry;
        public readonly pix mx;
        public readonly pix my;

        public override (pix x, pix y) Move()
        {
            return (x1 + mx, y1 + my);
        }
    }

    public class SvgPath
    {
        private readonly List<PathXY> paths = new();

        public int Count => paths.Count;

        public void AddH(pix x, pix y, pix n)
        {
            Assert(n >= pix.zero);
            if (n > pix.zero)
            {
                for (var i = 0; i < paths.Count; i++)
                {
                    if (paths[i] is PathH ph && ph.x2 == x && ph.y2 == y)
                    {
                        ph.n += n;
                        return;
                    }
                }
                paths.Insert(0, new PathH(x, y, n));
            }
        }

        public void AddV(pix x, pix y, pix n)
        {
            Assert(n != 0);
            if (n != 0)
            {
                paths.Insert(0, new PathV(x, y, n));
            }
        }

        public void AddQ(pix x0, pix y0, pix rx, pix ry, pix x1, pix y1)
        {
            paths.Insert(0, new PathQ(x0, y0, rx, ry, x1, y1));
        }

        public void Clear()
        {
            paths.Clear();
        }

        public void Consolidate()
        {
            //TODO: join continuous (h/v)line segments
        }

        public PathXY? ExtractOne()
        {
            if (paths.Count > 0)
            {
                var min_x1 = paths.Min(p => p.x1);
                var min_y1 = paths.Where(p => p.x1 == min_x1).Min(p => p.y1);
                var one = paths.First(p => p.x1 == min_x1 && p.y1 == min_y1);
                _ = paths.Remove(one);
                return one;
            }
            return null;
        }

        public PathXY? ExtractNext(pix x0, pix y0)
        {
            for (var i = 0; i < paths.Count; i++)
            {
                var next = paths[i];
                if (next.x1 == x0 && next.y1 == y0)
                {
                    paths.RemoveAt(i);
                    return next;
                }
            }

            return null;
        }
    }
}

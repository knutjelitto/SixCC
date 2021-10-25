#pragma warning disable CA1051 // Do not declare visible instance fields
#pragma warning disable CA1822 // Mark members as static
#pragma warning disable IDE1006 // Naming Styles

namespace SixTools.Formats
{
    public abstract class PathXY
    {
        protected PathXY(int x, int y)
        {
            x0 = x;
            y0 = y;
        }

        public readonly int x0;
        public readonly int y0;
        public abstract int x1 { get; }
        public abstract int y1 { get; }

        public abstract (int x, int y) Move();
    }

    public class PathH : PathXY
    {
        public PathH(int x, int y, int n)
            : base(x, y)
        {
            this.n = n;
        }

        public readonly int n;
        public override int x1 => x0 + n;
        public override int y1 => y0;
        public override (int x, int y) Move()
        {
            return (x0 + n, y0);
        }
    }

    public class PathV : PathXY
    {
        public PathV(int x, int y, int n)
            : base(x, y)
        {
            this.n = n;
        }

        public readonly int n;
        public override int x1 => x0;
        public override int y1 => y0 + n;

        public override (int x, int y) Move()
        {
            return (x0, y0 + n);
        }
    }

    public class PathQ : PathXY
    {
        public PathQ(int x, int y, int rx, int ry, int mx, int my)
            : base(x, y)
        {
            this.rx = rx;
            this.ry = ry;
            this.mx = mx;
            this.my = my;
        }

        public override int x1 => x0 + mx;
        public override int y1 => y0 + my;

        public readonly int rx;
        public readonly int ry;
        public readonly int mx;
        public readonly int my;

        public override (int x, int y) Move()
        {
            return (x0 + mx, y0 + my);
        }
    }

    public class SvgPath
    {
        private readonly List<PathXY> paths = new();

        public int Count => paths.Count;

        public void AddH(int x, int y, int n)
        {
            Assert(n >= 0);
            if (n > 0)
            {
                paths.Insert(0, new PathH(x, y, n));
            }
        }

        public void AddV(int x, int y, int n)
        {
            Assert(n >= 0);
            if (n > 0)
            {
                paths.Insert(0, new PathV(x, y, n));
            }
        }

        public void AddQ(int x, int y, int rx, int ry, int mx, int my)
        {
            paths.Insert(0, new PathQ(x, y, rx, ry, mx, my));
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
                var one = paths[0];
                paths.RemoveAt(0);
                return one;
            }
            return null;
        }

        public PathXY? ExtractNext(int x0, int y0)
        {
            for (var i = 0; i < paths.Count; i++)
            {
                var next = paths[i];
                if (next.x0 == x0 && next.y0 == y0)
                {
                    paths.RemoveAt(i);
                    return next;
                }
            }

            return null;
        }
    }
}

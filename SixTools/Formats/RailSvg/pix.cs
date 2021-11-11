using System.Diagnostics.CodeAnalysis;
using System.Globalization;

#pragma warning disable IDE1006 // Naming Styles

namespace SixTools.Formats.RailSvg
{
    public struct pix : IComparable<pix>
    {
        private readonly int value;

        public static readonly pix zero = new(0);

        public pix(int value)
        {
            this.value = value;
        }

        public static pix Snap(SvgDimmer d, double n)
        {
            return new pix((int)Math.Ceiling(n / d[1].value) * d[1].value);
        }

        public static explicit operator int(pix p)
        {
            return p.value;
        }

        public static pix operator -(pix p)
        {
            return new pix(-p.value);
        }

        public static pix operator +(pix p1, pix p2)
        {
            return new pix(p1.value + p2.value);
        }

        public static pix operator +(pix p, int n)
        {
            return new pix(p.value + n);
        }

        public static pix operator -(pix p1, pix p2)
        {
            return new pix(p1.value - p2.value);
        }

        public static pix operator -(pix p, int n)
        {
            return new pix(p.value - n);
        }

        public static pix operator *(int n, pix p)
        {
            return new pix(n * p.value);
        }

        public static pix operator %(int percent, pix p)
        {
            return new pix(p.value * percent / 100);
        }

        public static pix operator /(pix p, int n)
        {
            return new pix(p.value / n);
        }


        public static bool operator ==(pix p1, pix p2)
        {
            return p1.value == p2.value;
        }

        public static bool operator ==(pix p, int n)
        {
            return p.value == n;
        }

        public static bool operator !=(pix p1, pix p2)
        {
            return p1.value != p2.value;
        }

        public static bool operator !=(pix p, int n)
        {
            return p.value != n;
        }
        public static bool operator >(pix p1, pix p2)
        {
            return p1.value > p2.value;
        }

        public static bool operator <(pix p1, pix p2)
        {
            return p1.value < p2.value;
        }

        public static bool operator >=(pix p1, pix p2)
        {
            return p1.value >= p2.value;
        }

        public static bool operator >=(pix p, int n)
        {
            return p.value >= n;
        }

        public static bool operator <=(pix p1, pix p2)
        {
            return p1.value <= p2.value;
        }

        public static bool operator <=(pix p, int n)
        {
            return p.value <= n;
        }

        public override bool Equals([NotNullWhen(true)] object? obj)
        {
            return obj is pix p && p.value == value;
        }

        public override int GetHashCode()
        {
            return value.GetHashCode();
        }

        public override string ToString()
        {
            return value.ToString(CultureInfo.InvariantCulture);
        }

        public int CompareTo(pix other)
        {
            return value.CompareTo(other.value);
        }
    }

}

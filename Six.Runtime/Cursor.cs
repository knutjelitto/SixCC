using Six.Core;

namespace Six.Runtime
{
    public struct Cursor : IEquatable<Cursor>, IComparable<Cursor>
    {
        public Source Source;
        public int Offset;

        [DebuggerStepThrough]
        public Cursor(Source source, int offset)
        {
            Source = source;
            Offset = offset;
        }

        [DebuggerStepThrough]
        public bool Match(string text)
        {
            return Source.Match(Offset, text);
        }

        [DebuggerStepThrough]
        public bool Match(int cp)
        {
            return Source.Match(Offset, cp);
        }

        [DebuggerStepThrough]
        public Cursor Advance(int step)
        {
            return new Cursor(Source, Offset + step);
        }

        [DebuggerStepThrough]
        public override bool Equals([NotNullWhen(true)] object? obj)
        {
            return obj is Cursor other && Offset == other.Offset;
        }

        public static Cursor operator+(Cursor cursor, int advance)
        {
            return cursor.Advance(advance);
        }

        public bool Equals(Cursor other)
        {
            return Offset == other.Offset;
        }

        public static bool operator ==(Cursor c1, Cursor c2)
        {
            return c1.Equals(c2);
        }

        public static bool operator !=(Cursor c1, Cursor c2)
        {
            return !c1.Equals(c2);
        }

        public static bool operator <(Cursor c1, Cursor c2)
        {
            return c1.Offset < c2.Offset;
        }

        public static bool operator <=(Cursor c1, Cursor c2)
        {
            return c1.Offset <= c2.Offset;
        }

        public static bool operator >(Cursor c1, Cursor c2)
        {
            return c1.Offset > c2.Offset;
        }

        public static bool operator >=(Cursor c1, Cursor c2)
        {
            return c1.Offset >= c2.Offset;
        }

        [DebuggerStepThrough]
        public override int GetHashCode() => Offset.GetHashCode();

        public int At => Source.At(Offset);

        public override string ToString()
        {
            var (line, column) = Source.GetLineAndColumn(Offset);

            return $"({line},{column},{Offset})";
        }

        public int CompareTo(Cursor other)
        {
            return Offset.CompareTo(other.Offset);
        }
    }
}

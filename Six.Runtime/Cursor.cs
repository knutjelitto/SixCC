using Six.Core;

namespace Six.Runtime
{
    public struct Cursor : IEquatable<Cursor>
    {
        [DebuggerStepThrough]
        public Cursor(Source source, int offset)
        {
            Source = source;
            Offset = offset;
        }

        public Source Source { get; }
        public int Offset { get; }

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

        public static bool operator >(Cursor c1, Cursor c2)
        {
            return c1.Offset > c2.Offset;
        }

        public static bool operator <(Cursor c1, Cursor c2)
        {
            return c1.Offset < c2.Offset;
        }

        [DebuggerStepThrough]
        public override int GetHashCode() => Offset.GetHashCode();

        public int At => Source.At(Offset);

        public override string ToString()
        {
            return $"cursor@{Offset}";
        }
    }
}

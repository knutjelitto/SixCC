namespace Six.Runtime
{
    public record struct Cursor(Source Source, int Offset)
    {
        [DebuggerStepThrough]
        public bool Match(string text)
        {
            return Source.Match(Offset, text);
        }

        [DebuggerStepThrough]
        public Cursor Advance(int step)
        {
            return new Cursor(Source, Offset + step);
        }

        public override string ToString()
        {
            return $"cursor@{Offset}";
        }
    }
}

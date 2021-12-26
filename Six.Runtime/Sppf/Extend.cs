namespace Six.Runtime.Sppf
{
    public struct Extend
    {
        public readonly Cursor Start;
        public readonly Cursor End;

        [DebuggerStepThrough]
        public Extend(Cursor start, Cursor end)
        {
            Start = start;
            End = end;
        }

        public override string ToString()
        {
            return $"[{Start}-{End}]";
        }
    }
}

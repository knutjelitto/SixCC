namespace Six
{
    public struct Span
    {
        public Span(Source source, int before, int start, int length)
        {
            Source = source;
            Before = before;
            Start = start;
            Length = length;
        }

        public Source Source { get; }
        public int Before { get; }
        public int Start { get; }
        public int Length { get; }
        public bool HasSpaceBefore => Before < Start;

        public int LineNumber => Source.LineNumber(Start);

        public override string ToString()
        {
            return Source.Text.Substring(Start, Length);
        }
    }
}

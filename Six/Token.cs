namespace Six
{
    public class Token
    {
        public Token(TokenInfo info, Span span)
        {
            Info = info;
            Span = span;
        }
        public Token(TokenKind kind, Span span)
            : this(TokenInfo.Info[kind], span)
        {
        }

        public TokenInfo Info { get; }
        public Span Span { get; }
        public TokenKind Kind => Info.Kind;

        public bool HasSpaceBefore => Span.HasSpaceBefore;
        public int LineNumber => Span.LineNumber;

        public override string ToString()
        {
            var kind = Info.IsKeyword ? "keyword" : $"{Kind}";
            return $"{kind}({Span})";
        }
    }
}

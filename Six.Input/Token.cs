namespace Six.Input
{
    internal class Token
    {
        public Token(TKind kind, ILocation location, string payload)
        {
            Kind = kind;
            Location = location;
            Payload = payload;
        }

        public TKind Kind { get; }
        public ILocation Location { get; }
        public string Payload { get; }

        public string Text => Location.GetText();

        public override string ToString()
        {
            return $"{Kind,-11}: {Location}";
        }
    }
}

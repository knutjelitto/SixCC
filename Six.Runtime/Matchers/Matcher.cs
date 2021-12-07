namespace Six.Runtime.Matchers
{
    public abstract record Matcher(ImplementationCore Core, int Id, string Name)
    {
        public readonly Dictionary<Cursor, Context> Contexts = new();

        public Matcher[] Matchers = Array.Empty<Matcher>();

        public void Match(Cursor start, Action<Cursor> next)
        {
            Context.From(this, start, next);
        }

        public abstract void MatchCore(Context context);

        public void Set(params Matcher[] matchers)
        {
            Matchers = matchers;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}

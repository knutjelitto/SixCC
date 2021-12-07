namespace Six.Runtime.Matchers
{
    public abstract record Matcher(ImplementationCore Core, int Id, string Name)
    {
        protected readonly Dictionary<Cursor, List<Context>> Continuations = new();
        protected readonly Dictionary<Cursor, HashSet<Cursor>> Successes = new();

        public Matcher[] Matchers = Array.Empty<Matcher>();

        public virtual void Match(Context context)
        {
            MatchCore(context);
        }

        public void Match(Cursor start, Action<Cursor> next)
        {
            Match(Context.From(this, start, next));
        }

        protected abstract void MatchCore(Context context);

        public void MatchCore(Cursor start, Action<Cursor> next)
        {
            MatchCore(Context.From(this, start, next));
        }

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

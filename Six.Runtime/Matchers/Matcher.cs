namespace Six.Runtime.Matchers
{
    public abstract record Matcher(ImplementationCore Core, int Id, string Name)
    {
        public readonly Dictionary<Cursor, Context> Contexts = new();

        public Matcher[] Matchers = Array.Empty<Matcher>();

        public void Match(Cursor start, Action<Cursor> next)
        {
            Runtime.Context.From(this, start, next);
        }

        public abstract void MatchCore(Context context);

        public abstract bool IsTerminal { get; }

        public int Count => Matchers.Length;

        public void Set(params Matcher[] matchers)
        {
            Matchers = matchers;
        }

        [DebuggerStepThrough]
        public Context? Context(Cursor at)
        {
            if (Contexts.TryGetValue(at, out var context))
            {
                if (context.Nexts.Count > 0)
                {
                    return context;
                }
            }
            return null;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}

using System.Collections;

namespace Six.Runtime.Matchers
{
    public abstract record Matcher(ImplementationCore Core, int Id, string Name) : IEnumerable<Matcher>
    {
        public readonly Dictionary<Cursor, Context> Contexts = new();

        private Matcher[] Matchers = Array.Empty<Matcher>();

        public void Match(Cursor start, Action<Cursor> next)
        {
            Runtime.Context.From(this, start, next);
        }

        public abstract void MatchCore(Context context);

        public abstract bool IsTerminal { get; }

        public Matcher this[int index] => Matchers[index];

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
                return context;
            }
            return null;
        }

        public override string ToString()
        {
            return Name;
        }

        public IEnumerator<Matcher> GetEnumerator() => ((IEnumerable<Matcher>)Matchers).GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => Matchers.GetEnumerator();
    }
}

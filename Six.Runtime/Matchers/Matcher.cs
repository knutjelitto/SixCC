using System.Collections;

namespace Six.Runtime.Matchers
{
    public abstract class Matcher : IEnumerable<Matcher>
    {
        public Matcher[] Matchers = Array.Empty<Matcher>();
        public readonly Dictionary<Cursor, Context> Contexts = new();
        public Dfa.Dfa? Dfa = null;
        public bool IsAlias = false;

        protected Matcher(ImplementationCore core, int id, string name)
        {
            Core = core;
            Id = id;
            Name = name;
        }

        public ImplementationCore Core { get; }
        public int Id { get; }
        public string Name { get; }

        public virtual void Match(Cursor start, Action<Cursor> next)
        {
            Runtime.Context.Match(this, start, next);
        }

        public abstract void MatchCore(Context context);

        public virtual void Reset()
        {
            Contexts.Clear();
        }

        public abstract bool IsTerminal { get; }

        public Matcher this[int index] => Matchers[index];

        public int Count => Matchers.Length;

        public void Set(Dfa.Dfa dfa)
        {
            Dfa = dfa;
        }

        public void Set(params Matcher[] matchers)
        {
            Matchers = matchers;
        }

        //[DebuggerStepThrough]
        public Context Context(Cursor at)
        {
#if true
            return Contexts[at];
#else
            if (Contexts.TryGetValue(at, out var context))
            {
                return context;
            }
            Assert(context != null);
            return null;
#endif
        }
        
        public override string ToString()
        {
            return Name;
        }

        public Context? Furthest()
        {
            return Contexts.Values.Where(c => c.Nexts.Count > 0).MaxBy(c => c.Start.Offset);
        }

        public IEnumerable<Context> Matches()
        {
            return Contexts.Values.Where(c => c.Nexts.Count > 0);
        }

        public IEnumerator<Matcher> GetEnumerator() => ((IEnumerable<Matcher>)Matchers).GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => Matchers.GetEnumerator();
    }
}

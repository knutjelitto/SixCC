#pragma warning disable CA1822 // Mark members as static

namespace SixCC.Sdk.Automata
{
    public class UnicodeFactory : Factory
    {
        public UnicodeFactory()
            : base(UnicodeSets.Any())
        { 
        }

        public override bool IsTerminal => true;

        public override string Stringize(IntegerSet set)
        {
            return set.ToString();
        }
    }

    public class SymbolFactory : Factory
    {
        public SymbolFactory(List<string> symbols)
            : base(IntegerSet.From(0, symbols.Count - 1))
        {
            Symbols = symbols;
        }

        public List<string> Symbols { get; }

        public override bool IsTerminal => false;

        public override string Stringize(IntegerSet set)
        {
            return string.Join(", ", set.Select(s => Symbols[s]));
        }
    }

    public abstract class Factory
    {
        private readonly IntegerSet any;

        protected Factory(IntegerSet any)
        {
            this.any = any;
        }

        public IntegerSet AnySet => any;
        public int Min => any.Min;
        public int Max => any.Max;

        public NFA Any() => Build.Any(this, any);

        public NFA Epsilon() => Build.Epsilon(this);

        public NFA Universe() => Any().ZeroOrMore();

        public NFA Complement(NFA nfa)
        {
            return nfa.ToDfa(true).Complement().ToNfa();
        }

        public NFA Sequence(IEnumerable<int> sequence) =>  sequence.Select(s => Build.From(this, s)).Aggregate((a1, a2) => a1.AndThen(a2));

        public NFA Range(int min, int max) => Build.From(this, min, max);

        public abstract bool IsTerminal { get; }

        public abstract string Stringize(IntegerSet set);

        private static class Build
        {
            private static NFA Single(Factory factory, IntegerSet terminal)
            {
                var start = new State(factory);
                var end = new State(factory);

                start.AddTerminalTransition(terminal, end);

                return NFA.From(factory, start, end);
            }

            public static NFA Epsilon(Factory factory)
            {
                var startEnd = new State(factory);

                return NFA.From(factory, startEnd, startEnd);
            }

            public static NFA Any(Factory factory, IntegerSet any) => Single(factory, any);

            public static NFA From(Factory factory, int value) => Single(factory, IntegerSet.From(value));

            public static NFA From(Factory factory, int first, int last) => Single(factory, IntegerSet.From(first, last));

            public static NFA From(Factory factory, string sequence)
            {
                Debug.Assert(!string.IsNullOrEmpty(sequence));

                var start = new State(factory);
                var current = start;
                var next = (State?)null;

                foreach (var ch in sequence)
                {
                    next = new State(factory);
                    current.AddTerminalTransition(IntegerSet.From(ch), next);
                    current = next;
                }

                Debug.Assert(next != null);
                return NFA.From(factory, start, next);
            }
        }
    }
}

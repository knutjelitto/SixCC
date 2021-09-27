namespace SixCC.Sdk.Automata
{
    public sealed class NFA : FA<NFA>
    {
        private NFA(Factory factory, State start, State final)
            : base(factory, start)
        {
            Final = final;

            if (!States.Contains(final))
            {
                throw new Exception("NFA: final state not reachable");
            }
            if (States.Any(state => state.IsFinal))
            {
                Debug.Assert(false, "final state in NFA");
            }
        }

        public State Final { get; }

        public static NFA From(Factory factory, State start, State final)
        {
            return new NFA(factory, start, final);
        }

        public NFA ZeroOrMore()
        {
            var clone = Clone();

            clone.Start.AddEpsilonTransition(clone.Final);
            clone.Final.AddEpsilonTransition(clone.Start);

            return clone;
        }

        public NFA OneOrMore()
        {
            var clone = Clone();

            clone.Final.AddEpsilonTransition(clone.Start);

            return clone;
        }

        public NFA ZeroOrOne()
        {
            var clone = Clone();

            clone.Start.AddEpsilonTransition(clone.Final);

            return clone;
        }

        public NFA OrElse(NFA other)
        {
            Debug.Assert(Factory == other.Factory);

            var first = Clone();
            var second = other.Clone();
            var newEnd = new State(Factory);

            first.Start.AddEpsilonTransition(second.Start);

            first.Final.AddEpsilonTransition(newEnd);
            second.Final.AddEpsilonTransition(newEnd);


            return From(Factory, first.Start, newEnd);
        }

        public NFA AndThen(NFA other)
        {
            Debug.Assert(Factory == other.Factory);

            var first = Clone();
            var second = other.Clone();

            first.Final.AddEpsilonTransition(second.Start);

            return From(Factory, first.Start, second.Final);
        }

        public static NFA AndThen(IEnumerable<NFA> nfas)
        {
            return nfas.Aggregate((n1, n2) => n1.AndThen(n2));
        }

        public static NFA OrElse(IEnumerable<NFA> nfas)
        {
            return nfas.Aggregate((n1, n2) => n1.OrElse(n2));
        }

        public DFA ToDfa(bool cloned = false)
        {
            return Operations.ToDfa(CloneIf(cloned));
        }

        public DFA ToFinalDfa(bool cloned = false)
        {
            return ToDfa(cloned).ToFinalDfa();
        }

        public override NFA Clone()
        {
            var map = CloneMap();

            return From(Factory, map[Start], map[Final]);
        }

        protected override bool IsFinal(State state) => state == Final;
    }
}

namespace SixCC.Sdk.Automata
{
    public sealed class DFA : FA<DFA>
    {
        private DFA(Factory factory, State start)
            : base(factory, start)
        {
            if (!States.Any(state => state.IsFinal))
            {
                Debug.Assert(false, "no final state in DFA");
            }
        }

        public int ID { get; set; } = -1;
        public string Symbol { get; set; } = string.Empty;

        public static DFA From(Factory factory, State start)
        {
            return new DFA(factory, start);
        }

        public DFA Complete(bool cloned = false)
        {
            return Operations.Complete(CloneIf(cloned));
        }

        public DFA Union(DFA other, bool cloned = false)
        {
            return Operations.Union(CloneIf(cloned), other.CloneIf(cloned));
        }

        public DFA Intersection(DFA other, bool cloned = false)
        {
            return Operations.Intersection(CloneIf(cloned), other.CloneIf(cloned));
        }

        public DFA Difference(DFA other, bool cloned = false)
        {
            return Operations.Difference(CloneIf(cloned), other.CloneIf(cloned));
        }

        public DFA Minimize(bool cloned = false)
        {
            return Operations.Minimize(CloneIf(cloned));
        }

        public NFA ToNfa(bool cloned = false)
        {
            return Operations.ToNfa(CloneIf(cloned));
        }

        public DFA ToFinalDfa(bool cloned = false)
        {
            return CloneIf(cloned).RemoveDead().Minimize().RemoveDead().Numbering();
        }

        public DFA RemoveDead(bool cloned = false)
        {
            return Operations.RemoveDead(CloneIf(cloned));
        }

        public DFA Complement(bool cloned = false)
        {
            return Operations.Complement(CloneIf(cloned));
        }

        public override DFA Clone()
        {
            var map = CloneMap();

            return From(Factory, map[Start]);
        }

        protected override bool IsFinal(State state) => state.IsFinal;

        public DFA Explode()
        {
            foreach (var state in States)
            {
                var newTransitions = new List<Transition>();

                foreach (var transition in state.Transitions)
                {
                    foreach (var nonterminalId in transition.Set)
                    {
                        var newTransition = new TerminalTransition(Factory, IntegerSet.From(nonterminalId), transition.Target)
                        {
                            ID = newTransitions.Count
                        };
                        newTransitions.Add(newTransition);
                    }
                }
                state.Transitions.Clear();
                state.Transitions.AddRange(newTransitions);
            }

            return this;
        }

        private DFA Numbering()
        {
            for (var stateId = 0; stateId < States.Count; stateId += 1)
            {
                var state = States[stateId];
                state.ID = stateId;
                Debug.Assert(state.ID == stateId);
                for (var transitionId = 0; transitionId < state.Transitions.Count; transitionId += 1)
                {
                    var transition = state.Transitions[transitionId];
                    Debug.Assert(transition.ID == -1);
                    transition.ID = transitionId;
                }
            }

            return this;
        }
    }
}

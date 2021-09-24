using SixCC.Sdk.Automata;

namespace SixCC.Sdk.Earley
{
    public class EarleySet
    {
        public List<EarleyItem> Items = new();

        public EarleySet(EarleyChart chart, Parser parser, int setID)
        {
            Chart = chart;
            Parser = parser;
            ID = setID;
        }

        public EarleyChart Chart { get; }
        public Parser Parser { get; }
        public int ID { get; }

        private void Complete(EarleyItem finished)
        {
            Debug.Assert(finished.IsFinal);

            var origin = finished.OriginSet;

            var count = origin.Items.Count;

            // iterate counted in case of Origin == finished.Origin
            for (var i = 0; i < count; i += 1)
            {
                var item = origin.Items[i];
                foreach (var transition in item.State.Transitions)
                {
                    if (transition.Matches(finished))
                    {
                        AdvanceItem(finished, item, transition.Target);
                    }
                }
                if (item == finished)
                {
                    AdvanceItem(finished, finished, finished.State);
                }
            }
        }

        public void Earley()
        {
            int index = 0;

            while (index < Items.Count)
            {
                var item = Items[index];

                if (item.Dfa.IsNonterminal)
                {
                    foreach (var transition in item.State.Transitions)
                    {
                        Debug.Assert(transition.ID >= 0);
                        Debug.Assert(transition.Set.Cardinality == 1);

                        var dfaID = transition.Set.Single;

                        var newDfa = Parser.Automaton.Dfas[dfaID];
                        if (newDfa.IsTerminal)
                        {
                            if (Parser.Match(newDfa, ID, out var nextOffset, out var state))
                            {
                                Chart[nextOffset].AddItem(newDfa, state, this);
                            }
                        }
                        else
                        {
                            StartItem(newDfa, this);
                        }
                    }
                }
                if (item.IsFinal)
                {
                    Complete(item);
                }
                index += 1;
            }
        }

        public EarleyItem AdvanceItem(EarleyItem finished, EarleyItem item, State target)
        {
            var next = AddItem(item.Dfa, target, item.OriginSet);

            next.AddFrom(item, finished);

            return next;
        }

        public EarleyItem StartItem(Automata.DFA dfa, EarleySet origin)
        {
            return AddItem(dfa, dfa.Start, origin);
        }

        public EarleyItem AddItem(Automata.DFA dfa, State state, EarleySet origin)
        {
            foreach (var item in Items)
            {
                if (item.Dfa.ID == dfa.ID && item.State.ID == state.ID && item.OriginSet.ID == origin.ID)
                {
                    return item;
                }
            }

            var newItem = new EarleyItem(this, dfa, state, origin)
            {
                ID = Items.Count
            };
            Items.Add(newItem);
            return newItem;
        }

        public override string ToString()
        {
            return $"Set[{ID}] Item[#{Items.Count}]";
        }
    }
}

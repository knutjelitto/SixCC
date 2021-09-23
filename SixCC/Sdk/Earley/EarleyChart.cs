namespace SixCC.Sdk.Earley
{
    public class EarleyChart : IEnumerable<EarleySet>
    {
        private List<EarleySet?> sets = new();

        public EarleyChart(Parser parser)
        {
            Parser = parser;
        }

        public EarleySet this[int offset]
        {
            get
            {
                while (offset >= sets.Count)
                {
                    sets.Add(null);
                }
                if (sets[offset] == null)
                {
                    sets[offset] = new EarleySet(this, Parser, offset);
                }
                Debug.Assert(sets[offset] != null);
                return sets[offset]!;
            }
        }

        public Parser Parser { get; }
        public Automaton Automaton => Parser.Automaton;

        public EarleySet Last
        {
            get
            {
                for (var i = sets.Count - 1; i >= 0; i--)
                {
                    if (sets[i] is EarleySet set)
                    {
                        return set;
                    }
                }

                throw new InvalidOperationException();
            }
        }

        public EarleySet First
        {
            get
            {
                for (var i = 0; i < sets.Count; i++)
                {
                    if (sets[i] is EarleySet set)
                    {
                        return set;
                    }
                }

                throw new InvalidOperationException();
            }
        }

        public IEnumerable<EarleyItem> Results()
        {
            foreach (var item in Last.Items)
            {
                if (item.Dfa == Automaton.Start && item.IsFinal && item.OriginSet.ID == 0)
                {
                    yield return item;
                }
            }
        }

        public IEnumerator<EarleySet> GetEnumerator()
        {
            for (var i = 0; i < sets.Count; i++)
            {
                if (sets[i] is EarleySet set)
                {
                    yield return set;
                }
            }
        }

        public IEnumerable<EarleyItem> Earley()
        {
            sets.Clear();
            var first = this[0];
            first.StartItem(Automaton.Start, first);

            int offset = 0;
            EarleySet? set;
            while ((set = Next(ref offset)) != null)
            {
                set.Earley();
            }

            if (offset == Parser.Source.Length + 1)
            {
                foreach (var item in this[offset - 1].Items)
                {
                    if (item.Dfa == Automaton.Start && item.IsFinal)
                    {
                        yield return item;
                    }
                }
            }
        }

        private EarleySet? Next(ref int offset)
        {
            while (offset < sets.Count && sets[offset] == null)
            {
                offset += 1;
            }
            if (offset < sets.Count)
            {
                return sets[offset++];
            }
            return null;

        }

        IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)this.sets).GetEnumerator();
    }
}

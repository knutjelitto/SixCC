namespace SixTools.Ast
{
    public class Rule
    {
        public Rule(TokenTerm name, Term term)
        {
            Name = name;
            Term = term;
            InUse = false;
        }

        public TokenTerm Name { get; }
        public Term Term { get; private set; }
        public bool InUse { get; set; }

        public void Shrink()
        {
            Term = Shrink(Term);
        }

        private static Term Shrink(Term term)
        {
            if (term is AlternativesTerm alt)
            {
                Assert(alt.Count >= 1);
                for (var i = 0; i < alt.Count; i++)
                {
                    alt[i] = Shrink(alt[i]);
                }
                var epsilonCount = alt.Count(a => a is EpsilonTerm);
                if (epsilonCount > 1)
                {
                    for (var i = alt.Count - 1; i >= 0; i--)
                    {
                        if (epsilonCount > 1 && alt[i] is EpsilonTerm)
                        {
                            alt.RemoveAt(i);
                            epsilonCount--;
                        }
                    }
                }

                if (alt.Count == 1)
                {
                    return alt[0];
                }
                Assert(alt.Count >= 2);

            }
            else if (term is SequenceTerm seq)
            {
                Assert(seq.Count >= 0);
                for (var i = 0; i < seq.Count; i++)
                {
                    seq[i] = Shrink(seq[i]);
                }
                if (seq.Count == 0)
                {
                    return new EpsilonTerm();
                }
                if (seq.Count == 1)
                {
                    return seq[0];
                }
                Assert(seq.Count >= 2);
            }
            else if (term is ClampedTerm clamped)
            {
                if (clamped.Inner.IsAtomic)
                {
                    return clamped.Inner;
                }
            }
            else if (term is GroupTerm group)
            {
                group.Inner = Shrink(group.Inner);
                if (group.Min == 1 && group.Max == 1 && group.Inner.IsAtomic)
                {
                    return group.Inner;
                }
            }
            else if (term is NotTerm not)
            {
                not.Inner = Shrink(not.Inner);
            }
            else if (term is TerminalTerm terminal)
            {
                terminal.Inner = Shrink(terminal.Inner);
            }
            return term;
        }
    }
}

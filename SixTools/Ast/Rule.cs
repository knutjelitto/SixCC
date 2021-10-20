namespace SixTools.Ast
{
    public class Rule
    {
        public Rule(TermToken name, Term term)
        {
            Name = name;
            Term = term;
        }

        public TermToken Name { get; }
        public Term Term { get; private set; }

        public void Shrink()
        {
            Term = Shrink(Term);
        }

        private static Term Shrink(Term term)
        {
            if (term is TermAlternatives alt)
            {
                for (var i = 0; i < alt.Terms.Count; i++)
                {
                    alt.Terms[i] = Shrink(alt.Terms[i]);
                }
                if (alt.Terms.Count == 1)
                {
                    return alt.Terms[0];
                }
            }
            else if (term is TermSequence seq)
            {
                for (var i = 0; i < seq.Terms.Count; i++)
                {
                    seq.Terms[i] = Shrink(seq.Terms[i]);
                }
                if (seq.Terms.Count == 1)
                {
                    return seq.Terms[0];
                }
            }
            else if (term is TermGroup group)
            {
                group.Term = Shrink(group.Term);
                if (group.Min == 1 && group.Max == 1 && group.Term.IsAtomic)
                {
                    return group.Term;
                }
            }
            return term;
        }
    }
}

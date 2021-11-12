namespace SixTools.Ast
{
    internal static class TermBuilder
    {
        public static Term Optional(IEnumerable<Term> zeroOrOne)
        {
            return zeroOrOne.SingleOrDefault() ?? new EpsilonTerm();
        }

        public static Term Group(Term inner, RepetitionSuffix rep)
        {
            return rep switch
            {
                RepetitionSuffix.None => inner,
                RepetitionSuffix.ZeroOrOne => new ZeroOrOneTerm(inner),
                RepetitionSuffix.ZeroOrMore => new ZeroOrMoreTerm(inner),
                RepetitionSuffix.OneOrMore => new OneOrMoreTerm(inner),
                _ => throw new InvalidOperationException(),
            };
        }

        public static Term Alternatives(Term first, IEnumerable<Term> rest)
        {
            return Alternatives(Enumerable.Repeat(first, 1).Concat(rest));
        }

        public static Term Alternatives(IEnumerable<Term> terms)
        {
            var alts = terms.ToList();
            if (alts.Count == 1)
            {
                return alts[0];
            }
            Assert(alts.Count >= 2);
            return new AlternativesTerm(alts);
        }

        public static Term Sequence(IEnumerable<Term> terms)
        {
            var seqs = terms.ToList();
            if (seqs.Count == 0)
            {
                return new EpsilonTerm();
            }
            if (seqs.Count == 1)
            {
                return seqs[0];
            }
            Assert(seqs.Count >= 2);
            return new SequenceTerm(seqs);
        }
    }
}

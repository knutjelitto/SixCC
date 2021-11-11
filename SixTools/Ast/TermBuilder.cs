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
    }
}

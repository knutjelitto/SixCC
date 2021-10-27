using SixTools.Ast;

namespace SixTools.Rails
{
    public static class RailMaker
    {
        public static Railroad Make(Term term)
        {
            switch (term)
            {
                case TermToken token:
                    return token.IsReference
                        ? new ReferenceRail(token.Text)
                        : new TokenRail(token.Text);
                case TermLiteral literal:
                    return new LiteralRail(literal.Text);
                case TermComment comment:
                    return new CommentRail(comment.Text);
                case TermProse prose:
                    return new ProseRail(prose.Text);
                case TermAny any:
                    return new AnyRail();
                case TermEpsilon:
                    return new PlainRail();
                case TermNot not:
                    return new NotRail(Make(not.Term));
                case TermRange range:
                    return new RangeRail(range.Start.Text, range.Stop.Text);
                default:
                    break;

            }
            if (term is TermSequence seq)
            {
                Assert(seq.Terms.Count >= 2);
                return new SequenceRail(seq.Terms.Select(t => Make(t)));
            }
            else if (term is TermAlternatives alt)
            {
                Assert(alt.Terms.Count >= 2);
                return new ChoiceRail(alt.Terms.Select(t => Make(t)));
            }
            else if (term is TermZeroOrOne zeroOrOne)
            {
                return new ChoiceRail(new PlainRail(), Make(zeroOrOne.Term))
                {
                    Offset = 1
                };
            }
            else if (term is TermZeroOrMore zeroOrMore)
            {
                return new LoopRail(Make(zeroOrMore.Term), new PlainRail(), true, 0, 0);
            }
            else if (term is TermOneOrMore oneOrMore)
            {
                return new LoopRail(Make(oneOrMore.Term), new PlainRail(), false, 1, 0);
            }
            else if (term is TermLoop loop)
            {
                return new LoopRail(Make(loop.Term), new PlainRail(), loop.Min == 0, loop.Min, loop.Max);
            }
            else if (term is TermClamped clamped)
            {
                Assert(!clamped.Term.IsAtomic);
                // Drop clamping
                return Make(clamped.Term);
            }
            else if (term is TermNot not)
            {
            }
            else if (term is TermRange range)
            {
            }
            throw new InvalidOperationException();
        }
    }
}

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
                case TermSequence seq:
                    Assert(seq.Terms.Count >= 2);
                    return new SequenceRail(seq.Terms.Select(t => Make(t)));
                case TermAlternatives alternatives:
                    Assert(alternatives.Terms.Count >= 2);
                    return new ChoiceRail(alternatives.Terms.Select(t => Make(t)));
                case TermZeroOrOne zeroOrOne:
                    return new ChoiceRail(new PlainRail(), Make(zeroOrOne.Term));
                case TermZeroOrMore zeroOrMore:
                    return new LoopRail(Make(zeroOrMore.Term), new PlainRail(), 0, 0);
                case TermOneOrMore oneOrMore:
                    return new LoopRail(Make(oneOrMore.Term), new PlainRail(), 1, 0);
                case TermLoop loop:
                    return new LoopRail(Make(loop.Term), new PlainRail(), loop.Min, loop.Max);
                case TermClamped clamped:
                    Assert(!clamped.Term.IsAtomic);
                    // Drop clamping
                    return Make(clamped.Term);
                default:
                    throw new InvalidOperationException();

            }
        }
    }
}

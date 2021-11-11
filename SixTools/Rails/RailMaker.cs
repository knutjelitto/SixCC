using SixTools.Ast;

namespace SixTools.Rails
{
    public static class RailMaker
    {
        public static Railroad Make(Term term)
        {
            switch (term)
            {
                case TokenTerm token:
                    return token.IsReference
                        ? new ReferenceRail(token.Text)
                        : new TokenRail(token.Text);
                case LiteralTerm literal:
                    return new LiteralRail(literal.Text);
                case CommentTerm comment:
                    return new CommentRail(comment.Text);
                case ProseTerm prose:
                    return new ProseRail(prose.Text);
                case AnyTerm any:
                    return new AnyRail();
                case EpsilonTerm:
                    return new PlainRail();
                case NotTerm not:
                    return new NotRail(Make(not.Inner));
                case RangeTerm range:
                    return new RangeRail(range.Start.Text, range.Stop.Text);
                case SequenceTerm seq:
                    Assert(seq.Count >= 2);
                    return new SequenceRail(seq.Select(t => Make(t)));
                case AlternativesTerm alternatives:
                    Assert(alternatives.Count >= 2);
                    return new ChoiceRail(alternatives.Select(t => Make(t)));
                case ZeroOrOneTerm zeroOrOne:
                    return new ChoiceRail(new PlainRail(), Make(zeroOrOne.Inner));
                case ZeroOrMoreTerm zeroOrMore:
                    return new LoopRail(Make(zeroOrMore.Inner), new PlainRail(), 0, 0);
                case OneOrMoreTerm oneOrMore:
                    return new LoopRail(Make(oneOrMore.Inner), new PlainRail(), 1, 0);
                case LoopTerm loop:
                    return new LoopRail(Make(loop.Inner), new PlainRail(), loop.Min, loop.Max);
                case ClampedTerm clamped:
                    Assert(!clamped.Inner.IsAtomic);
                    // Drop clamping
                    return Make(clamped.Inner);
                case TerminalTerm terminal:
                    return Make(terminal.Inner);
                default:
                    throw new InvalidOperationException();

            }
        }
    }
}

using Six.Rex;

namespace Six.Gen.Ebnf
{
    public class RexTransformer : EbnfTransformer<FA>
    {
        public RexTransformer(EbnfGrammar grammar)
        {
            Grammar = grammar;
        }

        public EbnfGrammar Grammar { get; }

        public EbnfGrammar Transform()
        {
            var white = Grammar.WhitespaceRule;
            Transform(white);

            foreach (var rule in Grammar.Rules.Where(r => r.Argument is TokenOp))
            {
                Transform(rule);
            }

            var others = Grammar.Others.ToList();

            foreach (var not in others.OfType<NotOp>())
            {
                Transform(not);
            }

            return Grammar;
        }

        private void Transform(RuleOp rule)
        {
            rule.DFA = Transform(rule.Argument).ToFinalDfa();
        }

        private void Transform(NotOp not)
        {
            not.DFA = Transform(not.Argument).ToFinalDfa();
        }

        protected override FA Visit(AltOp op)
        {
            return FA.Or(Transform(op.Arguments.First()), op.Arguments.Skip(1).Select(x => Transform(x)).ToArray())
                .ToFinalDfa();
        }

        protected override FA Visit(SeqOp op)
        {
            if (op.Arguments.Count == 0)
            {
                return FA.Epsilon().ToFinalDfa();
            }
            else
            {
                return FA.And(Transform(op.Arguments.First()), op.Arguments.Skip(1).Select(x => Transform(x)).ToArray())
                    .ToFinalDfa();
            }
        }

        protected override FA Visit(StarOp op)
        {
            var inner = Transform(op.Argument);

            return inner.Star().ToFinalDfa();
        }

        protected override FA Visit(PlusOp op)
        {
            var inner = Transform(op.Argument);

            return inner.Plus().ToFinalDfa();
        }

        protected override FA Visit(StringOp op)
        {
            return FA.From(op.Text).ToFinalDfa();
        }

        protected override FA Visit(RangeOp op)
        {
            return FA.From((int)op.Codepoint1, (int)op.Codepoint2).ToFinalDfa();
        }

        protected override FA Visit(RefOp op)
        {
            var dfa = Transform(op.Rule.Argument).ToFinalDfa();

            return dfa;
        }

        protected override FA Visit(SetOp op)
        {
            var first = Transform(op.Arguments[0]).ToFinalDfa();
            var second = Transform(op.Arguments[1]).ToFinalDfa();

            return first.Difference(second).ToFinalDfa();
        }

        protected override FA Visit(AnyOp op)
        {
            return FA.Any().ToFinalDfa();
        }

        protected override FA Visit(OptionalOp op)
        {
            return Transform(op.Argument).Opt().ToFinalDfa();
        }

        protected override FA Visit(TokenOp op)
        {
            return Transform(op.Argument).ToFinalDfa();
        }
    }
}

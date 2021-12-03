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

            foreach (var rule in Grammar.Rules)
            {
                if (rule.Argument is not TokenOp)
                {
                    continue;
                }
                Transform(rule);
            }

            return Grammar;
        }

        private void Transform(RuleOp rule)
        {
            rule.DFA = Transform(rule.Argument).ToDfa().Minimize().RemoveDead();
        }

        protected override FA Visit(AltOp op)
        {
            return FA.Or(Transform(op.First()), op.Skip(1).Select(x => Transform(x)).ToArray())
                .ToDfa().Minimize().RemoveDead().ToDfa();
        }

        protected override FA Visit(SeqOp op)
        {
            if (op.Arguments.Count == 0)
            {
                return FA.Epsilon().ToDfa();
            }
            else
            {
                return FA.And(Transform(op.Arguments.First()), op.Arguments.Skip(1).Select(x => Transform(x)).ToArray())
                    .ToDfa().Minimize().RemoveDead();
            }
        }

        protected override FA Visit(StarOp op)
        {
            var inner = Transform(op.Argument);

            return inner.Star().ToDfa().Minimize().RemoveDead();
        }

        protected override FA Visit(PlusOp op)
        {
            var inner = Transform(op.Argument);

            return inner.Plus().ToDfa().Minimize().RemoveDead();
        }

        protected override FA Visit(StringOp op)
        {
            return FA.From(op.Text).ToDfa().Minimize().RemoveDead();
        }

        protected override FA Visit(CharacterOp op)
        {
            return FA.From((int)op.Codepoint)
                .ToDfa().Minimize().RemoveDead().ToDfa();
        }

        protected override FA Visit(RangeOp op)
        {
            return FA.From((int)op.Codepoint1, (int)op.Codepoint2)
                .ToDfa().Minimize().RemoveDead().ToDfa();
        }

        protected override FA Visit(RefOp op)
        {
            var dfa = Transform(op.Rule.Argument).Minimize().RemoveDead().ToDfa();

            //op.Rule.DFA = dfa;

            return dfa;
        }

        protected override FA Visit(DiffOp op)
        {
            var first = Transform(op.Arguments[0]).Minimize().RemoveDead().ToDfa();
            var second = Transform(op.Arguments[1]).Minimize().RemoveDead().ToDfa();

            return first.Difference(second).Minimize().RemoveDead().ToDfa();
        }

        protected override FA Visit(NotOp op)
        {
            var inner = Transform(op.Argument).ToDfa();
            return inner.ToDfa().Complete().Complement().Minimize().RemoveDead().ToDfa();
        }

        protected override FA Visit(AnyOp op)
        {
            return FA.Any().ToDfa().Minimize().RemoveDead().ToDfa();
        }

        protected override FA Visit(OptionalOp op)
        {
            return Transform(op.Argument).Opt();
        }

        protected override FA Visit(TokenOp op)
        {
            return Transform(op.Argument);
        }
    }
}

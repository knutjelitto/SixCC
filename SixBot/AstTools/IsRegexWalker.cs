namespace SixBot.Ast
{
    internal class IsRegexWalker : PredicateWalker
    {
        public IsRegexWalker()
            : base(ex => ex.IsRegex, (ex, value) => { ex.IsRegex = value; })
        {
        }

        protected override void Visit(Grammar grammar)
        {
            Changed = true;
            while (Changed)
            {
                Changed = false;
                base.Visit(grammar);
            }
        }

        protected override void Visit(Alt alt)
        {
            base.Visit(alt);
            Set(alt, alt.Expressions.All(e => e.IsRegex));
        }

        protected override void Visit(Any any)
        {
            base.Visit(any);
            Set(any, true);
        }

        protected override void Visit(Epsilon epsilon)
        {
            Set(epsilon, true);
        }

        protected override void Visit(Compact terminal)
        {
            base.Visit(terminal);
            Set(terminal, terminal.Expression.IsRegex);
        }

        protected override void Visit(Literal literal)
        {
            Set(literal, true);
        }

        protected override void Visit(OneOrMore oneOrMore)
        {
            base.Visit(oneOrMore);
            Set(oneOrMore, oneOrMore.Expression.IsRegex);
        }

        protected override void Visit(Range range)
        {
            base.Visit(range);
            Set(range, range.Start.IsRegex && range.End.IsRegex);
        }

        protected override void Visit(Reference reference)
        {
            base.Visit(reference);
            Set(reference, reference.Rule.IsRegex);
        }

        protected override void Visit(Rule rule)
        {
            base.Visit(rule);
            Set(rule, rule.Expression.IsRegex);
        }

        protected override void Visit(Seq seq)
        {
            base.Visit(seq);
            Set(seq, seq.Expressions.All(e => e.IsRegex));
        }

        protected override void Visit(Substract substract)
        {
            base.Visit(substract);
            Set(substract, substract.Left.IsRegex && substract.Right.IsRegex);
        }

        protected override void Visit(Undefined undefined)
        {
            base.Visit(undefined);
            Set(undefined, false);
        }

        protected override void Visit(ZeroOrMore zeroOrMore)
        {
            base.Visit(zeroOrMore);
            Set(zeroOrMore, zeroOrMore.Expression.IsRegex);
        }

        protected override void Visit(ZeroOrOne zeroOrOne)
        {
            base.Visit(zeroOrOne);
            Set(zeroOrOne, zeroOrOne.Expression.IsRegex);
        }
    }
}

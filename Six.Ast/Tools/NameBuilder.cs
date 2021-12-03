namespace Six.Ast
{
    internal class NameBuilder : Walker
    {
        const string Left = "❬";
        const string Right = "❭";

        private readonly StringBuilder builder = new();

        public string Name(Expression expression)
        {
            builder.Clear();
            Walk(expression);
            return builder.ToString();
        }

        private void DoLeft(Expression expression)
        {
            if (!expression.IsSimple)
            {
                builder.Append(Left);
            }
        }

        private void DoRight(Expression expression)
        {
            if (!expression.IsSimple)
            {
                builder.Append(Right);
            }
        }

        protected override void Visit(Alternation alt)
        {
            DoLeft(alt);
            Walk(alt.Expressions.First());
            foreach (var expr in alt.Expressions.Skip(1))
            {
                builder.Append(" | ");
                Walk(expr);
            }
            DoRight(alt);
        }

        protected override void Visit(Any any)
        {
            builder.Append('.');
        }

        protected override void Visit(Token terminal)
        {
            builder.Append('<');
            Walk(terminal.Expression);
            builder.Append('>');
        }

        protected override void Visit(Literal literal)
        {
            builder.Append(literal.ToString());
        }

        protected override void Visit(Range range)
        {
            builder.Append(Left);
            Walk(range.One);
            builder.Append("..");
            Walk(range.Two);
            builder.Append(Right);
        }

        protected override void Visit(Reference reference)
        {
            builder.Append(reference.Name);
        }

        protected override void Visit(Sequence seq)
        {
            DoLeft(seq);
            Walk(seq.Expressions.First());
            foreach (var expr in seq.Expressions.Skip(1))
            {
                builder.Append(" ");
                Walk(expr);
            }
            DoRight(seq);
        }

        protected override void Visit(Undefined undefined)
        {
            throw new NotImplementedException();
        }

        protected override void Visit(OneOrMore oneOrMore)
        {
            builder.Append(Left);
            Walk(oneOrMore.Expression);
            builder.Append("+");
            builder.Append(Right);
        }

        protected override void Visit(ZeroOrMore zeroOrMore)
        {
            builder.Append(Left);
            Walk(zeroOrMore.Expression);
            builder.Append("*");
            builder.Append(Right);
        }

        protected override void Visit(ZeroOrOne zeroOrOne)
        {
            builder.Append(Left);
            Walk(zeroOrOne.Expression);
            builder.Append("?");
            builder.Append(Right);
        }

        protected override void Visit(NotPredicate not)
        {
            builder.Append(Left);
            builder.Append("!");
            Walk(not.Expression);
            builder.Append(Right);
        }

        protected override void Visit(AndPredicate and)
        {
            builder.Append(Left);
            builder.Append("&");
            Walk(and.Expression);
            builder.Append(Right);
        }
    }
}

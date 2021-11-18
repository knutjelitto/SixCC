using Six.Ast;
using Six.Input.Errors;

namespace Six.Input
{
    internal class Parser
    {
        private readonly Tokens tokens;
        private int current;
        private readonly GrammarBuilder builder;

        public Parser(Tokens tokens_)
        {
            tokens = tokens_;
            current = 0;
            builder = new GrammarBuilder();
        }

        private Token Current => tokens[current];
        private Token Next => tokens[current + 1];

        public Grammar Grammar()
        {
            Keyword("grammar");
            var name = Name();
            Match(TKind.Semi);
            Rules();

            return builder.Grammar(name.Text);
        }

        public void Rules()
        {
            do
            {
                Rule();
            }
            while (Current.Kind != TKind.EOF && Current.Kind != TKind.RightCurly);
        }

        private Rule Rule()
        {
            var name = Name();
            Match(TKind.Colon);
            var expression = Expression();
            Match(TKind.Semi);

            return builder.Rule(name.Location, name.Text, expression);
        }

        private Expression Expression()
        {
            return Alternation();
        }

        private Expression Alternation()
        {
            var expressions = new List<Expression>();
            do
            {
                expressions.Add(Sequence());
            }
            while (Try(TKind.Alter));

            return builder.Alt(expressions.First().Location, expressions);
        }

        private Expression Sequence()
        {
            var location = Current.Location;

            var expressions = new List<Expression>();
            while (!Check(TKind.Alter, TKind.Semi, TKind.RightParent, TKind.RightCurly, TKind.RightAngle, TKind.EOF))
            {
                expressions.Add(Element());
            }

            return builder.Seq(location, expressions);
        }

        private Expression Element()
        {
            return Difference();
        }

        private Expression Difference()
        {
            var expr = Range();
            while (Try(TKind.Minus))
            {
                var end = Range();
                expr = builder.Difference(expr.Location, expr, end);
            }
            return expr;
        }

        private Expression Range()
        {
            var expr = Repeat();
            if (Try(TKind.Range))
            {
                var end = Repeat();
                expr = builder.Range(expr.Location, expr, end);
            }
            return expr;
        }

        private Expression Repeat()
        {
            var element = Primary();
            switch (Current.Kind)
            {
                case TKind.Option:
                    Match(Current.Kind);
                    element = builder.ZeroOrOne(element.Location, element);
                    break;
                case TKind.Star:
                    Match(Current.Kind);
                    element = builder.ZeroOrMore(element.Location, element);
                    break;
                case TKind.Plus:
                    Match(Current.Kind);
                    element = builder.OneOrMore(element.Location, element);
                    break;
                default:
                    break;
            }
            return element;
        }

        private Expression Primary()
        {
            Expression expression;
            switch (Current.Kind)
            {
                case TKind.Literal:
                    expression = Literal();
                    break;
                case TKind.Name:
                    expression = Reference();
                    break;
                case TKind.Any:
                    expression = builder.Any(Current.Location);
                    Match(Current.Kind);
                    break;
                case TKind.LeftParent:
                    Match(TKind.LeftParent);
                    expression = Expression();
                    Match(TKind.RightParent);
                    break;
                case TKind.LeftAngle:
                    Match(TKind.LeftAngle);
                    var inner = Expression();
                    expression = builder.Compact(inner.Location, inner);
                    Match(TKind.RightAngle);
                    break;
                default:
                    expression = Error<Expression>($"expected 'primary', but found '{Current.Kind}'");
                    break;
            }
            return expression;
        }

        private Expression Literal()
        {
            var token = Match(TKind.Literal);
            return builder.Literal(token.Location, token.Text, token.Payload);
        }

        private Token Name()
        {
            return Match(TKind.Name);
        }

        private Expression Reference()
        {
            var token = Match(TKind.Name);
            return builder.Ref(token.Location, token.Text);
        }

        private bool Check(params TKind[] kinds)
        {
            return kinds.Any(kind => Current.Kind == kind);
        }

        private Token Match(TKind kind)
        {
            if (Current.Kind == kind)
            {
                var token = Current;
                current += 1;
                return token;
            }
            return Error<Token>($"expected '{kind}', but found '{Current.Kind}'");
        }

        private bool Try(TKind kind)
        {
            if (Current.Kind == kind)
            {
                current += 1;
                return true;
            }
            return false;
        }

        private void Keyword(string name)
        {
            if (Current.Kind == TKind.Name && Current.Text == name)
            {
                current += 1;
                return;
            }
            Error<Token>($"expected '{name}', but found '{Current.Text}'");
        }

        private T Error<T>(string message)
        {
            throw new DiagnosticException(new SyntaxError(Current.Location, message));
        }
    }
}

using Six.Ast;
using Six.Core.Errors;

namespace Six.Input
{
    internal class Parser
    {
        private readonly Tokens tokens;
        private int current;
        private readonly GrammarBuilder builder;

        public Parser(Tokens tokens)
        {
            this.tokens = tokens;
            current = 0;
            builder = new GrammarBuilder();
        }

        private Token Current => tokens[current];
        private Token Next => tokens[current + 1];

        public AstGrammar Parse()
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

        private Symbol Rule()
        {
            var name = Name();
            Expression expression;
            if (Check(TKind.Alter))
            {
                Match(TKind.Alter);
                expression = TopExpression();
            }
            else
            {
                Match(TKind.Assign);
                expression = Expression();
            }
            Match(TKind.Semi);

            return builder.Indefinite(name.Location, name.Text, expression);
        }

        private Expression TopExpression()
        {
            return Alternation();
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

            return builder.Alternation(expressions.First().Location, expressions);
        }

        private Expression Sequence()
        {
            var location = Current.Location;

            var expressions = new List<Expression>();
            while (!Check(TKind.Alter, TKind.Semi, TKind.RightParent, TKind.RightCurly, TKind.RightAngle, TKind.EOF))
            {
                expressions.Add(Element());
            }

            return builder.Sequence(location, expressions);
        }

        private Expression Element()
        {
            return Range();
        }

        private Expression Range()
        {
            var first = Repeat();
            if (Try(TKind.Range))
            {
                var second = Repeat();
                first = builder.Range(first.Location, first, second);
            }
            else if (Try(TKind.Minus))
            {
                var second = Repeat();
                first = builder.Diff(first.Location, first, second);
            }
            return first;
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
                    Match(TKind.Any);
                    expression = builder.Any(Current.Location);
                    break;
                case TKind.Complement:
                    Match(TKind.Complement);
                    expression = builder.Complement(Current.Location, Primary());
                    break;
                case TKind.Not:
                    Match(TKind.Not);
                    expression = builder.Not(Current.Location, Primary());
                    break;
                case TKind.LeftParent:
                    Match(TKind.LeftParent);
                    expression = Expression();
                    Match(TKind.RightParent);
                    break;
                case TKind.LeftAngle:
                    expression = Token();
                    break;
                default:
                    expression = Error<Expression>($"expected 'primary', but found '{Current.Kind}'");
                    break;
            }
            return expression;
        }

        private Expression Token()
        {
            Match(TKind.LeftAngle);
            var inner = Expression();
            var expression = builder.Token(inner.Location, inner);
            Match(TKind.RightAngle);
            return expression;
        }

        private Expression Literal()
        {
            var token = Match(TKind.Literal);
            return builder.Literal(token.Location, token.Payload);
        }

        private Token Name()
        {
            return Match(TKind.Name);
        }

        private Expression Reference()
        {
            var token = Match(TKind.Name);
            return builder.Reference(token.Location, token.Text);
        }

        private bool Check(params TKind[] kinds)
        {
            return kinds.Any(kind => Current.Kind == kind);
        }

        private Token Match(params TKind[] kinds)
        {
            if (Check(kinds))
            {
                var token = Current;
                current += 1;
                return token;
            }
            var which = string.Join(", ", kinds);
            return Error<Token>($"expected '{which}', but found '{Current.Kind}'");
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

using SixCC.CC.Errors;
using SixCC.CC.Tree;
using System.Collections.Generic;
using System.Linq;

namespace SixCC.CC
{
    internal class Parser
    {
        private readonly Tokens tokens;
        private int current;

        public Parser(Tokens tokens)
        {
            this.tokens = tokens;
            this.current = 0;
        }

        private Token Current => tokens[current];
        private Token Next => tokens[current + 1];

        public Grammar Grammar()
        {
            Keyword("grammar");
            var name = Name();
            Match(TKind.Semi);
            var rules = new List<Rule>();
            do
            {
                rules.Add(Rule());
            }
            while (Current.Kind != TKind.EOF);

            return new Grammar(name, rules);
        }

        private Rule Rule()
        {
            var name = Name();
            Match(TKind.Colon);
            var expression = Expression();
            Match(TKind.Semi);

            return new Rule(name, expression);
        }

        private Alt Expression()
        {
            var expressions = new List<Cat>();
            do
            {
                expressions.Add(Sequence());
            }
            while (Try(TKind.Alter));
            
            return new Alt(expressions[0].Location, expressions);
        }

        private Cat Sequence()
        {
            var expressions = new List<Expression>();
            while (!Check(TKind.Alter, TKind.Semi, TKind.RightParent, TKind.EOF))
            {
                expressions.Add(Difference());
            }
            var location = expressions.FirstOrDefault()?.Location ?? Current.Location;
            return new Cat(location, expressions);
        }

        private Expression Difference()
        {
            var element = Element();
            if (Current.Kind == TKind.Minus)
            {
                Match(TKind.Minus);
                var element2 = Element();
                element = new Difference(element, element2);
            }
            return element;
        }

        private Expression Element()
        {
            var element = Primary();
            switch (Current.Kind)
            {
                case TKind.Quest:
                    Match(Current.Kind);
                    element = new ZeroOrOne(element);
                    break;
                case TKind.Star:
                    Match(Current.Kind);
                    element = new ZeroOrMore(element);
                    break;
                case TKind.Plus:
                    Match(Current.Kind);
                    element = new OneOrMore(element);
                    break;
                case TKind.Minus:
                    {
                        Match(Current.Kind);
                        var element2 = Primary();
                        element = new Difference(element, element2);
                        break;
                    }
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
                    if (Current.Kind == TKind.Range)
                    {
                        Match(TKind.Range);
                        expression = new Tree.Range(expression, Literal());
                    }
                    break;
                case TKind.Name:
                    expression = Reference();
                    break;
                case TKind.Epsilon:
                    expression = Epsilon();
                    break;
                case TKind.Any:
                    expression = Any();
                    break;
                case TKind.LeftParent:
                    Match(TKind.LeftParent);
                    expression = Expression();
                    Match(TKind.RightParent);
                    break;
                case TKind.Exclam:
                    Match(TKind.Exclam);
                    expression = new Complement(Primary());
                    break;
                default:
                    expression = Error<Expression>($"expected 'primary', but found '{Current.Kind}'");
                    break;
            }
            return expression;
        }

        private Literal Literal()
        {
            return new Literal(Match(TKind.Literal));
        }

        private Name Name()
        {
            return new Name(Match(TKind.Name));
        }

        private Reference Reference()
        {
            return new Reference(Match(TKind.Name));
        }

        private Any Any()
        {
            return new Any(Match(TKind.Any));
        }

        private Epsilon Epsilon()
        {
            return new Epsilon(Match(TKind.Epsilon));
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

namespace Six.Ast
{
    public class Walker
    {
        public void Walk(Grammar grammar)
        {
            Visit(grammar);
        }

        public void Walk(Symbol symbol)
        {
            Visit(symbol);
        }

        public void Walk(Expression expression)
        {
            switch (expression)
            {
                case Symbol expr:
                    Visit(expr);
                    break;
                case Sequence expr:
                    Visit(expr);
                    break;
                case Alternation expr:
                    Visit(expr);
                    break;
                case ZeroOrMore expr:
                    Visit(expr);
                    break;
                case ZeroOrOne expr:
                    Visit(expr);
                    break;
                case OneOrMore expr:
                    Visit(expr);
                    break;
                case Reference expr:
                    Visit(expr);
                    break;
                case Literal expr:
                    Visit(expr);
                    break;
                case Compact expr:
                    Visit(expr);
                    break;
                case Any expr:
                    Visit(expr);
                    break;
                case Range expr:
                    Visit(expr);
                    break;
                case NotPredicate expr:
                    Visit(expr);
                    break;
                case AndPredicate expr:
                    Visit(expr);
                    break;
                default:
                    throw new NotImplementedException($"can't visit expression of type {expression.GetType()}");
            }
        }

        protected virtual void Visit(Grammar grammar)
        {
            foreach (var rule in grammar.Symbols)
            {
                Walk(rule);
            }
        }

        protected virtual void Visit(Symbol symbol)
        {
            Walk(symbol.Expression);
        }

        protected virtual void Visit(Alternation alt)
        {
            foreach (var expression in alt.Expressions)
            {
                Walk(expression);
            }
        }

        protected virtual void Visit(Sequence seq)
        {
            foreach (var expression in seq.Expressions)
            {
                Walk(expression);
            }
        }

        protected virtual void Visit(ZeroOrMore zeroOrMore)
        {
            Walk(zeroOrMore.Expression);
        }

        protected virtual void Visit(OneOrMore oneOrMore)
        {
            Walk(oneOrMore.Expression);
        }

        protected virtual void Visit(ZeroOrOne zeroOrOne)
        {
            Walk(zeroOrOne.Expression);
        }

        protected virtual void Visit(NotPredicate not)
        {
            Walk(not.Expression);
        }

        protected virtual void Visit(AndPredicate and)
        {
            Walk(and.Expression);
        }

        protected virtual void Visit(Reference reference)
        {
        }

        protected virtual void Visit(Any any)
        {
        }

        protected virtual void Visit(Undefined undefined)
        {
        }

        protected virtual void Visit(Literal literal)
        {
        }

        protected virtual void Visit(Compact compact)
        {
            Walk(compact.Expression);
        }

        protected virtual void Visit(Range range)
        {
            Walk(range.One);
            Walk(range.Two);
        }
    }
}

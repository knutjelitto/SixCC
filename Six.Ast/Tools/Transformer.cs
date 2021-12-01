namespace Six.Ast
{
    public class Transformer
    {
        protected Transformer(Grammar grammar)
        {
            Grammar = grammar;
            Transformed = new Grammar(grammar.Name);
        }

        public Grammar Grammar { get; }
        public Grammar Transformed { get; }

        public Grammar Transform()
        {
            return Visit(Grammar);
        }

        protected Expression Transform(bool top, Expression expression)
        {
            switch (expression)
            {
                case Sequence expr:
                    return Visit(top, expr);
                case Alternation expr:
                    return Visit(top, expr);
                case ZeroOrMore expr:
                    return Visit(top, expr);
                case ZeroOrOne expr:
                    return Visit(top, expr);
                case OneOrMore expr:
                    return Visit(top, expr);
                case Reference expr:
                    return Visit(top, expr);
                case Literal expr:
                    return Visit(top, expr);
                case Compact expr:
                    return Visit(top, expr);
                case Any expr:
                    return Visit(top, expr);
                case Range expr:
                    return Visit(top, expr);
                case NotPredicate expr:
                    return Visit(top, expr);
                case AndPredicate expr:
                    return Visit(top, expr);
                default:
                    throw new NotImplementedException($"can't transform expression of type {expression.GetType()}");
            }
        }

        protected virtual Grammar Visit(Grammar grammar)
        {
            var newGrammar = new Grammar(grammar.Name);

            for (var i = 0; i < grammar.Symbols.Count; i++)
            {
                newGrammar.Add(Visit(grammar.Symbols[i]));
            }

            return newGrammar;
        }

        protected virtual Symbol Visit(Symbol rule)
        {
            return new Indefinite(rule.Location, rule.Name, Transform(true, rule.Expression))
            {
                IsFragment = rule.IsFragment,
            };
        }

        protected virtual Expression Visit(bool top, Alternation alt)
        {
            return new Alternation(alt.Location, alt.Expressions.Select(expr => Transform(false, expr)));
        }

        protected virtual Expression Visit(bool top, Sequence seq)
        {
            return new Sequence(seq.Location, seq.Expressions.Select(expr => Transform(false, expr)));
        }

        protected virtual Expression Visit(bool top, ZeroOrMore zeroOrMore)
        {
            return new ZeroOrMore(zeroOrMore.Location, Transform(false, zeroOrMore.Expression));
        }

        protected virtual Expression Visit(bool top, OneOrMore oneOrMore)
        {
            return new OneOrMore(oneOrMore.Location, Transform(false, oneOrMore.Expression));
        }

        protected virtual Expression Visit(bool top, ZeroOrOne zeroOrOne)
        {
            return new ZeroOrOne(zeroOrOne.Location, Transform(false, zeroOrOne.Expression));
        }

        protected virtual Expression Visit(bool top, NotPredicate not)
        {
            return new NotPredicate(not.Location, Transform(false, not.Expression));
        }

        protected virtual Expression Visit(bool top, AndPredicate and)
        {
            return new NotPredicate(and.Location, Transform(false, and.Expression));
        }

        protected virtual Expression Visit(bool top, Reference reference)
        {
            return new Reference(Transformed, reference.Location, reference.Name);
        }

        protected virtual Expression Visit(bool top, Any any)
        {
            return any;
        }

        protected virtual Expression Visit(bool top, Undefined undefined)
        {
            return undefined;
        }

        protected virtual Expression Visit(bool top, Literal literal)
        {
            return literal;
        }

        protected virtual Expression Visit(bool top, Compact compact)
        {
            return new Compact(compact.Location, Transform(false, compact.Expression));
        }

        protected virtual Expression Visit(bool top, Range range)
        {
            return new Range(range.Location, Transform(false, range.One), Transform(false, range.Two));
        }
    }
}

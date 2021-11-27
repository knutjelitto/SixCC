namespace Six.Ast
{
    public class BnfTransformer : Transformer
    {
        private readonly NameBuilder namer = new();
        private readonly UniqueList<string, Nonterminal> innerNonterminals = new(r => r.Name);
        private readonly UniqueList<string, Terminal> innerTerminals = new(r => r.Name);

        public BnfTransformer(Grammar grammar)
            : base(grammar)
        {
        }

        private IEnumerable<Expression> Transform(bool top, IEnumerable<Expression> expressions)        
        {
            return expressions.Select(expr => Transform(top, expr));
        }

        protected override Grammar Visit(Grammar grammar)
        {
            var id = 0;
            foreach (var nonterminal in grammar.Nonterminals())
            {
                var newNonterminal = new Nonterminal(nonterminal.Location, nonterminal.Name, Transform(true, nonterminal.Expression))
                {
                    Id = id++,
                    IsFragment = false,
                };
                Transformed.Add(newNonterminal);
            }
            foreach (var nonterminal in innerNonterminals)
            {
                nonterminal.Id = id++;
                Transformed.Add(nonterminal);
            }

            foreach (var terminal in grammar.Terminals())
            {
                var newTerminal = new Terminal(terminal.Location, terminal.Name, SimplifyTerminal(terminal.Expression))
                {
                    Id = id++,
                    IsFragment = false,
                };
                Transformed.Add(newTerminal);
            }
            foreach (var terminal in innerTerminals)
            {
                terminal.Id = id++;
                Transformed.Add(terminal);
            }

            foreach (var fragment in grammar.Fragments())
            {
                var newFragment = new Fragment(fragment.Location, fragment.Name, SimplifyTerminal(fragment.Expression))
                {
                    Id = id++,
                    IsFragment = true,
                };
                Transformed.Add(newFragment);
            }

            return Transformed;
        }

        protected override Expression Visit(bool top, Alternation alt)
        {
            if (top)
            {
                return new Alternation(alt.Location, Transform(true, alt.Expressions));
            }

            var name = namer.Name(alt);
            if (!innerNonterminals.Contains(name))
            {
                var rule = new Nonterminal(alt.Location, name, new Alternation(alt.Location, Transform(true, alt.Expressions)));
                innerNonterminals.Add(rule);
            }

            return new Reference(Transformed, alt.Location, name);
        }

        protected override Expression Visit(bool top, Sequence seq)
        {
            if (!top)
            {
                Assert(true);
            }
            return base.Visit(top, seq);
        }

        protected override Expression Visit(bool top, OneOrMore oneOrMore)
        {
            var name = namer.Name(oneOrMore);
            if (!innerNonterminals.Contains(name))
            {
                var expression = Transform(false, oneOrMore.Expression);
                var expressionSeq = new Sequence(oneOrMore.Location, expression);
                var reference = new Reference(Transformed, oneOrMore.Location, name);
                var sequence = new Sequence(oneOrMore.Location, reference, expression);
                var bnf = new Alternation(oneOrMore.Location, expressionSeq, sequence);
                var rule = new Nonterminal(oneOrMore.Location, name, bnf);
                innerNonterminals.Add(rule);
            }

            return new Reference(Transformed, oneOrMore.Location, name);
        }

        protected override Expression Visit(bool top, ZeroOrMore zeroOrMore)
        {
            var name = namer.Name(zeroOrMore);
            if (!innerNonterminals.Contains(name))
            {
                var expression = Transform(false, zeroOrMore.Expression);
                var expressionSeq = new Sequence(zeroOrMore.Location, expression);
                var reference = new Reference(Transformed, zeroOrMore.Location, name);
                var sequence = new Sequence(zeroOrMore.Location, reference, expression);
                var epsilon = new Sequence(zeroOrMore.Location);

                var bnf = new Alternation(zeroOrMore.Location, expressionSeq, sequence, epsilon);
                var rule = new Nonterminal(zeroOrMore.Location, name, bnf);
                innerNonterminals.Add(rule);
            }

            return new Reference(Transformed, zeroOrMore.Location, name);
        }

        protected override Expression Visit(bool top, ZeroOrOne zeroOrOne)
        {
            var name = namer.Name(zeroOrOne);
            if (!innerNonterminals.Contains(name))
            {
                var expression = Transform(false, zeroOrOne.Expression);
                var expressionSeq = new Sequence(zeroOrOne.Location, expression);
                var epsilon = new Sequence(zeroOrOne.Location);

                var bnf = new Alternation(zeroOrOne.Location, expressionSeq, epsilon);
                var rule = new Nonterminal(zeroOrOne.Location, name, bnf);
                innerNonterminals.Add(rule);
            }

            return new Reference(Transformed, zeroOrOne.Location, name);
        }

        protected override Expression Visit(bool top, NotPredicate not)
        {
            var name = namer.Name(not);
            if (!innerNonterminals.Contains(name))
            {
                var expression = Transform(false, not.Expression);
                var expressionSeq = new Sequence(not.Location, expression);

                var bnf = new Alternation(not.Location, expressionSeq);
                var rule = new Nonterminal(not.Location, name, bnf);
                innerNonterminals.Add(rule);
            }

            return new Reference(Transformed, not.Location, name);
        }

        protected override Expression Visit(bool top, AndPredicate and)
        {
            return base.Visit(top, and);
        }

        protected override Expression Visit(bool top, Any any)
        {
            var name = namer.Name(any);
            if (!innerNonterminals.Contains(name))
            {
                var expressionSeq = new Sequence(any.Location, any);

                var bnf = new Alternation(any.Location, expressionSeq);
                var rule = new Nonterminal(any.Location, name, bnf);
                innerNonterminals.Add(rule);
            }

            return new Reference(Transformed, any.Location, name);
        }

        protected override Expression Visit(bool top, Literal literal)
        {
            var name = namer.Name(literal);
            if (!innerTerminals.Contains(name))
            {
                var rule = new Terminal(literal.Location, name, literal);
                innerTerminals.Add(rule);
            }

            return new Reference(Transformed, literal.Location, name);
        }

        private Expression SimplifyTerminal(Expression expression)
        {
            switch (expression)
            {
                case Compact expr:
                    return SimplifyTerminal(expr.Expression);
                case IWithOne expr:
                    expr.Expression = SimplifyTerminal(expr.Expression);
                    return expression;
                case IWithTwo expr:
                    expr.One = SimplifyTerminal(expr.One);
                    expr.Two = SimplifyTerminal(expr.Two);
                    return expression;
                case IWithMany expr:
                    if (expr.Expressions.Count == 1)
                    {
                        return SimplifyTerminal(expr.Expressions[0]);
                    }
                    else
                    {
                        for (var i = 0; i < expr.Expressions.Count; ++i)
                        {
                            expr.Expressions[i] = SimplifyTerminal(expr.Expressions[i]);
                        }
                        return expression;
                    }
                default:
                    return expression;
            }
        }
    }
}

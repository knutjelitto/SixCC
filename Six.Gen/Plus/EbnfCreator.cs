namespace Six.Gen.Ebnf
{
    public class EbnfCreator
    {
        private UniqueList<string, Operator> Inners;
        private OpNamer Namer;

        public EbnfCreator(Ast.Grammar grammar)
        {
            Grammar = grammar;
            Ebnf = new EbnfGrammar(grammar.Name);
            Namer = new OpNamer();
            Inners = new UniqueList<string, Operator>(op => Namer.NameOf(op));
        }

        public Ast.Grammar Grammar { get; }
        public EbnfGrammar Ebnf { get; }

        public EbnfGrammar Create()
        {
            var startRule = Add(new StartRuleOp("%start"));
            var whiteRule = Add(new WhiteRuleOp("%whitespace"));

            var startSymbol = Grammar.StartRule;
            if (startSymbol != null)
            {
                startRule.Set(Transform(startSymbol.Expression));
            }
            else
            {
                var defaultStart = Grammar.Symbols.First();
                startRule.Set(Add(new RefOp(Ebnf, defaultStart.Name)));
            }

            var whiteSymbol = Grammar.WhitespaceRule;
            if (whiteSymbol != null)
            {
                whiteRule.Set(Transform(whiteSymbol.Expression));
            }
            else
            {
                whiteRule.Set(Add(new EpsilonOp()));
            }

            foreach (var symbol in Grammar.Symbols)
            {
                if (symbol == startSymbol || symbol == whiteSymbol)
                {
                    continue;
                }

                var name = symbol.Name;
                var transformed = Transform(symbol.Expression);

                Add(new RuleOp(name, transformed));
            }

            var id = 0;
            foreach (var op in Inners)
            {
                Assert(op.Id == -1);
                op.Id = id++;

                Ebnf.Add(op);
            }


            return Ebnf;
        }

        private T Add<T>(T newOp)
            where T : Operator
        {
            var name = Namer.NameOf(newOp);

            if (!Inners.TryGetValue(name, out var op))
            {
                op = newOp;
                Inners.Add(op);
            }

            return (T)op;
        }

        private Operator Transform(Ast.Expression expression)
        {
            return Add(transform());

            Operator transform()
            {
                switch (expression)
                {
                    case Ast.Sequence expr:
                        return Visit(expr);
                    case Ast.Alternation expr:
                        return Visit(expr);
                    case Ast.ZeroOrMore expr:
                        return Visit(expr);
                    case Ast.ZeroOrOne expr:
                        return Visit(expr);
                    case Ast.OneOrMore expr:
                        return Visit(expr);
                    case Ast.NotPredicate expr:
                        return Visit(expr);
                    case Ast.AndPredicate expr:
                        return Visit(expr);
                    case Ast.Reference expr:
                        return Visit(expr);
                    case Ast.Literal expr:
                        return Visit(expr);
                    case Ast.Compact expr:
                        return Visit(expr);
                    case Ast.Any expr:
                        return Visit(expr);
                    case Ast.Range expr:
                        return Visit(expr);
                    case Ast.Undefined expr:
                        return Visit(expr);
                    default:
                        throw new NotImplementedException($"can't transform expression of type {expression.GetType()}");
                }
            }
        }

        protected virtual Operator Visit(Ast.Alternation alt)
        {
            Assert(alt.Expressions.Count >= 1);
            if (alt.Expressions.Count == 1)
            {
                return Transform(alt.Expressions[0]);
            }
            else
            {
                return new AltOp(alt.Expressions.Select(e => Transform(e)));
            }
        }

        private Operator Visit(Ast.Sequence seq)
        {
            Assert(seq.Expressions.Count >= 0);
            if (seq.Expressions.Count == 0)
            {
                return new EpsilonOp();
            }
            else if (seq.Expressions.Count == 1)
            {
                return Transform(seq.Expressions[0]);
            }
            else
            {
                return new SeqOp(seq.Expressions.Select(e => Transform(e)));
            }
        }

        private Operator Visit(Ast.ZeroOrMore zeroOrMore)
        {
            return new StarOp(Transform(zeroOrMore.Expression));
        }

        private Operator Visit(Ast.OneOrMore oneOrMore)
        {
            return new PlusOp(Transform(oneOrMore.Expression));
        }

        private Operator Visit(Ast.ZeroOrOne zeroOrOne)
        {
            return new OptionalOp(Transform(zeroOrOne.Expression));
        }

        private Operator Visit(Ast.NotPredicate not)
        {
            return new NotOp(Transform(not.Expression));
        }

        private Operator Visit(Ast.AndPredicate and)
        {
            return new AndOp(Transform(and.Expression));
        }

        private Operator Visit(Ast.Reference reference)
        {
            return new RefOp(Ebnf, reference.Name);
        }

        private Operator Visit(Ast.Any any)
        {
            return new AnyOp();
        }

        private Operator Visit(Ast.Undefined undefined)
        {
            throw new NotImplementedException();
        }

        private Operator Visit(Ast.Literal literal)
        {
            var cps = literal.Text.Codepoints().ToList();
            Assert(cps.Count >= 1);

            if (cps.Count == 1)
            {
                return new CharacterOp(cps[0]);
            }
            return new StringOp(literal.Text);
        }

        private Operator Visit(Ast.Range range)
        {
            if (range.One.ToString() == "' '")
            {
                Assert(true);
            }
            var start = Transform(range.One);
            var end = Transform(range.Two);

            if (start is CharacterOp cp1 && end is CharacterOp cp2)
            {
                return new RangeOp(cp1.Codepoint, cp2.Codepoint);
            }

            Assert(start is CharacterOp && end is CharacterOp);
            throw new NotImplementedException();
        }

        private Operator Visit(Ast.Compact compact)
        {
            return new TokenOp(Transform(compact.Expression));
        }
    }
}

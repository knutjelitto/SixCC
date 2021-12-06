using Six.Core.Errors;
using Six.Input;

namespace Six.Gen.Ebnf
{
    public class EbnfCreator
    {
        private readonly OpNamer Namer;
        private readonly UniqueList<string, Operator> Inners;
        private readonly List<RefOp> References;

        public EbnfCreator(Ast.AstGrammar grammar)
        {
            Grammar = grammar;
            Ebnf = new EbnfGrammar(grammar.Name);
            Namer = new OpNamer();
            Inners = new UniqueList<string, Operator>(op => Namer.NameOf(op));
            References = new List<RefOp>();
        }

        public Ast.AstGrammar Grammar { get; }
        public EbnfGrammar Ebnf { get; private set; }

        public EbnfGrammar Create()
        {
            var startRule = Add(new StartRuleOp("%start", Location.Nowhere));
            var whiteRule = Add(new WhiteRuleOp("%whitespace", Location.Nowhere));

            var startSymbol = Grammar.StartRule;
            if (startSymbol != null)
            {
                startRule.Set(startSymbol.Location, Transform(startSymbol.Expression));
            }
            else
            {
                var defaultStart = Grammar.Symbols.First(s => !s.Name.StartsWith("%"));
                startRule.Set(Add(new RefOp(Ebnf, Location.Nowhere, defaultStart.Name)));
            }

            var whiteSymbol = Grammar.WhitespaceRule;
            if (whiteSymbol != null)
            {
                whiteRule.Set(whiteSymbol.Location, Transform(whiteSymbol.Expression));
            }
            else
            {
                whiteRule.Set(Add(new SeqOp(Location.Nowhere)));
            }

            foreach (var symbol in Grammar.Symbols)
            {
                if (symbol == startSymbol || symbol == whiteSymbol)
                {
                    continue;
                }

                var name = symbol.Name;
                var transformed = Transform(symbol.Expression);

                AddNamedRule(new RuleOp(name, symbol.Location, transformed));
            }

            foreach (var reference in References)
            {
                if (!Inners.Contains(reference.Name))
                {
                    throw new DiagnosticException(new SemanticError(reference.Location, $"can't reference undefined rule '{reference.Name}'"));
                }
            }

            var id = 0;
            foreach (var op in Inners)
            {
                Assert(op.Id == -1);
                op.Id = id++;

                Ebnf.Add(op);
            }

            Ebnf = new DiffTransformer(Ebnf).Transform();
            Ebnf = new RexTransformer(Ebnf).Transform();

            return Ebnf;
        }

        private RuleOp AddNamedRule(RuleOp rule)
        {
            if (Inners.TryGetValue(rule.Name, out var op))
            {
                var already = (RuleOp)op;
                var diagnostic1 = new SemanticError(rule.Location, $"rule '{rule.Name}' already defined elsewhere");
                var diagnostic2 = new SemanticError(already.Location, $"rule '{already.Name}' defined here");
                throw new DiagnosticException(diagnostic1, diagnostic2);
            }
            Inners.Add(rule);

            return rule;
        }

        private T Add<T>(T newOp)
            where T : Operator
        {
            var name = Namer.NameOf(newOp);

            if (!Inners.TryGetValue(name, out var op))
            {
                op = newOp;
                Inners.Add(op);

                if (op is RefOp refOp)
                {
                    References.Add(refOp);
                }
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
                    case Ast.Reference expr:
                        return Visit(expr);
                    case Ast.Literal expr:
                        return Visit(expr);
                    case Ast.Token expr:
                        return Visit(expr);
                    case Ast.Any expr:
                        return Visit(expr);
                    case Ast.Range expr:
                        return Visit(expr);
                    case Ast.Diff expr:
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
                return new AltOp(alt.Location, alt.Expressions.Select(e => Transform(e)));
            }
        }

        private Operator Visit(Ast.Sequence seq)
        {
            Assert(seq.Expressions.Count >= 0);

            var transformed = seq.Expressions.Select(e => Transform(e)).ToList();

            if (seq.Expressions.Count == 1)
            {
                return transformed[0];
            }
            else
            {
                return new SeqOp(seq.Location, transformed);
            }
        }

        private Operator Visit(Ast.ZeroOrMore zeroOrMore)
        {
            return new StarOp(zeroOrMore.Location, Transform(zeroOrMore.Expression));
        }

        private Operator Visit(Ast.OneOrMore oneOrMore)
        {
            return new PlusOp(oneOrMore.Location, Transform(oneOrMore.Expression));
        }

        private Operator Visit(Ast.ZeroOrOne zeroOrOne)
        {
            return new OptionalOp(zeroOrOne.Location, Transform(zeroOrOne.Expression));
        }

        private Operator Visit(Ast.Reference reference)
        {
            var op = new RefOp(Ebnf, reference.Location, reference.Name);
            return op;
        }

        private Operator Visit(Ast.Any any)
        {
            return new AnyOp(any.Location);
        }

        private Operator Visit(Ast.Literal literal)
        {
            var cps = literal.Text.Codepoints().ToList();
            Assert(cps.Count >= 1);

            if (cps.Count == 1)
            {
                return new CharacterOp(literal.Location, cps[0]);
            }
            return new StringOp(literal.Location, literal.Text);
        }

        private Operator Visit(Ast.Range range)
        {
            var start = Transform(range.One);
            var end = Transform(range.Two);

            if (start is CharacterOp cp1 && end is CharacterOp cp2)
            {
                return new RangeOp(range.Location, cp1.Codepoint, cp2.Codepoint);
            }

            Assert(start is CharacterOp && end is CharacterOp);
            throw new NotImplementedException();
        }

        private Operator Visit(Ast.Diff diff)
        {
            var first = Transform(diff.One);
            var second = Transform(diff.Two);

            return new DiffOp(diff.Location, first, second);
        }

        private Operator Visit(Ast.Token token)
        {
            return new TokenOp(token.Location, Transform(token.Expression));
        }
    }
}

using Six.Core.Errors;
using Six.Input;
using Six.Rex;

namespace Six.Gen.Ebnf
{
    public class EbnfCreator
    {
        private readonly NameWalker Namer;
        private readonly UniqueList<string, CoreOp> Inners;
        private readonly List<RefOp> References;
        private int currentId = 0;

        public EbnfCreator(Ast.AstGrammar grammar)
        {
            Grammar = grammar;
            Ebnf = new EbnfGrammar(grammar.Name);
            Namer = new NameWalker();
            Inners = new UniqueList<string, CoreOp>(op => Namer.NameOf(op));
            References = new List<RefOp>();
        }

        public Ast.AstGrammar Grammar { get; }
        public EbnfGrammar Ebnf { get; private set; }

        public EbnfGrammar Create()
        {
            var startRule = Add(new StartRuleOp(Ast.AstGrammar.TheStart, Location.Nowhere));
            var whiteRule = Add(new WhiteRuleOp(Ast.AstGrammar.TheWhitespace, Location.Nowhere));
            var keywordsRule = Add(new IdentifierRuleOp(Ast.AstGrammar.TheKeywords, Location.Nowhere));

            var startSymbol = Grammar.StartRule;
            if (startSymbol != null)
            {
                startRule.Set(startSymbol.Location, Create(startSymbol.Expression));
            }
            else
            {
                var defaultStart = Grammar.Symbols.First(s => !s.Name.StartsWith("%"));
                startRule.Patch(Add(new RefOp(Ebnf, Location.Nowhere, defaultStart.Name)));
            }

            var whiteSymbol = Grammar.WhitespaceRule;
            if (whiteSymbol != null)
            {
                whiteRule.Set(whiteSymbol.Location, Create(whiteSymbol.Expression));
                if (whiteRule.Argument is not TokenOp)
                {
                    whiteRule.Patch(Add(new TokenOp(whiteRule.Argument.Location, whiteRule.Argument)));
                }
            }
            else
            {
                whiteRule.Patch(Add(new TokenOp(Location.Nowhere, Add(new SeqOp(Location.Nowhere)))));
            }

            var keywordsSymbol = Grammar.KeywordsRule;
            if (keywordsSymbol != null)
            {
                var expression = Create(keywordsSymbol.Expression);
                Assert(expression is RefOp);
                var token = Add(new TokenOp(keywordsSymbol.Expression.Location, expression));
                keywordsRule.Set(keywordsSymbol.Location, token);
            }
            else
            {
                var range = Add(new RangeOp(Location.Nowhere, new Codepoint('a'), new Codepoint('z')));
                var plus = Add(new PlusOp(Location.Nowhere, range));
                keywordsRule.Patch(Add(new TokenOp(Location.Nowhere, plus)));
            }

            foreach (var symbol in Grammar.Symbols)
            {
                if (symbol == startSymbol || symbol == whiteSymbol || symbol == keywordsSymbol)
                {
                    continue;
                }

                var name = symbol.Name;
                var transformed = Create(symbol.Expression);

                if (transformed is TokenOp)
                {
                    AddNamedRule(new DfaRuleOp(name, symbol.Location, transformed));
                }
                else
                {
                    AddNamedRule(new PlainRuleOp(name, symbol.Location, transformed));
                }
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
                Assert(op.Id == id);

                id++;

                Ebnf.Add(op);
            }

            new ReachWalker().Reach(Ebnf);

            Ebnf = new SetTransformer(Ebnf).Transform();
            Ebnf = new RexTransformer(Ebnf).Transform();

            var final = new List<CoreOp>();
            id = 0;
            // all reached rules
            foreach (var op in Ebnf.Rules.Where(op => op.IsReached))
            {
                op.Id = id++;
                final.Add(op);
            }
            // all reached non-references
            foreach (var op in Ebnf.Others.Where(op => op.IsReached && op is not TokenOp && op is not RefOp))
            {
                op.Id = id++;
                final.Add(op);
            }
            // all reached references
            foreach (var op in Ebnf.Others.Where(op => op.IsReached && op is not TokenOp && op is RefOp))
            {
                op.Id = id++;
                final.Add(op);
            }
            Ebnf.Patch(final);

            foreach (var op in Ebnf.Operators)
            {
                Assert(op.IsReached);
            }

            var keywords = new SortedSet<string>();

            if (keywordsSymbol != null)
            {
                Assert(keywordsRule.DFA != null);
                var dfa = keywordsRule.DFA;
                Assert(dfa != null);
                var keywordMatcher = new Rex.Matcher(dfa!);

                foreach (var str in Ebnf.Operators.OfType<StringOp>())
                {
                    if (keywordMatcher.FullMatch(str.Text))
                    {
                        str.IsKeyword = true;
                        keywords.Add(str.Text);
                    }
                }
            }

            Ebnf.SetKeywords(keywords.OrderBy(k => k.Length));

            if (keywordsSymbol != null && keywords.Count > 0)
            {
                if (keywordsRule != null && keywordsRule.Argument is TokenOp token && token.Argument is RefOp refOp && refOp.Rule is DfaRuleOp identifier)
                {
                    var fa = FA.From(keywords.First());
                    foreach (var next in keywords.Skip(1))
                    {
                        fa = fa.Or(FA.From(next));
                    }

                    var modifiedIdentifierDFA = identifier.DFA!.Difference(fa.ToFinalDfa(), true).ToFinalDfa();

                    identifier.DFA = modifiedIdentifierDFA;
                }
            }

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
            Add(rule);

            return rule;
        }

        private T Add<T>(T newOp)
            where T : CoreOp
        {
            var name = Namer.NameOf(newOp);

            if (!Inners.TryGetValue(name, out var coreOp))
            {
                coreOp = newOp;
                coreOp.Id = currentId++;
                Inners.Add(coreOp);

                if (coreOp is RefOp refOp)
                {
                    References.Add(refOp);
                }
            }

            return (T)coreOp;
        }

        private CoreOp Create(Ast.Expression expression)
        {
            return Add(create());

            CoreOp create()
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

        protected virtual CoreOp Visit(Ast.Alternation alt)
        {
            Assert(alt.Expressions.Count >= 1);
            if (alt.Expressions.Count == 1)
            {
                return Create(alt.Expressions[0]);
            }
            else
            {
                return new AltOp(alt.Location, alt.Expressions.Select(e => Create(e)));
            }
        }

        private CoreOp Visit(Ast.Sequence seq)
        {
            Assert(seq.Expressions.Count >= 0);

            var transformed = seq.Expressions.Select(e => Create(e)).ToList();

            if (seq.Expressions.Count == 1)
            {
                return transformed[0];
            }
            else
            {
                return new SeqOp(seq.Location, transformed);
            }
        }

        private CoreOp Visit(Ast.ZeroOrMore zeroOrMore)
        {
            return new StarOp(zeroOrMore.Location, Create(zeroOrMore.Expression));
        }

        private CoreOp Visit(Ast.OneOrMore oneOrMore)
        {
            return new PlusOp(oneOrMore.Location, Create(oneOrMore.Expression));
        }

        private CoreOp Visit(Ast.ZeroOrOne zeroOrOne)
        {
            return new OptionalOp(zeroOrOne.Location, Create(zeroOrOne.Expression));
        }

        private CoreOp Visit(Ast.Reference reference)
        {
            var op = new RefOp(Ebnf, reference.Location, reference.Name);
            return op;
        }

        private static CoreOp Visit(Ast.Any any)
        {
            return new AnyOp(any.Location);
        }

        private static CoreOp Visit(Ast.Literal literal)
        {
            var cps = literal.Text.Codepoints().ToList();
            Assert(cps.Count >= 1);

            return new StringOp(literal.Location, literal.Text);
        }

        private CoreOp Visit(Ast.Range range)
        {
            var start = Create(range.Left);
            var end = Create(range.Right);

            if (start is StringOp s1 && end is StringOp s2)
            {
                var cp1 = s1.Text.Codepoints().Single();
                var cp2 = s2.Text.Codepoints().Single();
                return new RangeOp(range.Location, cp1, cp2);
            }
            throw new NotImplementedException();
        }

        private CoreOp Visit(Ast.Diff diff)
        {
            var first = Create(diff.Left);
            var second = Create(diff.Right);

            return new SetOp(diff.Location, first, second);
        }

        private CoreOp Visit(Ast.Token token)
        {
            return new TokenOp(token.Location, Create(token.Expression));
        }

        public override string ToString()
        {
            return $"ebnf-creator({Ebnf.Name})";
        }
    }
}

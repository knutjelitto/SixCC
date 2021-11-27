namespace Six.Gen.Ebnf
{
    public class EbnfTransformer
    {
        public EbnfTransformer(Ast.Grammar grammar)
        {
            Grammar = grammar;
            Ebnf = new EbnfGrammar(grammar.Name);
        }


        public Ast.Grammar Grammar { get; }
        public EbnfGrammar Ebnf { get; }

        public EbnfGrammar Transform()
        {
            foreach (var symbol in Grammar.Symbols)
            {
                var name = symbol.Name;
                var transformed = Transform(symbol.Expression);

                Ebnf.Add(new Rule(name, transformed));
            }

            return Ebnf;
        }

        private Operator Transform(Ast.Expression expression)
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
                case Ast.Difference expr:
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
                return new EmptyOp();
            }
            else if (seq.Expressions.Count == 1)
            {
                return Transform(seq.Expressions[0]);
            }
            else
            {
                var inOps = seq.Expressions.Select(e => Transform(e)).ToList();
                var outOps = new List<Operator>();
                outOps.Add(inOps[0]);
                var o = 0;
                for (var i = 1; i < inOps.Count; i++)
                {
                    if (TrySimplifySeq(outOps[o], inOps[i], out var outOp) && outOp is not null)
                    {
                        outOps[o] = outOp;
                    }
                    else
                    {
                        outOps.Add(inOps[i]);
                        o += 1;
                    }
                }
                
                if (outOps.Count == 1)
                {
                    return outOps[0];
                }


                return new SeqOp(outOps);
            }
        }

        private Operator Visit(Ast.ZeroOrMore zeroOrMore)
        {
            return new ZeroOrMoreOp(Transform(zeroOrMore.Expression));
        }

        private Operator Visit(Ast.OneOrMore oneOrMore)
        {
            return new OneOrMoreOp(Transform(oneOrMore.Expression));
        }

        private Operator Visit(Ast.ZeroOrOne zeroOrOne)
        {
            return new ZeroOrOneOp(Transform(zeroOrOne.Expression));
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
                return new CodepointOp(cps[0]);
            }
            return new StringOp(literal.Text);
        }

        private Operator Visit(Ast.Difference difference)
        {
            throw new NotImplementedException();
        }

        private Operator Visit(Ast.Range range)
        {
            var start = Transform(range.One);
            var end = Transform(range.Two);

            if (start is CodepointOp cp1 && end is CodepointOp cp2)
            {
                return new RangeOp(cp1.Codepoint, cp2.Codepoint);
            }

            Assert(start is CodepointOp && end is CodepointOp);
            throw new NotImplementedException();
        }

        private Operator Visit(Ast.Compact compact)
        {
            return new VerbatimOp(Transform(compact.Expression));
        }

        private bool TrySimplifySeq(Operator op1, Operator op2, out Operator? simpler)
        {
            switch (op1)
            {
                case CodepointOp cp1:
                    switch (op2)
                    {
                        case CodepointOp cp2:
                            simpler = new StringOp(cp1.Codepoint + cp2.Codepoint);
                            return true;
                        case StringOp s2:
                            simpler = new StringOp(cp1.Codepoint + s2.Text);
                            return true;
                    }
                    break;
            }
            simpler = null;
            return false;
        }
    }
}

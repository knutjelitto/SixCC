using Six.Core.Errors;

namespace Six.Gen.Ebnf
{
    internal class SetTransformer : EbnfWalker
    {
        public SetTransformer(EbnfGrammar grammar)
        {
            Grammar = grammar;
        }

        private EbnfGrammar Grammar { get; }
        public EbnfGrammar Transform()
        {
            Walk(Grammar);

            return Grammar;
        }

        protected override void Visit(SetOp diff)
        {
            var transformer = new Transformer(Grammar, diff, Error);
            var set = transformer.Transform();
            diff.Set(set);

            DiagnosticException Error(CoreOp op)
            {
                var namer = new NameWalker();
                var diagnostic1 = new SemanticError(op.Location, $"can't convert {namer.NameOf(op)} to codepoint set");
                var diagnostic2 = new SemanticError(diff.Location, $"can't convert {namer.NameOf(diff)} to codepoint set");
                return new DiagnosticException(diagnostic1, diagnostic2);
            }
        }

        private class Transformer : EbnfTransformer<Integers>
        {
            public Transformer(EbnfGrammar grammar, SetOp diff, Func<CoreOp, DiagnosticException> error)
            {
                Grammar = grammar;
                Diff = diff;
                Error = error;
            }

            public EbnfGrammar Grammar { get; }
            public SetOp Diff { get; }
            public Func<CoreOp, DiagnosticException> Error { get; }

            public Integers Transform()
            {
                return Transform(Diff);
            }

            protected override Integers Visit(SetOp op)
            {
                var left = Transform(op.Arguments[0]);
                var right = Transform(op.Arguments[1]);

                if (left != null && right != null)
                {
                    var set = Integers.From(left).Substract(right);
                    return set;
                }

                throw Error(op);
            }

            protected override Integers Visit(AltOp op)
            {
                var set = Integers.Empty;
                foreach (var arg in op.Arguments.Select(alt => Transform(alt)))
                {
                    if (arg == null)
                    {
                        throw Error(op);
                    }
                    set = set.UnionWith(arg);
                }

                return set;
            }

            protected override Integers Visit(SeqOp op)
            {
                throw Error(op);
            }

            protected override Integers Visit(OptionalOp op)
            {
                throw Error(op);
            }

            protected override Integers Visit(PlusOp op)
            {
                throw Error(op);
            }

            protected override Integers Visit(StarOp op)
            {
                throw Error(op);
            }

            protected override Integers Visit(StartRuleOp op)
            {
                throw Error(op);
            }

            protected override Integers Visit(RefOp op)
            {
                return Transform(op.Rule);
            }

            protected override Integers Visit(RuleOp op)
            {
                return Transform(op.Argument);
            }

            protected override Integers Visit(AnyOp op)
            {
                return Integers.Any;
            }

            protected override Integers Visit(RangeOp op)
            {
                return Integers.From((int)op.Codepoint1, (int)op.Codepoint2);
            }

            protected override Integers Visit(StringOp op)
            {
                var cps = new CpString(op.Text);
                if (cps.Count == 1)
                {
                    var set = Integers.From((int)cps[0]);
                    return set;
                }

                throw Error(op);
            }
        }
    }
}

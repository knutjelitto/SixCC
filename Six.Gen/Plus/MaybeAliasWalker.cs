﻿namespace Six.Gen.Ebnf
{
    internal class MaybeAliasWalker : EbnfPredicator<AltOp>
    {
        public MaybeAliasWalker(EbnfGrammar grammar)
            : base(op => op.IsAlias, (op, value)=> op.IsAlias = value)
        {
            Grammar = grammar;
        }

        public EbnfGrammar Grammar { get; }

        public EbnfGrammar Walk()
        {
            Walk(Grammar);

            return Grammar;
        }

        protected override void Visit(AltOp op)
        {
            Set(op, op.Arguments.All(a => a is RefOp));
        }
    }
}

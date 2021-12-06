namespace Six.Gen.Ebnf
{
    internal class RuleReached : Predicator
    {
        public RuleReached()
            : base(op => op.RuleReached, (op, value) => op.RuleReached = value)
        {
        }

        public void Reach(EbnfGrammar grammar)
        {
            Walk(grammar);
        }

        protected override void Walk(EbnfGrammar grammar)
        {
            Walk(grammar.WhitespaceRule);
            Walk(grammar.StartRule);
        }

        protected override void Visit(AltOp op)
        {
            Set(op, true);
            base.Visit(op);
        }

        protected override void Visit(AnyOp op)
        {
            Set(op, true);
            base.Visit(op);
        }

        protected override void Visit(CharacterOp op)
        {
            Set(op, true);
            base.Visit(op);
        }

        protected override void Visit(DiffOp op)
        {
            Set(op, true);
            base.Visit(op);
        }

        protected override void Visit(OptionalOp op)
        {
            Set(op, true);
            base.Visit(op);
        }

        protected override void Visit(PlusOp op)
        {
            Set(op, true);
            base.Visit(op);
        }

        protected override void Visit(RangeOp op)
        {
            Set(op, true);
            base.Visit(op);
        }

        protected override void Visit(RefOp op)
        {
            if (!op.RuleReached)
            {
                Set(op, true);
                Walk(op.Rule);
            }
        }

        protected override void Visit(RuleOp op)
        {
            Set(op, true);
            base.Visit(op);
        }

        protected override void Visit(SeqOp op)
        {
            Set(op, true);
            base.Visit(op);
        }

        protected override void Visit(StarOp op)
        {
            Set(op, true);
            base.Visit(op);
        }

        protected override void Visit(StringOp op)
        {
            Set(op, true);
            base.Visit(op);
        }

        protected override void Visit(TokenOp op)
        {
            Set(op, true);
            // stop here
        }
    }
}

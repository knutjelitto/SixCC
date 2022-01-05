namespace Six.Gen.Ebnf
{
    internal class ReachWalker : EbnfPredicator
    {
        public ReachWalker()
            : base(op => op.IsReached, (op, value) => op.IsReached = value)
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
            Walk(grammar.KeywordsRule);
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

        protected override void Visit(SetOp op)
        {
            Set(op, true);
            base.Visit(op);
        }

        protected override void Visit(NotOp op)
        {
            Set(op, true);
            base.Visit(op);
        }

        protected override void Visit(DropOp op)
        {
            Set(op, true);
            base.Visit(op);
        }

        protected override void Visit(LiftOp op)
        {
            Set(op, true);
            base.Visit(op);
        }

        protected override void Visit(EofOp op)
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
            if (!op.IsReached)
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

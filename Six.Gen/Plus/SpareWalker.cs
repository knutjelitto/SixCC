namespace Six.Gen.Ebnf
{
    public class SpareWalker : EbnfWalker
    {
        public SpareWalker(EbnfGrammar grammar)
        {
            Grammar = grammar;
        }

        public EbnfGrammar Grammar { get; }

        public bool Changed { get; set; }

        public EbnfGrammar Walk()
        {
            Changed = true;
            while (Changed)
            {
                Changed = false;
                foreach (var op in Grammar.Operators)
                {
                    Walk(op);
                }
            }

            return Grammar;
        }

        private void SetIsSpare(StringOp str)
        {
            if (!str.IsSpare)
            {
                Changed = true;
                str.IsSpare = true;
            }
        }

        protected override void Visit(SeqOp op)
        {
            Assert(op.Arguments.Count >= 2 || op.Arguments.Count == 0);

            foreach (var arg in op.Arguments)
            {
                if (arg is StringOp str)
                {
                    SetIsSpare(str);
                }
            }

            base.Visit(op);
        }
    }
}

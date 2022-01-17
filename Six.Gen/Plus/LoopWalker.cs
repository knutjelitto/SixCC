namespace Six.Gen.Ebnf
{
    internal class LoopWalker : EbnfPredicator
    {
        public LoopWalker(EbnfGrammar grammar)
            : base(op => op.IsLoop, (op, value)=> op.IsLoop = value)
        {
            Grammar = grammar;
        }

        public EbnfGrammar Grammar { get; }

        public EbnfGrammar Walk()
        {
            Walk(Grammar);

            return Grammar;
        }

        protected override void Visit(SeqOp seq)
        {
            base.Visit(seq);

            if (seq.Arguments.Count == 2)
            {
                var first = seq.Arguments[0];

                if (seq.Arguments[1] is StarOp star)
                {
                    if (star.Argument is SeqOp starSeq)
                    {
                        if (starSeq.Arguments.Count == 2)
                        {
                            var second = starSeq.Arguments[1];

                            if (first.Id == second.Id)
                            {
                                Set(seq, true);
                            }
                        }
                    }
                }
                else if (seq.Arguments[1] is PlusOp plus)
                {
                    if (plus.Argument is SeqOp plusSeq)
                    {
                        if (plusSeq.Arguments.Count == 2)
                        {
                            var second = plusSeq.Arguments[1];

                            if (first.Id == second.Id)
                            {
                                Set(seq, true);
                            }
                        }
                    }
                }
            }
        }
    }
}

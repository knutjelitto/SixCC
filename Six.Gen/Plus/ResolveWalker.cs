namespace Six.Gen.Ebnf
{
    public class ResolveWalker : EbnfWalker
    {
        public ResolveWalker(EbnfGrammar grammar)
        {
            Grammar = grammar;
        }

        public EbnfGrammar Grammar { get; }

        public EbnfGrammar Walk()
        {
            return Grammar;
        }

        protected override void Visit(RefOp op)
        {
            op.Patch(Grammar.Operators[op.Name]);
        }
    }
}

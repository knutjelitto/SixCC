namespace Six.Gen.Ebnf
{
    public class TypeWalker : EbnfWalker
    {
        private readonly SortedSet<string>[] types;

        public TypeWalker(EbnfGrammar grammar)
        {
            Grammar = grammar;
            types = new SortedSet<string>[grammar.Operators.Count];
            for (var i = 0; i < grammar.Operators.Count; i++)
            {
                types[i] = new SortedSet<string>();
            }
        }

        public EbnfGrammar Grammar { get; }

        public bool Changed { get; set; }

        public EbnfGrammar Walk()
        {
            Changed = true;
            while (Changed)
            {
                Changed = false;
                foreach (var rule in Grammar.Rules.OfType<PlainRuleOp>())
                {
                    Walk(rule);
                }
            }

            return Grammar;
        }

        private void Update(CoreOp op, string type)
        {
            if (types[op.Id].Add(type))
            {
                Changed = true;
            }
        }

        protected override void Visit(RuleOp op)
        {
            if (op.Argument is AltOp alt && alt.Arguments.All(a => a is RefOp))
            {
                Assert(true);
            }
            base.Visit(op);
        }
    }
}

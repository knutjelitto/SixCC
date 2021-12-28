namespace Six.Gen.Ebnf
{
    internal class InstanceWalker
    {
        public InstanceWalker(EbnfGrammar grammar)
        {
            Grammar = grammar;
        }

        public EbnfGrammar Walk()
        {
            foreach (var op in Grammar.Operators)
            {
                for (var offset = 0; offset < op.Arguments.Count; offset++)
                {
                    var arg = op.Arguments[offset];
                    if (arg is RefOp refOp)
                    {
                        arg = refOp.Rule;
                    }
                    arg.Instances.Add(new Instance(op, offset));
                }
            }

            return Grammar;
        }

        public EbnfGrammar Grammar { get; }
    }
}

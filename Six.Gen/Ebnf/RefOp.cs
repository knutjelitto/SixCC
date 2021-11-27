namespace Six.Gen.Ebnf
{
    public class RefOp : Operator
    {
        public RefOp(EbnfGrammar grammar, string name)
        {
            Grammar = grammar;
            Name = name;
        }

        public EbnfGrammar Grammar { get; }
        public string Name { get; }

        protected override string DumpHead => $"⤇{Name}";
    }
}

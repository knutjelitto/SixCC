namespace Six.Gen.Ebnf
{
    public sealed class RefOp : Operator
    {
        public RefOp(EbnfGrammar grammar, ILocation location, string name)
            : base(location)
        {
            Grammar = grammar;
            Name = name;
        }

        public EbnfGrammar Grammar { get; }
        public string Name { get; }

        public RuleOp Rule => (RuleOp)Grammar.Inner[Name];
        protected override string DumpHead => $"⤇{Name}";
    }
}

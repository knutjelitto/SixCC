namespace Six.Gen.Ebnf
{
    public sealed class RefOp : Operator
    {
        public RefOp(EbnfGrammar grammar, ILocation location, string name)
        {
            Grammar = grammar;
            Name = name;
            Set(location);
        }

        public EbnfGrammar Grammar { get; }
        public string Name { get; }

        public RuleOp Rule => (RuleOp)Grammar.Inner[Name];
        protected override string DumpHead => $"⤇{Name}";
    }
}

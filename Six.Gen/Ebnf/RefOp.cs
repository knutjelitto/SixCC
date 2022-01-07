namespace Six.Gen.Ebnf
{
    public sealed class RefOp : CoreOp
    {
        public RefOp(EbnfGrammar grammar, ILocation location, string name)
            : base(location)
        {
            Grammar = grammar;
            Name = name;
        }

        public EbnfGrammar Grammar { get; }
        public string Name { get; }

        public RuleOp Rule => (RuleOp)Grammar.Operators[Name];
        protected override string DumpHead => $"⤇{Name}";
        public override void Dump(Writer writer)
        {
#if true
            base.Dump(writer);
#else
            if (Grammar.Operators.Contains(Name))
            {
                writer.WriteLine($"{DumpHead}{Rule.Attributes}");
            }
            else
            {
                base.Dump(writer);
            }
#endif
        }

    }
}

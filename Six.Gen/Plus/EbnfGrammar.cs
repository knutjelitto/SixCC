namespace Six.Gen.Ebnf
{
    public class EbnfGrammar
    {
        private readonly OpNamer namer;
        public EbnfGrammar(string name)
        {
            Name = name;
            namer = new OpNamer();
            Inner = new UniqueList<string, Operator>(op => namer.NameOf(op));
        }

        public void Add(Operator inner)
        {
            Inner.Add(inner);
        }

        public string Name { get; set; }
        public UniqueList<string, Operator> Inner { get; }
        public IEnumerable<RuleOp> Rules => Inner.OfType<RuleOp>();
        public IEnumerable<Operator> Others => Inner.Where(op => op is not RuleOp);
        public RuleOp StartRule => Rules.Where(op => op.Name.ToLowerInvariant() == "%start").First();
        public RuleOp WhitespaceRule => Rules.Where(op => op.Name.ToLowerInvariant() == "%whitespace").First();
    }
}

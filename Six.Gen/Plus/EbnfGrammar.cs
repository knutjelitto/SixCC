namespace Six.Gen.Ebnf
{
    public class EbnfGrammar
    {
        private readonly NameWalker namer;
        public EbnfGrammar(string name)
        {
            Name = name;
            namer = new NameWalker();
            Operators = new UniqueList<string, CoreOp>(op => namer.NameOf(op));
        }

        public void Add(CoreOp inner)
        {
            Operators.Add(inner);
        }

        public void Patch(List<CoreOp> finalList)
        {
            Operators.Clear();
            Operators.AddRange(finalList);
        }

        public string Name { get; set; }
        public UniqueList<string, CoreOp> Operators { get; private set; }
        public IEnumerable<RuleOp> Rules => Operators.OfType<RuleOp>();
        public IEnumerable<CoreOp> Others => Operators.Where(op => op is not RuleOp);
        public RuleOp StartRule => Rules.Where(op => op.Name.ToLowerInvariant() == "%start").First();
        public RuleOp WhitespaceRule => Rules.Where(op => op.Name.ToLowerInvariant() == "%whitespace").First();
    }
}

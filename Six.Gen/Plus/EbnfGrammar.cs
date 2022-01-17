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
            Keywords = new List<string>();
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

        public void SetKeywords(IEnumerable<string> keywords)
        {
            Keywords.Clear();
            Keywords.AddRange(keywords);
        }

        public string Name { get; set; }
        public string Namespace { get; set; } = "Generated";
        public UniqueList<string, CoreOp> Operators { get; private set; }
        public List<string> Keywords { get; }
        public IEnumerable<RuleOp> Rules => Operators.OfType<RuleOp>();
        public IEnumerable<RuleOp> CoreRules => Rules.Where(r => !r.IsSpecial);
        public IEnumerable<CoreOp> Others => Operators.Where(op => op is not RuleOp);
        public RuleOp StartRule => Rules.Where(op => op.Name.ToLowerInvariant() == Ast.AstGrammar.TheStart).First();
        public RuleOp WhitespaceRule => Rules.Where(op => op.Name.ToLowerInvariant() == Ast.AstGrammar.TheWhitespace).First();
        public RuleOp KeywordsRule => Rules.Where(op => op.Name.ToLowerInvariant() == Ast.AstGrammar.TheKeywords).First();
    }
}

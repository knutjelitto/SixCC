namespace Six.Ast
{
    public class AstGrammar
    {
        public const string TheStart = "%start";
        public const string TheWhitespace = "%whitespace";
        public const string TheKeywords = "%keywords";

        public AstGrammar(string name)
        {
            Name = name;
            Symbols = new List<Symbol>();
        }

        public Symbol? StartRule => Symbols.Where(op => op.Name.ToLowerInvariant() == TheStart).FirstOrDefault();
        public Symbol? WhitespaceRule => Symbols.Where(op => op.Name.ToLowerInvariant() == TheWhitespace).FirstOrDefault();
        public Symbol? KeywordsRule => Symbols.Where(op => op.Name.ToLowerInvariant() == TheKeywords).FirstOrDefault();
        public string Name { get; set; }
        public List<Symbol> Symbols { get; }

        public void Add(Symbol symbol)
        {
            Symbols.Add(symbol);
        }

        public override string ToString()
        {
            return $"ast('{Name}', #{Symbols.Count})";
        }
    }
}

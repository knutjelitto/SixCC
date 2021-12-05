namespace Six.Ast
{
    public class AstGrammar
    {
        public AstGrammar(string name)
        {
            Name = name;
            Symbols = new List<Symbol>();
        }

        public Symbol StartRule => Symbols.Where(op => op.Name.ToLowerInvariant() == "%start").FirstOrDefault();
        public Symbol WhitespaceRule => Symbols.Where(op => op.Name.ToLowerInvariant() == "%whitespace").FirstOrDefault();
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

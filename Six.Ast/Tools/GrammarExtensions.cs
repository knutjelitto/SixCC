namespace Six.Ast
{
    public static class GrammarExtensions
    {
        private const string top = "bot";

        public static IEnumerable<Symbol> Nonterminals(this Grammar grammar)
        {
            return grammar.Symbols.Where(sym => sym.IsNonterminal);
        }

        public static IEnumerable<Symbol> Terminals(this Grammar grammar)
        {
            return grammar.Symbols.Where(sym => sym.IsTerminal);
        }

        public static IEnumerable<Symbol> Fragments(this Grammar grammar)
        {
            return grammar.Symbols.Where(sym => sym.IsFragment);
        }

        public static string File(string filename)
        {
            return Path.Combine(Temp.TempPath(top), filename);
        }

        public static Writer Writer(string filename)
        {
            return new Writer(File(filename));
        }

        public static void DumpTree(this Grammar grammar, string filename)
        {
            using (var writer = new Writer(File(filename)))
            {
                grammar.DumpTree(writer);
            }
        }

        public static void DumpTree(this Grammar grammar, Writer writer)
        {
            new TreeDumper(writer).Walk(grammar);
        }
    }
}

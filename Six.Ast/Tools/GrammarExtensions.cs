namespace Six.Ast
{
    public static class GrammarExtensions
    {
        private const string top = "bot";

        public static string File(string filename)
        {
            return Path.Combine(Temp.TempPath(top), filename);
        }

        public static Writer Writer(this string filename)
        {
            return new Writer(File(filename));
        }

        public static void DumpTree(this AstGrammar grammar, string filename)
        {
            using (var writer = new Writer(File(filename)))
            {
                grammar.DumpTree(writer);
            }
        }

        public static void DumpTree(this AstGrammar grammar, Writer writer)
        {
            new TreeDumper(writer).Walk(grammar);
        }
    }
}

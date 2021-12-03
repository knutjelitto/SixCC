using Six.Ast;

namespace Six.Input
{
    public static class Builder
    {
        public static AstGrammar Build(string name, string content)
        {
            var source = new Source(name, content);
            var lexer = new Lexer(source);
            var tokens = new Tokens(lexer);
            var parser = new Parser(tokens);
            var grammar = parser.Parse();
            grammar.DumpTree($"{grammar.Name}-tree.txt");

            return grammar;
        }
    }
}

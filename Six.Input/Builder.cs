using Six.Ast;
using Six.Core;

namespace Six.Input
{
    public static class Builder
    {
        public static AstGrammar Build(string name, string content)
        {
            var source = Source.FromString(name, content);
            var lexer = new Lexer(source);
            var tokens = new Tokens(lexer);
            var parser = new Parser(tokens);
            var grammar = parser.Parse();

            return grammar;
        }
    }
}

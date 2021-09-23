using SixCC.Runtime.Errors;
using SixCC.Runtime.Lexing;
using SixCC.Runtime.Parsing;
using SixCC.Runtime.Sources;
using SixCC.Runtime.Structures;

namespace SixCC.Runtime.Concretes
{
    public class LinguContext : IContext
    {
        public LinguContext(IEnumerable<ISymbol> symbols, IEnumerable<IProduction> productions, IParseTable table, IDfaSet dfas)
        {
            Symbols = symbols.ToArray();
            Productions = productions.ToArray();
            Table = table;
            Dfas = dfas;
            Errors = new ErrorHandler(this);
        }

        public IReadOnlyList<ISymbol> Symbols { get; }
        public IReadOnlyList<IProduction> Productions { get; }
        public IParseTable Table { get; }
        public IDfaSet Dfas { get; }
        public IErrorHandler Errors { get; }

        public INonterminalToken? Try(Source source)
        {
            try
            {
                var lexer = new Lexer(this, source);
                var parser = new Parser(this, lexer);

                var tree = parser.Parse();

                return tree;
            }
            catch (ParserException parserException)
            {
                Console.WriteLine(parserException.Message);
                return null;
            }
        }
    }
}

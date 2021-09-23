using SixCC.Runtime.Lexing;
using SixCC.Runtime.Parsing;
using SixCC.Runtime.Structures;

namespace SixCC.Runtime.Errors
{
    public class ErrorHandler : IErrorHandler
    {
        public ErrorHandler(IContext context)
        {
            Context = context;
        }

        public IContext Context { get; }

        public static string GetLocation(ISource source, int offset)
        {
            (int lineNo, int colNo) = source.GetLineAndColumn(offset);

            return $"{source.Name}:{lineNo}:{colNo}";
        }

        public string GetLocation(ILocation location)
        {
            var (lineNo, colNo) = location.Source.GetLineAndColumn(location.Offset);

            return $"{location.Source.Name}:{lineNo}:{colNo}";
        }

        public string GetExpectedMessage(ILocation location, IReadOnlyList<ISymbol> symbols)
        {
            return $"{GetLocation(location)}: expected one of {string.Join(", ", symbols)}";
        }

        public IEnumerable<ISymbol> GetSymbols(Dfa dfa)
        {
            return dfa.GetPayloads().Select(symId => Context.Symbols[symId]);
        }

        public IEnumerable<ISymbol> GetSymbols(int stateNo)
        {
            foreach (var terminalItem in Context.Table[stateNo].Terminals)
            {
                if (terminalItem.Action == ParseAction.Shift)
                {
                    yield return Context.Symbols[terminalItem.Number];
                }
            }
        }
    }
}

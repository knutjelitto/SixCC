namespace SixCC.Runtime.Structures
{
    public interface IErrorHandler
    {
        string GetExpectedMessage(ILocation location, IReadOnlyList<ISymbol> symbols);
        IEnumerable<ISymbol> GetSymbols(Lexing.Dfa dfa);
        IEnumerable<ISymbol> GetSymbols(int stateId);
    }
}

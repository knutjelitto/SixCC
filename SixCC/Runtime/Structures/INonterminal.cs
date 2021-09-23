namespace SixCC.Runtime.Structures
{
    public interface INonterminal : ISymbol
    {
        RepeatKind Repeat { get; }
    }
}

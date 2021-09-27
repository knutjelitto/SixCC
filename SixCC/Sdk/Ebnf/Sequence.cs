using SixCC.Runtime.Structures;
using SixCC.Sdk.Automata;

namespace SixCC.Sdk.Ebnf
{
    public class Sequence : Symbol
    {
        public Sequence(ILocation location, IEnumerable<Symbol> symbols)
            : base(location)
        {
            Symbols = symbols.ToList();
            Debug.Assert(Symbols.Count >= 2);
        }

        public List<Symbol> Symbols { get; }

        public override NFA GetTerminalNfa(Factory builder)
        {
            var nfas = Symbols.Where(s => s is not Epsilon).Select(s => s.GetTerminalNfa(builder)).ToList();
            if (nfas.Count == 0)
            {
                return builder.Epsilon();
            }
            return NFA.AndThen(nfas);
        }

        public override NFA GetNonterminalNfa(Factory builder)
        {
            var nfas = Symbols.Where(s => s is not Epsilon).Select(s => s.GetNonterminalNfa(builder)).ToList();
            if (nfas.Count == 0)
            {
                return builder.Epsilon();
            }
            return NFA.AndThen(nfas);
        }

        public override string ToString()
        {
            if (Symbols.Count == 1)
            {
                return $"{Symbols[0]}";
            }
            return $"({string.Join(" ", Symbols)})";
        }
    }
}

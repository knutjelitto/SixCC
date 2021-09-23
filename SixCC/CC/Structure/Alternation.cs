using SixCC.Runtime.Structures;
using SixCC.Sdk.Automata;

namespace SixCC.CC.Structure
{
    internal class Alternation : Symbol
    {
        public Alternation(ILocation location, IEnumerable<Symbol> sequences)
            : base(location)
        {
            Sequences = sequences.ToList();
        }

        public List<Symbol> Sequences { get; }

        public override NFA GetTerminalNfa(Factory builder)
        {
            return NFA.OrElse(Sequences.Select(s => s.GetTerminalNfa(builder)));
        }

        public override NFA GetNonterminalNfa(Factory builder)
        {
            return NFA.OrElse(Sequences.Select(s => s.GetNonterminalNfa(builder)));
        }

        public override string ToString()
        {
            if (Sequences.Count == 1)
            {
                return $"{Sequences[0]}";
            }
            return $"({string.Join(" | ", Sequences)})";
        }
    }
}

using SixCC.Runtime.Structures;

namespace SixCC.Runtime.Concretes
{
    public class NonterminalSymbol : Symbol, INonterminal
    {
        public NonterminalSymbol(int id, string name, bool visible, RepeatKind repeat)
            : base(id, name, visible)
        {
            Repeat = repeat;
        }

        public RepeatKind Repeat { get; }
    }
}

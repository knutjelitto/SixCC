using SixCC.Sdk.Commons;

namespace SixCC.Sdk.Grammars
{
    public class NonterminalList : UniqueList<Symbol, Nonterminal>
    {
        public NonterminalList()
            : base(nonterminal => nonterminal, new Symbol.NamesEquals())
        {
        }
    }
}

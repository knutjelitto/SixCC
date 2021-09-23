using SixCC.Sdk.Commons;

namespace SixCC.Sdk.Grammars
{
    public class OptionList : UniqueList<Symbol, Option>
    {
        public OptionList()
            : base(option => option, new Symbol.NamesEquals())
        {
        }
    }
}

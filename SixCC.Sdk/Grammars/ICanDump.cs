using SixCC.Sdk.Output;

namespace SixCC.Sdk.Grammars
{
    public interface ICanDump
    {
        void Dump(IndentWriter writer);
    }
}

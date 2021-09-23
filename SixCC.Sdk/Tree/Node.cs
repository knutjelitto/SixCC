using SixCC.Sdk.Grammars;
using SixCC.Sdk.Output;

namespace SixCC.Sdk.Tree
{
    public abstract class Node : ICanDump
    {
        public virtual void Dump(IndentWriter writer, bool top)
        {
            writer.WriteLine(GetType().Name);
        }

        public abstract void Dump(IndentWriter writer);
    }
}

using SixCC.Sdk.Automata;
using SixCC.Sdk.Output;

namespace SixCC.Sdk.Tree
{
    public sealed class Any : Atom
    {
        public override FA GetFA() => FA.Any();

        public override string ToString()
        {
            return ".";
        }

        public override void Dump(IndentWriter output)
        {
            output.Write(this.ToString());
        }
    }
}

using SixCC.Sdk.Automata;
using SixCC.Sdk.Output;

namespace SixCC.Sdk.Tree
{
    public class Eof : Atom
    {
        public Eof(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public override void Dump(IndentWriter writer)
        {
            writer.Write(Name);
        }

        public override FA GetFA()
        {
            return FA.Eof();
        }
    }
}

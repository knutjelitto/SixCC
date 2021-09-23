using SixCC.Sdk.Automata;
using SixCC.Sdk.Output;

namespace SixCC.Sdk.Tree
{
    public class Nope : Atom
    {
        public Nope()
        {
            var state = new State();
            FA = FA.From(state, state);
        }

        public string Name { get; } = string.Empty;

        private readonly FA FA;

        public override void Dump(IndentWriter writer)
        {
            writer.Write(Name);
        }

        public override FA GetFA() => FA;
    }
}

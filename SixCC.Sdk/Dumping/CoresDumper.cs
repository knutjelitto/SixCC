using SixCC.Sdk.Grammars;
using SixCC.Sdk.Output;

namespace SixCC.Sdk.Dumping
{
    public class CoresDumper
    {
        public CoresDumper(Grammar grammar)
        {
            Grammar = grammar;
        }

        public Grammar Grammar { get; }

        public void Dump(IWriter writer)
        {
            foreach (var core in Grammar.CoreFactory)
            {
                writer.WriteLine($"{core}");
            }
        }

    }
}

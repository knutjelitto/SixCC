using Six.Core;
using System.IO;

namespace Six.Ast
{
    public static class GrammarExtensions
    {
        private const string top = "bot";

        private static string File(string filename)
        {
            return Path.Combine(Temp.TempPath(top), filename);
        }

        public static void Dump(this Grammar grammar, string filename)
        {
            using (var writer = new Writer(File(filename)))
            {
                new SixgDumper(writer).Walk(grammar);
            }
        }
    }
}

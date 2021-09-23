using SixCC.Sdk.Commons;
using SixCC.Sdk.Output;
using SixCC.Runtime.Structures;

namespace SixCC.Sdk.Dumping
{
    public class TreeDumper
    {
        public TreeDumper(FileRef file)
        {
            File = file;
        }

        public FileRef File { get; }

        public void Dump(INonterminalToken token)
        {
            var iwriter = new IndentWriter("  ");
            Dump(iwriter, token);
            iwriter.Persist(File);
        }

        private void Dump(IWriter writer, IToken token)
        {
            writer.Write($"{token.Symbol.Name}");
            if (token is INonterminalToken nonleaf)
            {
                writer.WriteLine();
                writer.Indent(() =>
                {
                    foreach (var child in nonleaf.Children)
                    {
                        Dump(writer, child);
                    }
                });
            }
            else
            {
                var terminalToken = (ITerminalToken)token;

                writer.WriteLine($" <{terminalToken.Value}>");
            }
        }
    }
}

using Six.Core;
using Six.Runtime.Sppf;

namespace Six.Runtime.Types
{
    public class REof : RNode
    {
        public REof(params Node[] nodes)
            : this((Terminal)nodes[0])
        {
            Assert(nodes.Length == 1);
        }

        public REof(Terminal terminal)
        {
            Start = terminal.Start.Offset;
            Core = terminal.Core.Offset;
            End = terminal.End.Offset;
            Source = terminal.Source;
        }

        public int Start { get; }
        public int Core { get; }
        public int End { get; }
        public Source Source { get; }

        public string Text()
        {
            return Source.GetText(Start, Core - Start).Esc();
        }

        public override string ToString()
        {
            return $"{CommonName()}{{{Text()}}}";
        }
    }
}

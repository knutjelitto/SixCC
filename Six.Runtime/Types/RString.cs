using Six.Core;
using Six.Runtime.Sppf;

namespace Six.Runtime.Types
{
    public class RString : RNode
    {
        public RString(params Node[] nodes)
            : this((Terminal)nodes[0])
        {
        }

        public RString(Terminal terminal)
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

        public string GetText()
        {
            var start = Math.Max(Core, Start);

            var text = Source.GetText(start, End - start);
            if (text.StartsWith("'") && text.EndsWith("'"))
            {
                return text;
            }

            return text.Esc();
        }

        public override string ToString()
        {
            return $"{CommonName()}{{{GetText()}}}";
        }
    }
}

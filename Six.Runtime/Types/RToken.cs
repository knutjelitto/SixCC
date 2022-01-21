using Six.Core;
using Six.Runtime.Sppf;

namespace Six.Runtime.Types
{
    public class RToken : RNode
    {
        public RToken(params Node[] nodes)
            : this((Terminal)nodes[0])
        {
        }

        public RToken(Terminal terminal)
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

        public string Text => Source.GetText(Core, End - Core);

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

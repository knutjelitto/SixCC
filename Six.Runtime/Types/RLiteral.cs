using Six.Core;
using Six.Runtime.Sppf;

namespace Six.Runtime.Types
{
    public class RLiteral : RNode, IRLocated
    {
        public RLiteral(params Node[] nodes)
            : this((Terminal)nodes[0])
        {
        }

        public RLiteral(Terminal terminal)
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

        public string Text => GetText();

        public string GetText()
        {
            var start = Math.Max(Core, Start);

            return Source.GetText(start, End - start);
        }

        public string GetEscapedText()
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
            return $"{CommonName()}{{{GetEscapedText()}}}";
        }
    }
}

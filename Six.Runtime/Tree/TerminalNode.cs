using Six.Core;
using Six.Runtime.Sppf;

namespace Six.Runtime.Tree
{
    public class TerminalNode : TreeNode
    {
        public TerminalNode(Terminal node)
            : base(node)
        {
        }

        Cursor Core => ((Terminal)Node).Core;

        public override string ToString()
        {
            var start = Core > Start ? Core : Start;

            var text = start.Source.GetText(start.Offset, End.Offset - start.Offset);
            var esc = text.Esc();
            if (text.StartsWith("'") && text.EndsWith("'"))
            {
                esc = text;
            }

            if (esc != Name)
            {
                return $"{Name}{{{esc}}}";
            }
            else
            {
                return $"{Name}";
            }
        }
    }
}

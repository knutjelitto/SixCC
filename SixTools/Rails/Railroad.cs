namespace SixTools.Rails
{
    public abstract class Railroad
    {
    }

    public class AnyRail : Railroad
    {
        public AnyRail()
        {
        }
    }

    public abstract class TextRail : Railroad
    {
        public TextRail(string text)
        {
            Text = text;
        }

        public string Text { get; }
    }

    public class TokenRail : TextRail
    {
        public TokenRail(string text)
            : base(text)
        {
        }
    }

    public class ReferenceRail : TextRail
    {
        public ReferenceRail(string text)
            : base(text)
        {
        }
    }

    public class LiteralRail : TextRail
    {
        public LiteralRail(string text)
            : base(text)
        {
        }
    }

    public class CommentRail : TextRail
    {
        public CommentRail(string text)
            : base(text)
        {
        }
    }

    public class ProseRail : TextRail
    {
        public ProseRail(string text)
            : base(text)
        {
        }
    }

    public class RangeRail : Railroad
    {
        public RangeRail(string start, string stop)
        {
            Start = start;
            Stop = stop;
        }

        public string Start { get; }
        public string Stop { get; }
    }

    public class NotRail : Railroad
    {
        public NotRail(Railroad node)
        {
            Node = node;
        }

        public Railroad Node { get; }
    }

    /// <summary>
    /// A plain railway section.
    /// </summary>
    public class PlainRail : Railroad
    {
    }

    /// <summary>
    /// A railway loop section.
    /// </summary>
    public class LoopRail : Railroad
    {
        public LoopRail(Railroad forward, Railroad backward, int min, int max)
        {
            Forward = forward;
            Backward = backward;
            Min = min;
            Max = max;
        }

        public Railroad Forward { get; }
        public Railroad Backward { get; }
        public bool Skip => Min == 0;
        public int Min { get; }
        public int Max { get; }
    }

    /// <summary>
    /// A sequence of railroad sections.
    /// </summary>
    public class SequenceRail : Railroad
    {
        public SequenceRail(IEnumerable<Railroad> nodes)
        {
            Nodes = nodes.ToList();
        }

        public List<Railroad> Nodes { get; }
    }

    /// <summary>
    /// A railroad junction point.
    /// </summary>
    public class ChoiceRail : Railroad
    {
        private readonly List<Railroad> nodes = new();

        public ChoiceRail(IEnumerable<Railroad> nodes)
        {
            foreach (var node in nodes)
            {
                if (node is ChoiceRail choices)
                {
                    this.nodes.AddRange(choices.Nodes);
                }
                else
                {
                    this.nodes.Add(node);
                }
            }

            Assert(Nodes.Count >= 2);

            Offset = Nodes[0] is PlainRail ? 1 : 0;
        }

        public ChoiceRail(params Railroad[] nodes)
            : this((IEnumerable<Railroad>)nodes)
        {
        }

        public IReadOnlyList<Railroad> Nodes => nodes;
        public int Offset { get; set; }
    }
}

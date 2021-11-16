using Six.Core;

namespace Six.Ast
{
    public class Set : Expression
    {
        public Set(Codepoint start, Codepoint end)
        {
            Points = Integers.From((int)start, (int)end);
        }

        public Set(int start, int end)
        {
            Points = Integers.From((int)start, (int)end);
        }

        public Set(Integers points)
        {
            Points = points;
        }

        public Integers Points { get; }

        public override bool IsAtomic => false;
        public override string ToName() => $"{Points.ToString(i => Escaper.Esc(new CpString(i)))}";
        public override string ToString() => $"{Points.ToString(i => Escaper.Esc(new CpString(i)))}";
    }
}

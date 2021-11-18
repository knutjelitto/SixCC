namespace Six.Ast
{
    public class Set : Expression
    {
        internal Set(ILocation? location, Codepoint start, Codepoint end)
            : this(location, Integers.From((int)start, (int)end))
        {
        }

        internal Set(ILocation? location, int start, int end)
            : this(location, Integers.From(start, end))

        {
        }

        internal Set(ILocation? location, Integers points)
            : base(location)
        {
            Points = points;
        }

        public Integers Points { get; }

        public override bool IsAtomic => false;
        public override string ToName() => $"{Points.ToString(i => Escaper.Esc(new CpString(i)))}";
        public override string ToString() => $"{Points.ToString(i => Escaper.Esc(new CpString(i)))}";
    }
}

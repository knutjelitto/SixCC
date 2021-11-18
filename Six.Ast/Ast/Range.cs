namespace Six.Ast
{
    public class Range : Expression
    {
        internal Range(ILocation? location, Expression start, Expression end)
            : base(location)
        {
            Start = start;
            End = end;
        }

        public Expression Start { get; }
        public Expression End { get; }

        public override bool IsAtomic => false;

        public override string ToName()
        {
            return $"({Start.ToName()}..{End.ToName()})";
        }
    }
}

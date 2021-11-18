namespace Six.Ast
{
    public class Difference : Expression
    {
        internal Difference(ILocation? location, Expression left, Expression right)
            : base(location)
        {
            Left = left;
            Right = right;
        }

        public Expression Left { get; }
        public Expression Right { get; }

        public override bool IsAtomic => true;
        public override string ToName() => $"({Left.ToName()}-{Right.ToName()})";
    }
}

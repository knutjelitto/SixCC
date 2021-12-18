namespace Six.Ast
{
    public class Diff : Expression, IWithTwo
    {
        internal Diff(ILocation location, Expression left, Expression right)
            : base(location)
        {
            Left = left;
            Right = right;
        }

        public Expression Left { get; set; }
        public Expression Right { get; set; }

        public override bool IsSimple => false;
    }
}

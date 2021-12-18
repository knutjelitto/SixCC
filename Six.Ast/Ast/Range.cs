namespace Six.Ast
{
    public class Range : Expression, IWithTwo
    {
        internal Range(ILocation location, Expression left, Expression right)
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

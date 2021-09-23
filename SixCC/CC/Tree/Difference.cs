namespace SixCC.CC.Tree
{
    internal class Difference : Family, Expression
    {
        public Difference(Expression left, Expression right)
            : base(left, right)
        {
            Left = left;
            Right = right;
        }

        public Expression Left { get; }
        public Expression Right { get; }
        public override string Head => "-";
    }
}

namespace SixCC.CC.Tree
{
    internal class Range : Family, Expression
    {
        public Range(Expression left, Expression right)
            : base(left, right)
        {
            Left = left;
            Right = right;
        }

        public Expression Left { get; }
        public Expression Right { get; }
        public override string Head => "..";
    }
}

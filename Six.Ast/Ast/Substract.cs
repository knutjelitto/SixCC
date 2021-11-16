namespace Six.Ast
{
    public class Substract : Expression
    {
        public Substract(Expression left, Expression right)
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

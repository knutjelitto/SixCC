namespace Six.Ast
{
    public class Diff : Expression, IWithTwo
    {
        internal Diff(ILocation location, Expression left, Expression right)
            : base(location)
        {
            One = left;
            Two = right;
        }

        public Expression One { get; set; }
        public Expression Two { get; set; }

        public override bool IsSimple => false;
    }
}

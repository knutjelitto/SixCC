namespace Six.Ast
{
    public class Difference : Expression, IWithTwo
    {
        internal Difference(ILocation location, Expression left, Expression right)
            : base(location)
        {
            One = left;
            Two = right;
        }

        public Expression One { get; set; }
        public Expression Two { get; set; }

        public override bool IsSimple => true;
    }
}

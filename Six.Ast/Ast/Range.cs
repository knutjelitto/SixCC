namespace Six.Ast
{
    public class Range : Expression, IWithTwo
    {
        internal Range(ILocation location, Expression start, Expression end)
            : base(location)
        {
            One = start;
            Two = end;
        }

        public Expression One { get; set; }
        public Expression Two { get; set; }

        public override bool IsSimple => false;
    }
}

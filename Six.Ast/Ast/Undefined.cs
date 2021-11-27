namespace Six.Ast
{
    public class Undefined : Expression
    {
        internal Undefined(ILocation location)
            : base(location)
        {
        }

        public override bool IsSimple => true;
    }
}

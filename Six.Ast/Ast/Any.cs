namespace Six.Ast
{
    public class Any : Expression
    {
        internal Any(ILocation location)
            : base(location)
        { 
        }

        public override bool IsSimple => true;
    }
}

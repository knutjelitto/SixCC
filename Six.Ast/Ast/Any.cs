namespace Six.Ast
{
    public class Any : Expression
    {
        internal Any(ILocation? location)
            : base(location)
        { 
        }

        public override bool IsAtomic => true;

        public override string ToName() => ".";
    }
}

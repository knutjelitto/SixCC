namespace Six.Ast
{
    public abstract class Base : Expression
    {
        protected Base(ILocation? location)
            : base(location)
        {
        }

        public override bool IsAtomic => true;
    }
}

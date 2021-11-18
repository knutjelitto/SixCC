namespace Six.Ast
{
    public class Undefined : Expression
    {
        internal Undefined(ILocation? location)
            : base(location)
        {
        }

        public override bool IsAtomic => true;

        public override string ToName() => $"-<undefined>-";
    }
}

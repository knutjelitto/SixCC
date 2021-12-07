namespace Six.Gen.Ebnf
{
    public sealed class AnyOp : CoreOp
    {
        public AnyOp(ILocation location)
            : base(location)
        {
        }

        protected override string DumpHead => "any";
    }
}

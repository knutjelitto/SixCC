namespace Six.Gen.Ebnf
{
    public sealed class PlusOp : CoreOp
    {
        public PlusOp(ILocation location, CoreOp argument)
            : base(location, argument)
        {
        }

        protected override string DumpHead => "+plus+";
    }
}

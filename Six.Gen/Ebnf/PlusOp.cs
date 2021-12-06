namespace Six.Gen.Ebnf
{
    public sealed class PlusOp : Operator
    {
        public PlusOp(ILocation location, Operator argument)
            : base(location, argument)
        {
        }

        protected override string DumpHead => "+plus+";
    }
}

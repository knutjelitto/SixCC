namespace Six.Gen.Ebnf
{
    public sealed class StarOp : Operator
    {
        public StarOp(ILocation location, Operator argument)
            : base(location, argument)
        {
        }

        protected override string DumpHead => "*star*";
    }
}

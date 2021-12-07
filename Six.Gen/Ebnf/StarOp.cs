namespace Six.Gen.Ebnf
{
    public sealed class StarOp : CoreOp
    {
        public StarOp(ILocation location, CoreOp argument)
            : base(location, argument)
        {
        }

        protected override string DumpHead => "*star*";
    }
}

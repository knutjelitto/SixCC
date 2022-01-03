namespace Six.Gen.Ebnf
{
    public sealed class DropOp : CoreOp
    {
        public DropOp(ILocation location, CoreOp argument)
            : base(location, argument)
        {
        }

        protected override string DumpHead => ",drop,";
    }
}

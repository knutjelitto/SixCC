namespace Six.Gen.Ebnf
{
    public sealed class OptionalOp : CoreOp
    {
        public OptionalOp(ILocation location, CoreOp argument)
            : base(location, argument)
        {
        }

        protected override string DumpHead => "optional";
    }
}

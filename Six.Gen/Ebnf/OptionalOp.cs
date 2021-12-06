namespace Six.Gen.Ebnf
{
    public sealed class OptionalOp : Operator
    {
        public OptionalOp(ILocation location, Operator argument)
            : base(location, argument)
        {
        }

        protected override string DumpHead => "optional";
    }
}

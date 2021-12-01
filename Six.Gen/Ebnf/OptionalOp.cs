namespace Six.Gen.Ebnf
{
    public sealed class OptionalOp : Operator
    {
        public OptionalOp(Operator argument)
            : base(argument)
        {
        }

        protected override string DumpHead => "optional";
    }
}

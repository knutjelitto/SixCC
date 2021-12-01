namespace Six.Gen.Ebnf
{
    public sealed class AndOp : Operator
    {
        public AndOp(Operator argument)
            : base(argument)
        {
        }

        protected override string DumpHead => "and";
    }
}

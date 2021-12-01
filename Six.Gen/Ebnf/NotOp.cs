namespace Six.Gen.Ebnf
{
    public sealed class NotOp : Operator
    {
        public NotOp(Operator argument)
            : base(argument)
        {
        }

        protected override string DumpHead => "not";
    }
}

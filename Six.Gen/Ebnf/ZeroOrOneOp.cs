namespace Six.Gen.Ebnf
{
    public class ZeroOrOneOp : Operator
    {
        public ZeroOrOneOp(Operator argument)
            : base(argument)
        {
        }

        protected override string DumpHead => "?";
    }
}

namespace Six.Gen.Ebnf
{
    public class ZeroOrMoreOp : Operator
    {
        public ZeroOrMoreOp(Operator argument)
            : base(argument)
        {
        }

        protected override string DumpHead => "*";
    }
}

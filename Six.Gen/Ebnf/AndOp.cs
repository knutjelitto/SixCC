namespace Six.Gen.Ebnf
{
    public class AndOp : Operator
    {
        public AndOp(Operator argument)
            : base(argument)
        {
        }

        protected override string DumpHead => "&";
    }
}

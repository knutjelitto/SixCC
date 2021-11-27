namespace Six.Gen.Ebnf
{
    public class OneOrMoreOp : Operator
    {
        public OneOrMoreOp(Operator argument)
            : base(argument)
        {
        }

        protected override string DumpHead => "+";
    }
}

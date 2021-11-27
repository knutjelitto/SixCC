namespace Six.Gen.Ebnf
{
    public class NotOp : Operator
    {
        public NotOp(Operator argument)
            : base(argument)
        {
        }

        protected override string DumpHead => "!";
    }
}

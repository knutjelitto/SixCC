namespace Six.Gen.Ebnf
{
    public sealed class PlusOp : Operator
    {
        public PlusOp(Operator argument)
            : base(argument)
        {
        }

        protected override string DumpHead => "+plus+";
    }
}

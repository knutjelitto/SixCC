namespace Six.Gen.Ebnf
{
    public sealed class StarOp : Operator
    {
        public StarOp(Operator argument)
            : base(argument)
        {
        }

        protected override string DumpHead => "*star*";
    }
}

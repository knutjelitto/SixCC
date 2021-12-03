namespace Six.Gen.Ebnf
{
    public sealed class DiffOp : Operator
    {
        public DiffOp(Operator argument1, Operator argument2)
            : base(argument1, argument2)
        {
        }

        protected override string DumpHead => "diff";
    }
}

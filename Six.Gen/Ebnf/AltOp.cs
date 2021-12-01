namespace Six.Gen.Ebnf
{
    public sealed class AltOp : Operator
    {
        public AltOp(IEnumerable<Operator> arguments)
            : base(arguments)
        {
        }

        protected override string DumpHead => "alternatives";
    }
}

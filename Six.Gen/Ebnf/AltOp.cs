namespace Six.Gen.Ebnf
{
    public sealed class AltOp : Operator
    {
        public AltOp(ILocation location, IEnumerable<Operator> arguments)
            : base(location, arguments)
        {
        }

        protected override string DumpHead => "alternatives";
    }
}

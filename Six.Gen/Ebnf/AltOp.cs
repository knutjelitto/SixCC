namespace Six.Gen.Ebnf
{
    public sealed class AltOp : CoreOp
    {
        public AltOp(ILocation location, IEnumerable<CoreOp> arguments)
            : base(location, arguments)
        {
        }

        protected override string DumpHead => "alternatives";
    }
}

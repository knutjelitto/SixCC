namespace Six.Gen.Ebnf
{
    public sealed class EofOp : CoreOp
    {
        public EofOp(ILocation location)
            : base(location)
        {
        }

        protected override string DumpHead => "eof";
    }
}

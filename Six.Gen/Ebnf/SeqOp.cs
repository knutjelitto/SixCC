namespace Six.Gen.Ebnf
{
    public sealed class SeqOp : CoreOp
    {
        public SeqOp(ILocation location, IEnumerable<CoreOp> arguments)
            : base(location, arguments)
        {
        }

        public SeqOp(ILocation location, params CoreOp[] arguments)
            : base(location, arguments)
        {
        }

        protected override string DumpHead => "sequence";
    }
}

namespace Six.Gen.Ebnf
{
    public sealed class SeqOp : Operator
    {
        public SeqOp(ILocation location, IEnumerable<Operator> arguments)
            : base(location, arguments)
        {
        }

        public SeqOp(ILocation location, params Operator[] arguments)
            : base(location, arguments)
        {
        }

        protected override string DumpHead => "sequence";
    }
}

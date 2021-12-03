namespace Six.Gen.Ebnf
{
    public sealed class SeqOp : Operator
    {
        public SeqOp(IEnumerable<Operator> arguments)
            : base(arguments)
        {
        }

        public SeqOp(params Operator[] arguments)
            : base(arguments)
        {
        }

        protected override string DumpHead => "sequence";
    }
}

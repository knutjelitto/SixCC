namespace Six.Gen.Ebnf
{
    public class SeqOp : Operator
    {
        public SeqOp(IEnumerable<Operator> arguments)
            : base(arguments)
        {
        }

        protected override string DumpHead => "══";
    }
}

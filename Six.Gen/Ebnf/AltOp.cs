namespace Six.Gen.Ebnf
{
    public class AltOp : Operator
    {
        public AltOp(IEnumerable<Operator> arguments)
            : base(arguments)
        {
        }

        protected override string DumpHead => "║";
    }
}

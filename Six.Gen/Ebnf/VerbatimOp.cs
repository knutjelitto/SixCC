namespace Six.Gen.Ebnf
{
    public class VerbatimOp : Operator
    {
        public VerbatimOp(Operator argument)
            : base(argument)
        {
        }

        protected override string DumpHead => "⇔";
    }
}

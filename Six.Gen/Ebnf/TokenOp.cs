namespace Six.Gen.Ebnf
{
    public sealed class TokenOp : Operator
    {
        public TokenOp(Operator argument)
            : base(argument)
        {
        }

        protected override string DumpHead => "token";
    }
}

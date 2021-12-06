namespace Six.Gen.Ebnf
{
    public sealed class TokenOp : Operator
    {
        public TokenOp(ILocation location, Operator argument)
            : base(location, argument)
        {
        }

        protected override string DumpHead => "token";
    }
}

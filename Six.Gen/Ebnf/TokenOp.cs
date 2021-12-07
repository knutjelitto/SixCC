namespace Six.Gen.Ebnf
{
    public sealed class TokenOp : CoreOp
    {
        public TokenOp(ILocation location, CoreOp argument)
            : base(location, argument)
        {
        }

        protected override string DumpHead => "token";
    }
}

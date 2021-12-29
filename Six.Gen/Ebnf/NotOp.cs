namespace Six.Gen.Ebnf
{
    public sealed class NotOp : CoreOp
    {
        public NotOp(ILocation location, CoreOp argument)
            : base(location, argument)
        {
        }

        protected override string DumpHead => "!not!";
    }
}

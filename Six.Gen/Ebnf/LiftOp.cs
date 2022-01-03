namespace Six.Gen.Ebnf
{
    public sealed class LiftOp : CoreOp
    {
        public LiftOp(ILocation location, CoreOp argument)
            : base(location, argument)
        {
        }

        protected override string DumpHead => "^lift^";
    }
}

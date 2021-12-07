namespace Six.Gen.Ebnf
{
    public sealed class SetOp : CoreOp
    {
        public SetOp(ILocation location, CoreOp argument1, CoreOp argument2)
            : base(location, argument1, argument2)
        {
        }

        public Integers? CodepointSet { get; private set; }

        public void Set(Integers set)
        {
            CodepointSet = set;
        }

        protected override string DumpHead => "diff";
    }
}

namespace Six.Gen.Ebnf
{
    public sealed class DiffOp : Operator
    {
        public DiffOp(ILocation location, Operator argument1, Operator argument2)
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

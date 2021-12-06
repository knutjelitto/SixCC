using Six.Rex;

namespace Six.Gen.Ebnf
{
    public class RuleOp : Operator
    {
        public RuleOp(string name, ILocation location, Operator argument)
            : base(location, argument)
        {
            Name = name;
        }

        public RuleOp(string name, ILocation location)
            : base(location)
        {
            Name = name;
        }

        public void Set(ILocation location, Operator argument)
        {
            Set(location);
            Set(argument);
        }

        public string Name { get; }
        public FA? DFA { get; set; }

        protected override string DumpHead => Name;
    }
}

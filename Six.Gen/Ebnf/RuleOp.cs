using Six.Rex;

namespace Six.Gen.Ebnf
{
    public class RuleOp : Operator
    {
        public RuleOp(string name, ILocation location, Operator argument)
            : base(argument)
        {
            Name = name;
            Set(location);
        }

        public RuleOp(string name, ILocation location)
        {
            Name = name;
            Set(location);
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

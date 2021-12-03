using Six.Rex;

namespace Six.Gen.Ebnf
{
    public class RuleOp : Operator
    {
        public RuleOp(string name, Operator argument)
            : base(argument)
        {
            Name = name;
        }

        public RuleOp(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public FA? DFA { get; set; }

        protected override string DumpHead => Name;
    }
}

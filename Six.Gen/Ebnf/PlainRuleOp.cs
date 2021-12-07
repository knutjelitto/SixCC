using Six.Rex;

namespace Six.Gen.Ebnf
{
    public class PlainRuleOp : RuleOp
    {
        public PlainRuleOp(string name, ILocation location, CoreOp argument)
            : base(name, location, argument)
        {
        }

        public PlainRuleOp(string name, ILocation location)
            : base(name, location)
        {
        }

        protected override string DumpHead => Name;
    }
}

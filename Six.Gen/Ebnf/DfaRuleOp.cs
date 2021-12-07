namespace Six.Gen.Ebnf
{
    public class DfaRuleOp : RuleOp
    {
        public DfaRuleOp(string name, ILocation location)
            : base(name, location)
        {
        }
        public DfaRuleOp(string name, ILocation location, CoreOp argument)
            : base(name, location, argument)
        {
        }
    }
}

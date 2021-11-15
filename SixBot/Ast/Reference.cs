namespace SixBot.Ast
{
    internal class Reference : Expression
    {
        public Reference(Rule rule)
        {
            Rule = rule;
        }

        public Rule Rule { get; }
        public string Name => Rule.Name;

        public override bool IsAtomic => true;

        public override string ToName() => $"{Name}";
    }
}

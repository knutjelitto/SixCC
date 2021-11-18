namespace Six.Ast
{
    public class Reference : Expression
    {
        internal Reference(ILocation? location, Rule rule)
            : base(location)
        {
            Rule = rule;
        }

        public Rule Rule { get; }
        public string Name => Rule.Name;

        public override bool IsAtomic => true;
        public override bool IsCompact => Rule.IsCompact;

        public override string ToName() => $"{Name}";
    }
}

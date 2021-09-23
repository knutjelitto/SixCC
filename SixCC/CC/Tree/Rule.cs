namespace SixCC.CC.Tree
{
    internal class Rule : Family, Expression
    {
        public Rule(Name name, Expression expression)
            : base(name, expression)
        {
            Name = name;
            Expression = expression;
        }

        public Name Name { get; }
        public Expression Expression { get; }
        public override string Head => "rule";
    }
}

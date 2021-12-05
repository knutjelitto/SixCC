namespace Six.Ast
{
    public abstract class Symbol : Expression
    {
        internal Symbol(ILocation location, string name, Expression expression)
            : base(location)
        {
            Name = name;
            Expression = expression;
            Id = -1;
        }

        public string Name { get; }
        public Expression Expression { get; }

        public override bool IsSimple => true;
    }
}

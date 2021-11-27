namespace Six.Ast
{
    public class Alternation : Expression, IWithMany
    {
        internal Alternation(ILocation location, params Expression[] expressions)
            : this(location, expressions.AsEnumerable())
        {
        }

        internal Alternation(ILocation location, IEnumerable<Expression> expressions)
            : base(location)
        {
            Expressions = expressions.ToList();
        }

        public List<Expression> Expressions { get; }

        public override bool IsSimple => Expressions.Count == 1;
        public override bool IsCompact => Expressions.Count == 1 && Expressions[0].IsCompact;
    }
}

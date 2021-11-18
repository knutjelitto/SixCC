namespace Six.Ast
{
    public class Seq : Expression
    {
        internal Seq(ILocation? location, params Expression[] expressions)
            : this(location, expressions.AsEnumerable())
        {
        }

        internal Seq(ILocation? location, IEnumerable<Expression> expressions)
            : base(location)
        {
            Expressions = expressions.ToList();
        }

        public List<Expression> Expressions { get; }

        public override bool IsAtomic => Expressions.Count == 1 && Expressions[0].IsAtomic;

        public override string ToName() => $"({string.Join("+", Expressions.Select(e => e.ToName()))})";
    }
}

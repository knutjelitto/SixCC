namespace Six.Ast
{
    public class Sequence : Expression, IWithMany
    {
        internal Sequence(ILocation location, bool definite, params Expression[] expressions)
            : this(location, definite, expressions.AsEnumerable())
        {
        }

        internal Sequence(ILocation location, bool definite, IEnumerable<Expression> expressions)
            : base(location)
        {
            Expressions = expressions.ToList();
            Definite = definite;
        }

        public List<Expression> Expressions { get; }

        public override bool IsSimple => Expressions.Count <= 1;

        public bool Definite { get; }
    }
}

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
        public override bool IsCompact => Expression.IsCompact;
        public virtual bool IsTerminal => this is Terminal || IsCompact && !IsFragment;
        public virtual bool IsNonterminal => this is Nonterminal || (!IsTerminal && !IsFragment);

        /// <summary>
        /// true, if this expression is only used in terminal rules
        /// </summary>
        public bool IsFragment { get; set; }
    }
}

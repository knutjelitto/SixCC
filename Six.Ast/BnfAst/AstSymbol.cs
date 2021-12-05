namespace Six.Ast
{
    public sealed class AstSymbol : Symbol
    {
        internal AstSymbol(ILocation location, string name, Expression expression)
            : base(location, name, expression)
        {
        }

        public override string ToString()
        {
            return $"symbol {Name}";
        }
    }
}

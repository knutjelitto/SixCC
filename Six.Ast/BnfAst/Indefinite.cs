namespace Six.Ast
{
    public sealed class Indefinite : Symbol
    {
        internal Indefinite(ILocation location, string name, Expression expression)
            : base(location, name, expression)
        {
        }

        public override string ToString()
        {
            return $"indefinite #{Name}#";
        }
    }
}

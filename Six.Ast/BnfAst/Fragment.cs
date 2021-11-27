namespace Six.Ast
{
    public sealed class Fragment : Symbol
    {
        internal Fragment(ILocation location, string name, Expression expression)
            : base(location, name, expression)
        {
        }

        public override string ToString()
        {
            return $"fragment <{Name}>";
        }
    }
}

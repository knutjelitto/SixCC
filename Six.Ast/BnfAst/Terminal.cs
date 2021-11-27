namespace Six.Ast
{
    public sealed class Terminal : Symbol
    {
        internal Terminal(ILocation location, string name, Expression expression)
            : base(location, name, expression)
        {
        }

        public override string ToString()
        {
            return $"terminal <{Name}>";
        }
    }
}

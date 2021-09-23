namespace Six.Ceylon.Ast
{
    public sealed class VariadicType : Node, Type
    {
        public VariadicType(Type type, Terminal terminal)
        {
            Type = type;
            Terminal = terminal;
        }

        public Type Type { get; }
        public Terminal Terminal { get; }
    }
}

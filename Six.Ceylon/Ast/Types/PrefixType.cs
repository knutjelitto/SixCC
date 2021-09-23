namespace Six.Ceylon.Ast
{
    public sealed class PrefixType : Node, Type
    {
        public PrefixType(Terminal terminal)
        {
            Terminal = terminal;
        }

        public Terminal Terminal { get; }
    }
}

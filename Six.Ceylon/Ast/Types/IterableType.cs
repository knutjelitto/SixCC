namespace Six.Ceylon.Ast
{
    /// <summary>
    /// '{' unionType ('*' | '+') '}'
    /// </summary>
    public sealed class IterableType : Node, SugarType
    {
        public IterableType(Terminal op, Type type)
        {
            Op = op;
            Type = type;
        }

        public Terminal Op { get; }
        public Type Type { get; }
    }
}

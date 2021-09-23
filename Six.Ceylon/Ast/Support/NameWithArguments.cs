namespace Six.Ceylon.Ast
{
    public sealed class NameWithArguments : Node
    {
        public NameWithArguments(Name name, TypeArguments? arguments)
        {
            Name = name;
            Arguments = arguments;
        }

        public Name Name { get; }
        public TypeArguments? Arguments { get; }
    }
}

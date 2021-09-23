namespace Six.Ceylon.Ast
{
    public sealed class NamedArguments : Node, Arguments
    {
        public NamedArguments(NamedArgumentList named, ArgumentList positional)
        {
            Named = named;
            Positional = positional;
        }

        public NamedArgumentList Named { get; }
        public ArgumentList Positional { get; }
    }
}

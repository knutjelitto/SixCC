namespace Six.Ceylon.Ast
{
    public sealed class PositionalArguments : Node, Arguments
    {
        public PositionalArguments(ArgumentList positional)
        {
            Positional = positional;
        }

        public ArgumentList Positional { get; }
    }
}

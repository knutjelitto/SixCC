namespace Six.Ceylon.Ast
{
    public sealed class ValueArgument : Node, NamedArgument
    {
        public ValueArgument(ValueHeader header, Definition body)
        {
            Header = header;
            Body = body;
        }

        public ValueHeader Header { get; }
        public Definition Body { get; }
    }
}

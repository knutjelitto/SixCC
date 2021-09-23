namespace Six.Ceylon.Ast
{
    public sealed class FunctionArgument : Node, NamedArgument
    {
        public FunctionArgument(FunctionHeader header, Definition body)
        {
            Header = header;
            Body = body;
        }

        public FunctionHeader Header { get; }
        public Definition Body { get; }
    }
}

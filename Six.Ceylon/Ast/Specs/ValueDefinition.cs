namespace Six.Ceylon.Ast
{
    public sealed class ValueDefinition : Node, Definition, Block
    {
        public ValueDefinition(ValueSpecifier specifier)
        {
            Specifier = specifier;
        }

        public ValueSpecifier Specifier { get; }
    }
}

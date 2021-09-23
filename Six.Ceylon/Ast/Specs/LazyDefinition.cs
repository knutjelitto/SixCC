namespace Six.Ceylon.Ast
{
    /// <summary>
    /// '=>' expression ';'
    /// </summary>
    public sealed class LazyDefinition : Node, Definition, Block
    {
        public LazyDefinition(LazySpecifier specifier)
        {
            Specifier = specifier;
        }

        public LazySpecifier Specifier { get; }
    }
}

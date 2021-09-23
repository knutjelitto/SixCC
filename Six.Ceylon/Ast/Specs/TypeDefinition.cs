namespace Six.Ceylon.Ast
{
    /// <summary>
    /// '=>' type ';'
    /// </summary>
    public sealed class TypeDefinition : Node, Definition
    {
        public TypeDefinition(TypeSpecifier specifier)
        {
            Specifier = specifier;
        }

        public TypeSpecifier Specifier { get; }
    }
}

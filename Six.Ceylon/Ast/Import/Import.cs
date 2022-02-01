namespace Six.Ceylon.Ast
{
    public record Import(Identifiers Path, Import.ElementList Elements) : AstNode
    {
        public abstract record Element : AstNode;
        public sealed record ElementList(IEnumerable<Element> Items) : ReadOnlyList<Element>(Items);

        public sealed record Wildcard : Element;
        public sealed record Named(Identifier Name, Identifier? Alias, ElementList? Elements) : Element;

        public abstract record List(IEnumerable<Import> Items) : ReadOnlyList<Import>(Items);
    }

    public sealed record Imports(IEnumerable<Import> Items) : Import.List(Items);
}

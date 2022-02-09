using Six.Runtime.Types;

namespace Six.Sax.Ast
{
    public record Parameter(IRNode Tree, Prelude Prelude, Name Name, Type Type) : Declaration.Entity;

    public record Parameters(IRNode Tree, IEnumerable<Parameter> Items) : Many<Parameter>(Tree, Items)
    {
        public Parameters(IRNode Tree) : this(Tree, Enumerable.Empty<Parameter>()) { }
    }
}

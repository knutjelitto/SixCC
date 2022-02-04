using Six.Runtime.Types;

namespace Six.Sax.Ast
{
    public interface Declaration : Node
    {
        public sealed record Function(IRNode Tree, Prelude Prelude, Type Type, Name Name, Parameters Parameters, Body Body) : Declaration;

        public sealed record Attribute(IRNode Tree, Prelude Prelude, Type? Type, Name Name, Body Body) : Declaration;

        public sealed record Class(IRNode Tree, Prelude Prelude, Name Name, Parameters? Parameters, Type? Extends, Types? Cases, Body Body) : Declaration;
        public sealed record Object(IRNode Tree, Prelude Prelude, Name Name, Type? Extends, Body Body) : Declaration;
    }

    public sealed record Declarations(IRNode Tree, IEnumerable<Declaration> Items) : Many<Declaration>(Tree, Items);
}

using Six.Runtime.Types;

namespace Six.Sax.Ast
{
    public interface Declaration : Node
    {
        public interface Entity : Declaration
        {
            Name Name { get; }
            Prelude Prelude { get; }

            public sealed record Function(
                IRNode Tree, 
                Prelude Prelude,
                Name Name,
                Generic.Parameters? Generics,
                Type Type, 
                Parameters Parameters,
                Generic.Constraints? Constraints,
                Body Body)
                : Entity;

            public sealed record Attribute(
                IRNode Tree, 
                Prelude Prelude, Name Name,
                Type? Type, Body Body)
                : Entity;

            public sealed record Class(
                IRNode Tree, 
                Prelude Prelude,
                Name Name,
                Generic.Parameters? Generics,
                Parameters? Parameters,
                Type? Extends,
                Types? Satisfies,
                Types? Cases,
                Generic.Constraints? Constraints,
                Body Body)
                : Entity;

            public sealed record Interface(
                IRNode Tree, 
                Prelude Prelude,
                Name Name,
                Generic.Parameters? Generics,
                Parameters? Parameters,
                Types? Satisfies,
                Types? Cases,
                Generic.Constraints? Constraints,
                Body Body)
                : Entity;

            public sealed record Object(
                IRNode Tree, 
                Prelude Prelude,
                Name Name,
                Type? Extends,
                Types? Satisfies,
                Body Body)
                : Entity;
        }
    }

    public sealed record Declarations(IRNode Tree, IEnumerable<Declaration> Items) : Many<Declaration>(Tree, Items);
}

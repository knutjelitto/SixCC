using Six.Runtime.Types;

namespace Six.Sax.Ast
{
    public interface Declaration : Node, INamed, Statelaration
    {
        public interface Entity : Declaration, IPreluded
        {
            public abstract record Impl(
                IRNode Tree,
                Prelude Prelude,
                Name Name,
                Generic.Parameters? Generics,
                Parameters? Parameters,
                Type? Extends,
                Types? Satisfies,
                Types? Cases,
                Generic.Constraints? Constraints,
                Body? Body,
                Type? Result
                ) : Entity;

            public sealed record Function(
                IRNode Tree, 
                Prelude Prelude,
                Name Name,
                Generic.Parameters? Generics,
                Type Result,
                Parameters Parameters,
                Generic.Constraints? Constraints,
                Body Body)
                : Impl(Tree, Prelude, Name, Generics, Parameters, null, null, null, Constraints, Body, Result);

            public sealed record Attribute(
                IRNode Tree, 
                Prelude Prelude,
                Name Name,
                Type? Type,
                Body Body)
                : Impl(Tree, Prelude, Name, null, null, null, null, null, null, Body, null);

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
                : Impl(Tree, Prelude, Name, Generics, Parameters, Extends, Satisfies, Cases, Constraints, Body, null);

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
                : Impl(Tree, Prelude, Name, Generics, Parameters, null, Satisfies, Cases, Constraints, Body, null);

            public sealed record Object(
                IRNode Tree,
                Prelude Prelude,
                Name Name,
                Type? Extends,
                Types? Satisfies,
                Body Body)
                : Impl(Tree, Prelude, Name, null, null, Extends, Satisfies, null, null, Body, null);

            public sealed record Alias(
                IRNode Tree,
                Prelude Prelude,
                Name Name,
                Generic.Parameters? Generics,
                Generic.Constraints? Constraints,
                Type? Result)
                : Impl(Tree, Prelude, Name, Generics, null, null, null, null, Constraints, null, Result);
        }
    }

    public sealed record Declarations(IRNode Tree, IEnumerable<Declaration> Items) : Many<Declaration>(Tree, Items);
}

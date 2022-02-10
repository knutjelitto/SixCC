using Six.Runtime.Types;

namespace Six.Sax.Ast
{
    public interface With : Node
    {
        public interface Prelude : Node
        {
            Ast.Prelude Prelude { get; }
        }

        public interface Name : Node
        {
            Ast.Name Name { get; }
        }

        public interface Body : Node
        {
            Ast.Body Body { get; }
        }
    }

    public interface Declaration : TreeNode, Statelaration
    {

        public interface Entity : Declaration, With.Prelude, With.Name
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
                Generic.Constraints? Constraints
                ) : Entity;

            public sealed record Function(
                IRNode Tree, 
                Prelude Prelude,
                Name Name,
                Generic.Parameters? Generics,
                Type Result,
                MultiParameters MultiParameters,
                Generic.Constraints? Constraints,
                Body Body)
                : Impl(Tree, Prelude, Name, Generics, null, null, null, null, Constraints), With.Body;

            public sealed record Attribute(
                IRNode Tree, 
                Prelude Prelude,
                Name Name,
                Type? Type,
                Body Body)
                : Impl(Tree, Prelude, Name, null, null, null, null, null, null), With.Body;

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
                : Impl(Tree, Prelude, Name, Generics, Parameters, Extends, Satisfies, Cases, Constraints), With.Body;

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
                : Impl(Tree, Prelude, Name, Generics, Parameters, null, Satisfies, Cases, Constraints), With.Body;

            public sealed record Object(
                IRNode Tree,
                Prelude Prelude,
                Name Name,
                Type? Extends,
                Types? Satisfies,
                Body Body)
                : Impl(Tree, Prelude, Name, null, null, Extends, Satisfies, null, null), With.Body;

            public sealed record Alias(
                IRNode Tree,
                Prelude Prelude,
                Name Name,
                Generic.Parameters? Generics,
                Generic.Constraints? Constraints,
                Type Result)
                : Impl(Tree, Prelude, Name, Generics, null, null, null, null, Constraints);
        }
    }

    public sealed record Declarations(IRNode Tree, IEnumerable<Declaration> Items) : Many<Declaration>(Tree, Items);
}

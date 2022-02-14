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

        public interface Parameters : Node
        {
            Ast.Parameters? Parameters { get; }
        }

        public interface MultiParameters : Node
        {
            Ast.MultiParameters MultiParameters { get; }
        }

        public interface TypeParameters : Node
        {
            Ast.Generic.TypeParameters? Generics { get; }
            Ast.Generic.Constraints? Constraints { get; }
        }

        public interface Extends : Node
        {
            Ast.Type? Extends { get; }
        }

        public interface Satisfies : Node
        {
            Ast.Type.Types? Satisfies { get; }
        }
    }

    public interface Declaration : TreeNode, Statelaration
    {
        public interface Entity : Declaration, With.Prelude, With.Name
        {
        }

        public sealed record Let(IRNode Tree, Prelude Prelude, Name Name, Type? Type, Expression Value) : Entity;
        public sealed record Var(IRNode Tree, Prelude Prelude, Name Name, Type? Type, Expression Value) : Entity;

        public abstract record EntityImpl(
            IRNode Tree,
            Prelude Prelude,
            Name Name,
            Generic.TypeParameters? Generics,
            Generic.Constraints? Constraints,
            Parameters? Parameters,
            Type? Extends,
            Type.Types? Satisfies,
            Type.Types? Cases
            )
            : Entity;

        public sealed record Function(
            IRNode Tree, 
            Prelude Prelude,
            Name Name,
            Generic.TypeParameters? Generics,
            Generic.Constraints? Constraints,
            Type? Result,
            MultiParameters MultiParameters,
            Body Body)
        :   EntityImpl(Tree, Prelude, Name, Generics, Constraints, null, null, null, null),
            With.Body,
            With.TypeParameters,
            With.MultiParameters;

        public sealed record Attribute(
            IRNode Tree, 
            Prelude Prelude,
            Name Name,
            Type? Type,
            Body Body)
        :   EntityImpl(Tree, Prelude, Name, null, null, null, null, null, null),
            With.Body;

        public sealed record Class(
            IRNode Tree, 
            Prelude Prelude,
            Name Name,
            Generic.TypeParameters? Generics,
            Generic.Constraints? Constraints,
            Parameters? Parameters,
            Type? Extends,
            Type.Types? Satisfies,
            Type.Types? Cases,
            Body Body)
        :   EntityImpl(Tree, Prelude, Name, Generics, Constraints, Parameters, Extends, Satisfies, Cases),
            With.Body,
            With.TypeParameters,
            With.Parameters,
            With.Extends,
            With.Satisfies;

        public sealed record Interface(
            IRNode Tree, 
            Prelude Prelude,
            Name Name,
            Generic.TypeParameters? Generics,
            Generic.Constraints? Constraints,
            Parameters? Parameters,
            Type.Types? Satisfies,
            Type.Types? Cases,
            Body Body)
        :   EntityImpl(Tree, Prelude, Name, Generics, Constraints, Parameters, null, Satisfies, Cases),
            With.Body,
            With.TypeParameters,
            With.Parameters,
            With.Satisfies;

        public sealed record Object(
            IRNode Tree,
            Prelude Prelude,
            Name Name,
            Type? Extends,
            Type.Types? Satisfies,
            Body Body)
        :   EntityImpl(Tree, Prelude, Name, null, null, null, Extends, Satisfies, null),
            With.Body,
            With.Extends,
            With.Satisfies;

        public sealed record Alias(
            IRNode Tree,
            Prelude Prelude,
            Name Name,
            Generic.TypeParameters? Generics,
            Generic.Constraints? Constraints,
            Type Result)
        :   EntityImpl(Tree, Prelude, Name, Generics, Constraints, null, null, null, null),
            With.TypeParameters;
    }

    public sealed record Declarations(IRNode Tree, IEnumerable<Declaration> Items) : Many<Declaration>(Tree, Items);
}

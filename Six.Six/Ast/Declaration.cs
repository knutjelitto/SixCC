using Six.Runtime.Types;

namespace Six.Six.Ast
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

        public interface Generics : Node
        {
            Ast.Generic.TypeParameters? TypeParameters { get; }
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
            Generic.TypeParameters? TypeParameters,
            Generic.Constraints? Constraints,
            Parameters? Parameters,
            Type? Extends,
            Type.Types? Satisfies,
            Type.Types? Cases
            )
            : Entity;

        public sealed record Primitive(IRNode Tree, Prelude Prelude, Name Name) : Entity;

        public sealed record Infix(IRNode Tree, Prelude Prelude, Name Name, Type Type, DefinitiveParameter Left, DefinitiveParameter Right, Body Body) : Entity;
        public sealed record Prefix(IRNode Tree, Prelude Prelude, Name Name, Type Type, DefinitiveParameter Parameter, Body Body) : Entity;

        public sealed record Function(
            IRNode Tree, 
            Prelude Prelude,
            Name Name,
            Generic.TypeParameters? Generics,
            Generic.Constraints? Constraints,
            Type? Result,
            Parameters Parameters,
            Body Body)
        :   EntityImpl(Tree, Prelude, Name, Generics, Constraints, Parameters, null, null, null),
            With.Generics,
            With.Parameters,
            With.Body;

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
            With.Generics,
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
            With.Generics,
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
            With.Generics;

        public sealed record Constructor(
            IRNode Tree,
            Prelude Prelude,
            Name? Name,
            Parameters Parameters,
            Body Body)
        : EntityImpl(Tree, Prelude, Name ?? new Name.ArtificalId("default.ctor"), null, null, Parameters, null, null, null),
            With.Parameters,
            With.Body;
    }

    public sealed record Declarations(IRNode Tree, IEnumerable<Declaration> Items) : Many<Declaration>(Tree, Items);
}

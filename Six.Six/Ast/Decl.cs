using Six.Runtime.Types;

namespace Six.Six.Ast
{
    public interface With : Node
    {
        public interface Prelude : Node
        {
            Ast.Prelude Prelude { get; }
        }

        public interface Name : TreeNode
        {
            Ast.Name Name { get; }
        }

        public interface Body : Node
        {
            Ast.Body Body { get; }
        }

        public interface Type : Node
        {
            Ast.Type Type { get; }
        }

        public interface Result : Node
        {
            Ast.Type Result { get; }
        }

        public interface OptionalType : Node
        {
            Ast.Type? Type { get; }
        }

        public interface Value : Node
        {
            Expression? Value { get; }
        }

        public interface Parameters : Node
        {
            Decl.Parameters? Parameters { get; }
        }

        public interface Generics : Node
        {
            TypeParameters? TypeParameters { get; }
            TypeConstraints? Constraints { get; }
        }

        public interface Extends : Node
        {
            Ast.Type? Extends { get; }
        }

        public interface Satisfies : Node
        {
            Ast.Type.Types? Satisfies { get; }
        }

        public interface Cases : Node
        {
            Ast.Type.Types? Cases { get; }
        }
    }

    public sealed record Declarations(IRNode Tree, IEnumerable<Decl> Items)
        : Many<Decl>(Tree, Items);

    public interface Decl : StmtOrDecl, With.Name
    {
        public interface Preluded : Decl, With.Prelude { }
        public interface Classy : Preluded, With.Body { }
        public interface Funcy : Preluded, With.Parameters, With.Body { }

        public sealed record Let(
            IRNode Tree, 
            Prelude Prelude, 
            Name Name, 
            Type? Type,
            Expression Value)
            : Preluded,
              With.OptionalType,
              With.Value;

        public sealed record Var(
            IRNode Tree, 
            Prelude Prelude, 
            Name Name, 
            Type? Type, 
            Expression Value)
            : Preluded,
              With.OptionalType,
              With.Value;

        public sealed record Attribute(
            IRNode Tree,
            Prelude Prelude,
            Name Name,
            Type Type,
            Body Body)
            : Preluded,
              With.Type,
              With.Body;

        public sealed record Prefix(
            IRNode Tree, 
            Prelude Prelude, 
            Name Name, 
            Type Result, 
            Parameters Parameters, 
            Body Body)
            : Funcy,
              With.Result;

        public sealed record Infix(
            IRNode Tree, 
            Prelude Prelude, 
            Name Name, 
            Type Result, 
            Parameters Parameters,
            Body Body)
            : Funcy,
              With.Result;

        public sealed record Constructor(
            IRNode Tree,
            Prelude Prelude,
            Name Name,
            Parameters Parameters,
            Type? Extends,
            Body Body)
            : Funcy,
              With.Extends;

        public sealed record Function(
            IRNode Tree, 
            Prelude Prelude,
            Name Name,
            TypeParameters? TypeParameters,
            TypeConstraints? Constraints,
            Type Result,
            Parameters Parameters,
            Body Body)
            : Funcy,
              With.Generics,
              With.Result;

        public sealed record Class(
            IRNode Tree, 
            Prelude Prelude,
            Name Name,
            TypeParameters? TypeParameters,
            TypeConstraints? Constraints,
            Parameters? Parameters,
            Type? Extends,
            Type.Types? Satisfies,
            Type.Types? Cases,
            Body Body)
            : Classy,
              With.Generics,
              With.Parameters,
              With.Extends,
              With.Satisfies,
              With.Cases;

        public sealed record Interface(
            IRNode Tree, 
            Prelude Prelude,
            Name Name,
            TypeParameters? TypeParameters,
            TypeConstraints? Constraints,
            Parameters? Parameters,
            Type.Types? Satisfies,
            Type.Types? Cases,
            Body Body)
            : Classy,
              With.Generics,
              With.Parameters,
              With.Satisfies,
              With.Cases;

        public sealed record Primitive(IRNode Tree, Prelude Prelude, Name Name, Type.Types? Cases, Body Body)
            : Classy,
              With.Cases;

        public sealed record Object(
            IRNode Tree,
            Prelude Prelude,
            Name Name,
            Type? Extends,
            Type.Types? Satisfies,
            Body Body)
            : Classy,
              With.Extends,
              With.Satisfies;

        public sealed record Alias(
            IRNode Tree,
            Prelude Prelude,
            Name Name,
            TypeParameters? TypeParameters,
            TypeConstraints? Constraints,
            Type Type)
            : Preluded,
              With.Generics,
              With.Type;

        public interface Parameter
            : Preluded,
              With.Type
        {
        }

        public record ValueParameter(
            IRNode Tree, 
            Prelude Prelude, 
            Name Name, 
            Type Type,
            Expression? Default)
            : Parameter;

        public record DefinitiveParameter(
            IRNode Tree, 
            Prelude Prelude, 
            Name Name, 
            Type Type)
            : Parameter;

        public record Parameters(IRNode Tree, IEnumerable<Parameter> Items)
            : Many<Parameter>(Tree, Items)
        {
            public Parameters(IRNode Tree, params Parameter[] items) : this(Tree, items.AsEnumerable()) { }
        }

    }
}

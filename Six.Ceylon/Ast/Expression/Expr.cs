namespace Six.Ceylon.Ast
{
    public interface Expr : AstNode, Argument, CaseItem, Comprehension
    {
        public class Instance : Expr { }

        public record Infix(string Op, Expr Left, Expr Right) : Expr;

        public record Infix2(Expr Left, string Op1, Expr Mid, string Op2, Expr Right) : Expr;

        public record Prefix(string Op, Expr Right) : Expr;

        public record Postfix(Expr Left, string Op) : Expr;

        public sealed record Exists(Expr Expr) : Expr;

        public sealed record Nonempty(Expr Expr) : Expr;

        public sealed record Member(Identifier Name, TypeParameterList? TypeParameters, ParametersList Parameters) : Expr;

        public sealed record Enumeration(StatementList Stmts, ArgumentList? Arguments) : Expr;

        public record SelfReference(string Reference) : Expr;

        public record Indexed(Expr Expr, Expr Index) : Expr;

        public record SpanIndex(Expr From, Expr To) : Expr;

        public record MeasureIndex(Expr From, Expr Count) : Expr;

        public record FromIndex(Expr From) : Expr;

        public record ToIndex(Expr To) : Expr;

        public record SpecifiedVariable(Pattern.Variable Variable, Specifier.Value Specifier) : Expr;

        public record Interpolation(
            IReadOnlyList<InterpolationString> Strings,
            IReadOnlyList<Expr> Expressions)
            : Expr;

        public sealed record Call(Expr Expr, Arguments Arguments) : Expr;

        public sealed record Object(Extended? Extended, Satisfied? Satisfied, Block Block) : Expr;

        public new sealed record If(Conditions Conditions, Expr Then, Expr Else) : Expr;

        public sealed record Tuple(ArgumentList Arguments) : Expr;

        public sealed record Let(LetVariableList? Lets, Expr Expr) : Expr;

        public sealed record Typecheck(Expr Expr, string op, Type Type) : Expr;

        public sealed record Switch(Expr Head, CaseList Cases, Expr? Else) : Expr;
        public sealed record Case(CaseItem Item, Expr Expr) : AstNode;
        public sealed record CaseList(IEnumerable<Case> cases) : ReadOnlyList<Case>(cases);

        public abstract record Function(TypeParameterList? TypeParameters, ParametersList Parameters, TypeConstraintList? Constraints, Expr Definition)
            : Expr;

        public sealed record InferredFunction(TypeParameterList? TypeParameters, ParametersList Parameters, TypeConstraintList? Constraints, Expr Definition)
            : Function(TypeParameters, Parameters, Constraints, Definition);

        public sealed record VoidFunction(TypeParameterList? TypeParameters, ParametersList Parameters, TypeConstraintList? Constraints, Expr Definition)
            : Function(TypeParameters, Parameters, Constraints, Definition);

        public sealed record MemberReference(Identifier Name, TypeArgumentList? Arguments) : Expr;
        public sealed record TypeReference(Identifier Name, TypeArgumentList? Arguments) : Expr;

        public interface Specifier : Expr
        {
            public sealed record Value(string Op, Expr Right) : Prefix(Op, Right), Specifier;
            new public sealed record Function(string Op, Expr Right) : Prefix(Op, Right), Specifier;
            public sealed record Null() : Specifier;
        }

        public interface Meta : Expr
        {
            public sealed record Class(ReferencePath Path) : Meta;
            public sealed record Interface(ReferencePath Path) : Meta;
            public sealed record Value(ReferencePath Path) : Meta;
            new public sealed record Object(ReferencePath Path) : Meta;
            new public sealed record Function(ReferencePath Path) : Meta;
            public sealed record Alias(ReferencePath Path) : Meta;
            public sealed record New(ReferencePath Path) : Meta;
            public sealed record Given(ReferencePath Path) : Meta;
            public sealed record Package(IdentifierList? Path) : Meta;
            public sealed record Module(IdentifierList? Path) : Meta;
        }
    }
}

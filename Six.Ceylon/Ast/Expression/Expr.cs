namespace Six.Ceylon.Ast
{
    public interface Expr : AstNode, Argument, CaseItem, Comprehension
    {
        public class Instance : Expr { }

        public record Infix(string Op, Expr Left, Expr Right) : Expr;

        public record SmallerBounds(Expr Left, string Op1, Expr Mid, string Op2, Expr Right) : Expr;

        public record Prefix(string Op, Expr Right) : Expr;

        public record PostfixIncDec(Expr Left, string Op) : Expr;

        public record PrefixIncDec(string op, Expr Left) : Expr;

        public sealed record Exists(Expr Expr) : Expr;

        public sealed record Nonempty(Expr Expr) : Expr;

        public sealed record Member(Identifier Name, TypeParameters? TypeParameters, ParametersList Parameters) : Expr;

        public sealed record Enumeration(StatementList Stmts, ArgumentList? Arguments) : Expr;

        public record SelfReference(string Reference) : Expr;

        public record Indexed(Expr Expr, Expr Index) : Expr;

        public record SpannedIndex(Expr From, Expr To) : Expr;

        public record MeasuredIndex(Expr From, Expr Count) : Expr;

        public record FromIndex(Expr From) : Expr;

        public record ToIndex(Expr To) : Expr;

        public record SpecifiedVariable(Pattern.Variable Variable, Specifier Specifier) : Expr;

        public record Interpolation(Strings Strings, Expressions Expressions) : Expr;

        public sealed record Call(Expr Expr, Arguments Arguments) : Expr;

        public sealed record Object(Extends? Extended, Satisfies? Satisfied, Block Block) : Expr;

        public new sealed record If(Conditions Conditions, Expr Then, Expr Else) : Expr;

        public sealed record Tuple(ArgumentList Arguments) : Expr;

        public sealed record Let(LetVariableList? Lets, Expr Expr) : Expr;

        public sealed record Typecheck(Expr Expr, string op, Type Type) : Expr;

        public sealed record Switch(Expr Head, CaseList Cases, Expr? Else) : Expr;
        public sealed record Case(CaseItem Item, Expr Expr) : AstNode;
        public sealed record CaseList(IEnumerable<Case> cases) : ReadOnlyList<Case>(cases);

        public abstract record Function(TypeParameters? TypeParameters, ParametersList Parameters, TypeConstraints? Constraints, Expr Definition)
            : Expr;

        public sealed record InferredFunction(TypeParameters? TypeParameters, ParametersList Parameters, TypeConstraints? Constraints, Expr Definition)
            : Function(TypeParameters, Parameters, Constraints, Definition);

        public sealed record VoidFunction(TypeParameters? TypeParameters, ParametersList Parameters, TypeConstraints? Constraints, Expr Definition)
            : Function(TypeParameters, Parameters, Constraints, Definition);

        public sealed record MemberReference(Identifier Name, TypeArgumentList? Arguments) : Expr;
        public sealed record TypeReference(Identifier Name, TypeArgumentList? Arguments) : Expr;

        public interface Specifier : Expr
        {
            public sealed record Value(string Op, Expr Expr) : Specifier;
            new public sealed record Function(string Op, Expr Expr) : Specifier;
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
            public sealed record Package(Identifiers? Path) : Meta;
            public sealed record Module(Identifiers? Path) : Meta;
        }

        public sealed record Expressions(IEnumerable<Expr> items) : ReadOnlyList<Expr>(items);
        public sealed record Strings(IEnumerable<String> items) : ReadOnlyList<String>(items);
    }
}

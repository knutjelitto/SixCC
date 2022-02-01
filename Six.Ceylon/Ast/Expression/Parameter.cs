namespace Six.Ceylon.Ast
{
    public interface Parameter : AstNode
    {
        public record Declared(Annotations Annotations, ParameterDeclaration Declaration) : Parameter;

        public record Reference(Identifier Name, Expr.Specifier? Specifier) : Parameter;

        public abstract record ParameterDeclaration : AstNode;

        public abstract record Function(Identifier Name, TypeParameters? TypeParameters, ParametersList Parameters, Expr.Specifier.Function? Specifier)
            : ParameterDeclaration;

        public record VoidFunction(Identifier Name, TypeParameters? TypeParameters, ParametersList Parameters, Expr.Specifier.Function? Specifier)
            : Function(Name, TypeParameters, Parameters, Specifier);

        public record InferredFunction(Identifier Name, TypeParameters? TypeParameters, ParametersList Parameters, Expr.Specifier.Function? Specifier)
            : Function(Name, TypeParameters, Parameters, Specifier);

        public record TypedFunction(Type Type, Identifier Name, TypeParameters? TypeParameters, ParametersList Parameters, Expr.Specifier.Function? Specifier)
            : Function(Name, TypeParameters, Parameters, Specifier);

        public abstract record Value(Identifier Name, Expr.Specifier? Specifier)
            : ParameterDeclaration;

        public record InferredValue(Identifier Name, Expr.Specifier? Specifier)
            : Value(Name, Specifier);

        public record TypedValue(Type Type, Identifier Name, Expr.Specifier? Specifier)
            : Value(Name, Specifier);
    }

    public sealed record Parameters(IEnumerable<Parameter> Items) : ReadOnlyList<Parameter>(Items);

    public sealed record ParametersList(IEnumerable<Parameters> Items) : ReadOnlyList<Parameters>(Items);
}

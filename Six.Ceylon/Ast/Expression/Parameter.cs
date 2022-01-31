﻿namespace Six.Ceylon.Ast
{
    public interface Parameter : AstNode
    {
        public record Declared(Annotations Annotations, ParameterDeclaration Declaration) : Parameter;

        public record Reference(Identifier Name, Expr.Specifier.Value? Specifier) : Parameter;

        public abstract record ParameterDeclaration;

        public abstract record Function(Identifier Name, TypeParameterList? TypeParameters, ParametersList Parameters, Expr.Specifier.Function? Specifier)
            : ParameterDeclaration;

        public record VoidFunction(Identifier Name, TypeParameterList? TypeParameters, ParametersList Parameters, Expr.Specifier.Function? Specifier)
            : Function(Name, TypeParameters, Parameters, Specifier);

        public record InferredFunction(Identifier Name, TypeParameterList? TypeParameters, ParametersList Parameters, Expr.Specifier.Function? Specifier)
            : Function(Name, TypeParameters, Parameters, Specifier);

        public record TypedFunction(Type Type, Identifier Name, TypeParameterList? TypeParameters, ParametersList Parameters, Expr.Specifier.Function? Specifier)
            : Function(Name, TypeParameters, Parameters, Specifier);

        public abstract record Value(Identifier Name, Expr.Specifier.Value? Specifier)
            : ParameterDeclaration;

        public record InferredValue(Identifier Name, Expr.Specifier.Value? Specifier)
            : Value(Name, Specifier);

        public record TypedValue(Type Type, Identifier Name, Expr.Specifier.Value? Specifier)
            : Value(Name, Specifier);
    }

    public sealed record Parameters(IEnumerable<Parameter> Items) : ReadOnlyList<Parameter>(Items);

    public sealed record ParametersList(IEnumerable<Parameters> Items) : ReadOnlyList<Parameters>(Items);
}

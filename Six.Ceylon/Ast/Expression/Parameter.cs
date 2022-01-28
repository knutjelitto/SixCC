namespace Six.Ceylon.Ast
{
    public interface Parameter
    {
        public record Declared(Annotations Annotations, ParameterDeclaration Declaration) : Parameter;

        public record Reference(Identifier Name, Expression.ValueSpecifier? Specifier) : Parameter;

        public abstract record ParameterDeclaration;

        public abstract record Function(Identifier Name, TypeParameterList? TypeParameters, ParameterListList Parameters, Expression.FunctionSpecifier? Specifier)
            : ParameterDeclaration;

        public record VoidFunction(Identifier Name, TypeParameterList? TypeParameters, ParameterListList Parameters, Expression.FunctionSpecifier? Specifier)
            : Function(Name, TypeParameters, Parameters, Specifier);

        public record InferredFunction(Identifier Name, TypeParameterList? TypeParameters, ParameterListList Parameters, Expression.FunctionSpecifier? Specifier)
            : Function(Name, TypeParameters, Parameters, Specifier);

        public record TypedFunction(Typo Type, Identifier Name, TypeParameterList? TypeParameters, ParameterListList Parameters, Expression.FunctionSpecifier? Specifier)
            : Function(Name, TypeParameters, Parameters, Specifier);

        public abstract record Value(Identifier Name, Expression.ValueSpecifier? Specifier)
            : ParameterDeclaration;

        public record InferredValue(Identifier Name, Expression.ValueSpecifier? Specifier)
            : Value(Name, Specifier);

        public record TypedValue(Typo Type, Identifier Name, Expression.ValueSpecifier? Specifier)
            : Value(Name, Specifier);
    }
}

namespace Six.Ceylon.Ast
{
    public interface Decl : Stmt
    {
        string Location();

        public new record Core(Annotations Annotations, Identifier? Name) : Decl
        {
            public IBody Body => throw new System.NotImplementedException();

            public string Location()
            {
                return Name?.Token.Source.NameLineColumn(Name.Token.Core) ?? "<LOCATION>";
            }
        }

        public abstract record List(IEnumerable<Decl> Items) : ReadOnlyList<Decl>(Items);

        public sealed record Alias(
            Annotations Annotations,
            Identifier Name,
            TypeParameterList? TypeParameters,
            TypeConstraintList? TypeConstraints,
            Type? Definition)
        : Core(Annotations, Name);

        public abstract record InterClass(
            Annotations Annotations,
            Identifier Name,
            TypeParameterList? TypeParameters,
            Parameters? Parameters,
            CaseTypes? CaseTypes,
            Extended? Extended,
            Satisfied? Satisfied,
            TypeConstraintList? TypeConstraints,
            Expr.Specifier Definition) : Core(Annotations, Name);

        public sealed record Interface(
            Annotations Annotations,
            Identifier Name,
            TypeParameterList? TypeParameters,
            CaseTypes? CaseTypes,
            Satisfied? Satisfied,
            TypeConstraintList? TypeConstraints,
            Expr.Specifier Definition)
        : InterClass(Annotations, Name, TypeParameters, null, CaseTypes, null, Satisfied, TypeConstraints, Definition);

        public sealed record Class(
            Annotations Annotations,
            Identifier Name,
            TypeParameterList? TypeParameters,
            Parameters? Parameters,
            CaseTypes? CaseTypes,
            Extended? Extended,
            Satisfied? Satisfied,
            TypeConstraintList? TypeConstraints,
            Expr.Specifier Definition)
        : InterClass(Annotations, Name, TypeParameters, Parameters, CaseTypes, Extended, Satisfied, TypeConstraints, Definition);

        public sealed record Constructor(
            Annotations Annotations,
            Identifier? Name,
            Parameters Parameters,
            Instantiation? Instantiation,
            Block Definition)
        : Core(Annotations, Name);

        public sealed record Enumerated(
            Annotations Annotations,
            Identifier Name,
            Instantiation? Instantiation,
            Block Definition)
        : Core(Annotations, Name);

        public sealed record Object(
            Annotations Annotations,
            Identifier Name,
            Extended? Extended,
            Satisfied? Satisfied,
            Expr.Specifier Definition)
        : InterClass(Annotations, Name, null, null, null, Extended, Satisfied, null, Definition);

        public abstract record Method(
            Annotations Annotations,
            Identifier Name,
            TypeParameterList? TypeParameters,
            ParametersList Parameters,
            TypeConstraintList? TypeConstraints,
            Expr.Specifier Definition) : Core(Annotations, Name);

        public sealed record TypedMethod(
            Type Type,
            Annotations Annotations,
            Identifier Name,
            TypeParameterList? TypeParameters,
            ParametersList Parameters,
            TypeConstraintList? TypeConstraints,
            Expr.Specifier Definition)
        : Method(Annotations, Name, TypeParameters, Parameters, TypeConstraints, Definition);

        public sealed record VoidMethod(
            Annotations Annotations,
            Identifier Name,
            TypeParameterList? TypeParameters,
            ParametersList Parameters,
            TypeConstraintList? TypeConstraints,
            Expr.Specifier Definition)
        : Method(Annotations, Name, TypeParameters, Parameters, TypeConstraints, Definition);

        public sealed record InferredMethod(
            Annotations Annotations,
            Identifier Name,
            TypeParameterList? TypeParameters,
            ParametersList Parameters,
            TypeConstraintList? TypeConstraints,
            Expr.Specifier Definition)
        : Method(Annotations, Name, TypeParameters, Parameters, TypeConstraints, Definition);

        public abstract record Attribute(
            Annotations Annotations,
            Identifier Name,
            Expr.Specifier Definition) : Core(Annotations, Name);

        public sealed record TypedAttribute(
            Type Type,
            Annotations Annotations,
            Identifier Name,
            Expr.Specifier Definition) : Attribute(Annotations, Name, Definition);

        public sealed record InferredAttribute(
            Annotations Annotations,
            Identifier Name,
            Expr.Specifier Definition) : Attribute(Annotations, Name, Definition);

        public sealed record Setter(
            Annotations Annotations,
            Identifier Name,
            Expr.Specifier Definition) : Attribute(Annotations, Name, Definition);
    }

    public sealed record Declarations(IEnumerable<Decl> Items) : Decl.List(Items);
}

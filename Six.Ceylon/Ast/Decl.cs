﻿namespace Six.Ceylon.Ast
{
    public interface Decl : Stmt, INamed
    {
        string Location { get; }
        Annotations Annotations { get; }

        new public record Core(Annotations Annotations, Identifier Name) : Decl
        {
            public string Location => Name.Location;
        }

        new public abstract record List(IEnumerable<Decl> Items) : ReadOnlyList<Decl>(Items);

        public sealed record Alias(
            Annotations Annotations,
            Identifier Name,
            TypeParameters? TypeParameters,
            TypeConstraints? Constraints,
            Type? Definition)
        : Core(Annotations, Name);

        public abstract record InterClass(
            Annotations Annotations,
            Identifier Name,
            TypeParameters? TypeParameters,
            Parameters? Parameters,
            CaseTypes? CaseTypes,
            Extends? Extends,
            Satisfies? Satisfies,
            TypeConstraints? Constraints,
            Expr.Specifier Definition) : Core(Annotations, Name);

        public sealed record Interface(
            Annotations Annotations,
            Identifier Name,
            TypeParameters? TypeParameters,
            CaseTypes? CaseTypes,
            Satisfies? Satisfies,
            TypeConstraints? Constraints,
            Expr.Specifier Definition)
        : InterClass(Annotations, Name, TypeParameters, null, CaseTypes, null, Satisfies, Constraints, Definition);

        public sealed record Class(
            Annotations Annotations,
            Identifier Name,
            TypeParameters? TypeParameters,
            Parameters? Parameters,
            CaseTypes? CaseTypes,
            Extends? Extends,
            Satisfies? Satisfies,
            TypeConstraints? Constraints,
            Expr.Specifier Definition)
        : InterClass(Annotations, Name, TypeParameters, Parameters, CaseTypes, Extends, Satisfies, Constraints, Definition);

        public sealed record Constructor(
            Annotations Annotations,
            Identifier Name,
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
            Extends? Extends,
            Satisfies? Satisfies,
            Expr.Specifier Definition)
        : InterClass(Annotations, Name, null, null, null, Extends, Satisfies, null, Definition);

        public abstract record Method(
            Annotations Annotations,
            Identifier Name,
            TypeParameters? TypeParameters,
            ParametersList Parameters,
            TypeConstraints? Constraints,
            Expr.Specifier Definition) : Core(Annotations, Name);

        public sealed record TypedMethod(
            Type Type,
            Annotations Annotations,
            Identifier Name,
            TypeParameters? TypeParameters,
            ParametersList Parameters,
            TypeConstraints? Constraints,
            Expr.Specifier Definition)
        : Method(Annotations, Name, TypeParameters, Parameters, Constraints, Definition);

        public sealed record VoidMethod(
            Annotations Annotations,
            Identifier Name,
            TypeParameters? TypeParameters,
            ParametersList Parameters,
            TypeConstraints? Constraints,
            Expr.Specifier Definition)
        : Method(Annotations, Name, TypeParameters, Parameters, Constraints, Definition);

        public sealed record InferredMethod(
            Annotations Annotations,
            Identifier Name,
            TypeParameters? TypeParameters,
            ParametersList Parameters,
            TypeConstraints? Constraints,
            Expr.Specifier Definition)
        : Method(Annotations, Name, TypeParameters, Parameters, Constraints, Definition);

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

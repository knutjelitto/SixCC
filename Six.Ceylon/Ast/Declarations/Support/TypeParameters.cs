using System.Collections.Generic;

namespace Six.Ceylon.Ast
{
    public sealed class TypeParameters : NodeList<TypeParameter>
    {
        public TypeParameters(IEnumerable<TypeParameter> parameters) : base(parameters)
        {
        }
    }

    public sealed class TypeParameter : Node
    {
        public TypeParameter(Variance variance, Name name, TypeDefault? typeDefault)
        {
            Variance = variance;
            Name = name;
            TypeDefault = typeDefault;
        }

        public Variance Variance { get; }
        public Name Name { get; }
        public TypeDefault? TypeDefault { get; }
    }

    public sealed class TypeDefault : Node, Type
    {
        public TypeDefault(Type type)
        {
            Type = type;
        }

        public Type Type { get; }
    }

    public sealed class Variance : Node
    {
        public Variance(VarianceKind kind)
        {
            Kind = kind;
        }

        public VarianceKind Kind { get; }
    }

    public enum VarianceKind
    {
        Invariant,
        Covariant, /* out */
        Contravariant, /* in */
    }

}

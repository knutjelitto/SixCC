using System.Collections.Generic;

namespace Six.Ceylon.Ast
{
    public sealed class TypeArguments : Node
    {
        public TypeArguments(TypeArgumentList items)
        {
            Items = items;
        }

        public TypeArgumentList Items { get; }
    }

    public sealed class TypeArgumentList : NodeList<TypeArgument>
    {
        public TypeArgumentList(IEnumerable<TypeArgument> arguments)
            : base(arguments)
        {
        }
    }

    public sealed class TypeArgument : Node
    {
        public TypeArgument(Variance variance, Type type)
        {
            Variance = variance;
            Type = type;
        }

        public Variance Variance { get; }
        public Type Type { get; }
    }
}

using System.Collections.Generic;

namespace Six.Ceylon.Ast
{
    public sealed class TypeList : NodeList<Type>
    {
        public TypeList(IEnumerable<Type> items, Type? variadic) : base(items)
        {
            Variadic = variadic;
        }

        public Type? Variadic { get; }
    }
}

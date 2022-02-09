﻿using Six.Runtime.Types;

namespace Six.Sax.Ast
{
    public interface Type : IResolveable, TreeNode, Generic.Argument
    {
        public sealed record Union(IRNode Tree, Type Left, Type Right) : Type;
        public sealed record Intersection(IRNode Tree, Type Left, Type Right) : Type;
        public sealed record Constructor(IRNode Tree, Type Type, Arguments Arguments) : Type;
        public sealed record Array(IRNode Tree, Type Type) : Type;
        public sealed record Nullable(IRNode Tree, Type Type) : Type;
        public sealed record ZeroOrMore(IRNode Tree, Type Type) : Type;
        public sealed record OneOrMore(IRNode Tree, Type Type) : Type;
    }

    public sealed record Types(IRNode Tree, IEnumerable<Type> Items) : Many<Type>(Tree, Items);
}

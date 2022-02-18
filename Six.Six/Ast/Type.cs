using Six.Runtime.Types;

namespace Six.Six.Ast
{
    public interface Type : TreeNode
    {
        public sealed record Union(IRNode Tree, IEnumerable<Type> Items)
            : Many<Type>(Tree, Items), Type
        {
            public Union(IRNode tree, params Type[] items) : this(tree, items.AsEnumerable()) { }
        }
        public sealed record Intersection(IRNode Tree, IEnumerable<Type> Items)
            : Many<Type>(Tree, Items), Type;

        public sealed record Nothing(IRNode Tree) : Type;
        public sealed record Spread(IRNode Tree, Type Type) : Type;
        public sealed record Defaulted(IRNode Tree, Type Type) : Type;
        public sealed record Selector(IRNode Tree, Type Type, Reference Reference) : Type;
        public sealed record Callable(IRNode Tree, Type Type, Type Arguments) : Type;
        public sealed record Constructor(IRNode Tree, Type Type, Arguments Arguments) : Type;
        public sealed record Sequence(IRNode Tree, Type Type) : Type;
        public sealed record Nullable(IRNode Tree, Type Type) : Type;
        public sealed record Tuple(IRNode Tree, Types Types) : Type;
        public sealed record Empty(IRNode Tree) : Type;
        public abstract record Variadic(IRNode Tree, Type Type) : Type;
        public sealed record ZeroOrMore(IRNode Tree, Type Type) : Variadic(Tree, Type);
        public sealed record OneOrMore(IRNode Tree, Type Type) : Variadic(Tree, Type);
        public sealed record IterableZeroOrMore(IRNode Tree, Type Type) : Type;
        public sealed record IterableOneOrMore(IRNode Tree, Type Type) : Type;

        public sealed record Types(IRNode Tree, IEnumerable<Type> Items) : Many<Type>(Tree, Items), Type
        {
            public Types(IRNode Tree, params Type[] Items) : this(Tree, Items.AsEnumerable()) { }
        }
    }
}

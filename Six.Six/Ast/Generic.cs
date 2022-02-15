using Six.Runtime.Types;

namespace Six.Six.Ast
{
    public interface Generic : TreeNode
    {
        public record TypeParameter(IRNode Tree, string? Variance, Name Name, Type? Default) : Generic, With.Name;

        public record TypeParameters(IRNode Tree, IEnumerable<TypeParameter> Items)
            : Many<TypeParameter>(Tree, Items);

        public interface TypeArgument : TreeNode { }

        public record TypeArguments(IRNode Tree, IEnumerable<Type> Items)
            : Many<Type>(Tree, Items);

        public sealed record Constraint(
            IRNode Tree, 
            Name Name, 
            TypeParameters? Parameters,
            Type.Types? Cases,
            Type.Types? Satisfies) : Generic;

        public record Constraints(IRNode Tree, IEnumerable<Constraint> Items)
            : Many<Constraint>(Tree, Items);
    }
}

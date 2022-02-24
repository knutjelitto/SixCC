using Six.Runtime.Types;

namespace Six.Six.Ast
{
    public interface Generic : TreeNode
    {
    }

    public interface TypeArgument : TreeNode { }

    public record TypeArguments(IRNode Tree, IEnumerable<Type> Items)
        : Many<Type>(Tree, Items);

    public sealed record TypeConstraint(
        IRNode Tree,
        Name Name,
        TypeParameters? Parameters,
        Type.Types? Cases,
        Type.Types? Satisfies)
        :   Generic,
            With.Name;

    public record TypeConstraints(IRNode Tree, IEnumerable<TypeConstraint> Items)
        : Many<TypeConstraint>(Tree, Items);

    public record TypeParameter(
        IRNode Tree,
        string? Variance,
        Name Name,
        Type? Default)
        : Decl;

    public record TypeParameters(IRNode Tree, IEnumerable<TypeParameter> Items)
        : Many<TypeParameter>(Tree, Items);

}

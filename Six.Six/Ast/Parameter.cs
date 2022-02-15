using Six.Runtime.Types;

namespace Six.Six.Ast
{
    public interface Parameter : Declaration.Entity
    {
    }

    public record ValueParameter(IRNode Tree, Prelude Prelude, Name Name, Type? Type, Expression? Default) : Parameter;

    public record Parameters(IRNode Tree, IEnumerable<Parameter> Items) : Many<Parameter>(Tree, Items)
    {
        public Parameters(IRNode Tree, params Parameter[] items) : this(Tree, items.AsEnumerable()) { }
    }

    public record MultiParameters(IRNode Tree, IEnumerable<Parameters> Items) : Many<Parameters>(Tree, Items);
}

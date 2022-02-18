using Six.Runtime.Types;

namespace Six.Six.Ast
{
    public interface Parameter
        :   Decl, 
            With.Prelude,
            With.Name
    {
    }

    public record ValueParameter(IRNode Tree, Prelude Prelude, Name Name, Type? Type, Expression? Default)
        :   Parameter,
            With.Prelude,
            With.Name,
            With.Type;

    public record DefinitiveParameter(IRNode Tree, Prelude Prelude, Name Name, Type Type)
        :   Parameter,
            With.Prelude,
            With.Name,
            With.Type;

    public record Parameters(IRNode Tree, IEnumerable<Parameter> Items)
        : Many<Parameter>(Tree, Items)
    {
        public Parameters(IRNode Tree, params Parameter[] items) : this(Tree, items.AsEnumerable()) { }
    }

}

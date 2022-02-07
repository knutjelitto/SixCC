using Six.Runtime.Types;

namespace Six.Sax.Ast
{
    public interface Generic : Node
    {
        public record Parameter(IRNode Tree, string? Variance, Name Name) : Generic, INamed;

        public record Parameters(IRNode Tree, IEnumerable<Parameter> Items)
            : Many<Parameter>(Tree, Items);

        public interface Argument : Node { }

        public record Arguments(IRNode Tree, IEnumerable<Argument> Items)
            : Many<Argument>(Tree, Items);

        public sealed record Constraint(
            IRNode Tree, 
            Name Name, 
            Parameters? Parameters,
            Types? Cases,
            Types? Satisfies) : Generic;

        public record Constraints(IRNode Tree, IEnumerable<Constraint> Items)
            : Many<Constraint>(Tree, Items);
    }
}

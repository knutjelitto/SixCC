using Six.Runtime.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Sax.Ast
{
    public interface Generic : Node
    {
        public record Parameter(IRNode Tree, string? Variance, Name Name) : Generic;

        public record Parameters(IRNode Tree, IEnumerable<Parameter> Items)
            : Many<Parameter>(Tree, Items);

#if true
        public interface Argument : Node { }
#else
        public record Argument(IRNode Tree, Type Expression) : Node;
#endif
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

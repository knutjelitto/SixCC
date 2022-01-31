using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Ceylon.Ast
{
    public interface Condition : Expr
    {
        new public sealed record Exists(bool not, Expr expression) : Condition;

        public sealed record Is(bool not, Type type, ConditionVariable variable) : Condition;

        new public sealed record Nonempty(bool not, Expr expression) : Condition;

        public abstract record List(IEnumerable<Expr> Items) : ReadOnlyList<Expr>(Items);
    }

    public sealed record Conditions(IEnumerable<Expr> Items) : Condition.List(Items);
}

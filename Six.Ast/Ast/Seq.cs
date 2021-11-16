using System.Collections.Generic;
using System.Linq;

namespace Six.Ast
{
    public class Seq : Expression
    {
        public Seq(params Expression[] expressions)
        {
            Expressions = expressions.ToList();
        }

        public List<Expression> Expressions { get; }

        public override bool IsAtomic => Expressions.Count == 1 && Expressions[0].IsAtomic;

        public override string ToName() => $"({string.Join("+", Expressions.Select(e => e.ToName()))})";
    }
}

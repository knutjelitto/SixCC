using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixBot.Ast
{
    internal class OneOrMore : Expression
    {
        public OneOrMore(Expression expression)
        {
            Expression = expression;
        }

        public Expression Expression { get; }

        public override bool IsAtomic => Expression.IsAtomic;

        public override string ToName() => $"({Expression.ToName()})+";
    }
}

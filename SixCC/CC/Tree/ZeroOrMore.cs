using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixCC.CC.Tree
{
    internal class ZeroOrMore : Family, Expression
    {
        public ZeroOrMore(Expression expression)
            : base(expression)
        {
            Expression = expression;
        }

        public Expression Expression { get; }
        public override string Head => "*";
    }
}

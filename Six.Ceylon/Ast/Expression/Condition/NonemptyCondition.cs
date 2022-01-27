using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Ceylon.Ast
{
    public class NonemptyCondition : Condition
    {
        public NonemptyCondition(bool not, IExpression expression)
        {
            Not = not;
            Expression = expression;
        }

        public bool Not { get; }
        public IExpression Expression { get; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Ceylon.Ast
{
    public sealed class ReturnStatement : Node, Statement
    {
        public ReturnStatement(Expression? expression)
        {
            Expression = expression;
        }

        public Expression? Expression { get; }
    }
}

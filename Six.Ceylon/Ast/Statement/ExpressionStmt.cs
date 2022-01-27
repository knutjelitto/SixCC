using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Ceylon.Ast
{
    public class ExpressionStmt : Statement
    {
        public ExpressionStmt(IExpression expression)
        {
            Expression = expression;
        }

        public IExpression Expression { get; }
    }
}

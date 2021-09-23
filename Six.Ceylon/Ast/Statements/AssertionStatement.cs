using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Ceylon.Ast
{
    public sealed class AssertionStatement : Node, Statement
    {
        public AssertionStatement(Expression? message, Conditions conditions)
        {
            Message = message;
            Conditions = conditions;
        }

        public Expression? Message { get; }
        public Conditions Conditions { get; }
    }
}

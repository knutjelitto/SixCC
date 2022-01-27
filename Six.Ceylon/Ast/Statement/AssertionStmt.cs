using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Ceylon.Ast
{
    public class AssertionStmt : Statement
    {
        public AssertionStmt(String? message, ConditionList conditions)
        {
            Message = message;
            Conditions = conditions;
        }

        public String? Message { get; }
        public ConditionList Conditions { get; }
    }
}

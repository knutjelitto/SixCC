using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Ceylon.Ast
{
    public class IsCondition : Condition
    {
        public IsCondition(bool not, Typo type, ConditionVariable variable)
        {
            Not = not;
            Type = type;
            Variable = variable;
        }

        public bool Not { get; }
        public Typo Type { get; }
        public ConditionVariable Variable { get; }
    }
}

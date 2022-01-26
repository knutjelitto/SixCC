using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Ceylon.Ast
{
    public class IsCondition : Condition
    {
        public IsCondition(bool not, Type type, Variable variable)
        {
            Not = not;
            Type = type;
            Variable = variable;
        }

        public bool Not { get; }
        public Type Type { get; }
        public Variable Variable { get; }
    }
}

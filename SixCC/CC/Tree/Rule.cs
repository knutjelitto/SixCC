using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixCC.CC.Tree
{
    internal abstract class Rule : Family, Expression
    {
        public Rule(Name name, Expression expression)
            : base(name, expression)
        {
            Name = name;
            Expression = expression;
        }

        public Name Name { get; }
        public Expression Expression { get; }
    }
}

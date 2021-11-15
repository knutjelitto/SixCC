using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixBot.Ast
{
    internal class Reference : Expression
    {
        public Reference(Rule rule)
        {
            Rule = rule;
        }

        public Rule Rule { get; }
        public string Name => Rule.Name;
    }
}

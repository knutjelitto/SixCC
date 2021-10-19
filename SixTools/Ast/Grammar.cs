using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixTools.Ast
{
    public class Grammar
    {
        public Grammar(TermIdentifier name, IEnumerable<Rule> rules)
        {
            Name = name;
            Rules = rules;
        }

        public Grammar(string name, IEnumerable<Rule> rules)
            : this(new TermIdentifier(name), rules)
        {
        }

        public TermIdentifier Name { get; }
        public IEnumerable<Rule> Rules { get; }

        public void Shrink()
        {
            foreach (var rule in Rules)
            {
                rule.Shrink();
            }
        }
    }
}

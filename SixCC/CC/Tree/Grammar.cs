using System.Collections.Generic;
using System.Linq;

namespace SixCC.CC.Tree
{
    internal class Grammar : Family
    {
        public Grammar(Name name, IEnumerable<Rule> rules)
            : base(name, rules)
        {
            Name = name;
            Rules = rules.ToList();
        }

        public Name Name { get; }
        public List<Rule> Rules { get; }
        public override string Head => "grammar";

    }
}

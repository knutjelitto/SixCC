using SixCC.CC.Errors;

namespace SixCC.CC.Structure
{
    internal sealed class Grammar
    {
        private readonly List<Rule> rules = new();
        private readonly Dictionary<string, Rule> index = new();

        public Grammar(string name)
        {
            Name = name;
        }

        public string Name { get; }
        public IReadOnlyList<Rule> Rules => rules;
        public List<string> Symbols => Rules.Where(rule => !rule.IsFragment).Select(rule => rule.Name).ToList();

        public void SetSorted(List<Rule> newRules)
        {
            this.rules.Clear();
            this.rules.AddRange(newRules);
        }

        public void Add(Rule rule)
        {
            if (index.TryGetValue(rule.Name, out var already))
            {
                var (line, column) = already.Location.Source.GetLineAndColumn(already.Location.Offset);
                throw new DiagnosticException(new SyntaxError(rule.Location!, $"rule '{rule.Name}' already defined at ({line},{column})"));
            }
            index.Add(rule.Name, rule);
            rules.Add(rule);
        }

        public Rule Get(Reference reference)
        {
            if (!index.TryGetValue(reference.Text, out var defined))
            {
                throw new DiagnosticException(new SyntaxError(reference.Location, $"rule '{reference.Text}' isn't defined anywhere"));
            }
            return defined;
        }

        public bool TryGet(string key, out Rule? rule)
        {
            if (index.TryGetValue(key, out rule))
            {
                return true;
            }
            rule = null;
            return false;
        }
    }
}

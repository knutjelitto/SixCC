namespace SixTools.Ast
{
    public class Grammar
    {
        public Grammar(TermToken name, IEnumerable<Rule> rules)
        {
            Name = name;
            Rules = rules;
        }

        public Grammar(string name, IEnumerable<Rule> rules)
            : this(new TermToken(name), rules)
        {
        }

        public TermToken Name { get; }
        public IEnumerable<Rule> Rules { get; }

        public void Shrink()
        {
            foreach (var rule in Rules)
            {
                rule.Shrink();
            }
        }

        public void ResolveReference()
        {
            new GrammarReferencer().Walk(this);
        }
    }
}

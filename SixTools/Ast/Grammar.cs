namespace SixTools.Ast
{
    public class Grammar
    {
        public Grammar(TokenTerm name, IEnumerable<Rule> rules)
        {
            Name = name;
            Rules = rules.ToList();
        }

        public Grammar(string name, IEnumerable<Rule> rules)
            : this(new TokenTerm(name), rules)
        {
        }

        public TokenTerm Name { get; }
        public List<Rule> Rules { get; }

        public void Shrink()
        {
            foreach (var rule in Rules)
            {
                rule.Shrink();
            }
        }

        public void Resolve()
        {
            new GrammarReferencer().Walk(this);
        }
    }
}

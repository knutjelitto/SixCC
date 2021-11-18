namespace Six.Ast
{
    public class Grammar
    {
        public Grammar(string name, IEnumerable<Rule> rules)
        {
            Name = name;
            Rules = new UniqueList<string, Rule>(r => r.Name);
            Rules.AddRange(rules);
        }

        public string Name { get; }
        public UniqueList<string, Rule> Rules { get; }
    }
}

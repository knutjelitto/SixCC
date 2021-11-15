namespace SixBot.Ast
{
    internal class Grammar
    {
        public Grammar(string name, Dictionary<string, Rule> index, List<Rule> rules)
        {
            Name = name;
            Index = index;
            Rules = rules;
        }

        public string Name { get; }
        public Dictionary<string, Rule> Index { get; }
        public List<Rule> Rules { get; }
    }
}

namespace SixCC.CC.Tree
{
    internal class Grammar : Family
    {
        public Grammar(Name name, IEnumerable<Rule> rules, IEnumerable<Rule> terminals)
            : base(name, rules)
        {
            Name = name;
            Rules = rules.Concat(terminals).ToList();
        }

        public Name Name { get; }
        public List<Rule> Rules { get; }
        public override string Head => "grammar";

    }
}

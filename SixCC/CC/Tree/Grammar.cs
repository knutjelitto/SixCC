namespace SixCC.CC.Tree
{
    internal class Grammar : Family
    {
        public Grammar(Name name, IEnumerable<Nonterminal> rules, IEnumerable<Nonterminal> terminals)
            : base(name, rules)
        {
            Name = name;
            Rules = rules.Concat(terminals).ToList();
        }

        public Name Name { get; }
        public List<Nonterminal> Rules { get; }
        public override string Head => "grammar";

    }
}

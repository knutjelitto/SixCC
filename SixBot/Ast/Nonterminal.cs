namespace SixBot.Ast
{
    internal class Nonterminal : Base
    {
        public Nonterminal(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public Rule? Rule { get; set; }
    }
}

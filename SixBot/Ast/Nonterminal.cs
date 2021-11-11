namespace SixBot.Ast
{
    internal class Nonterminal : Expression
    {
        public Nonterminal(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public Rule? Rule { get; set; }
    }
}

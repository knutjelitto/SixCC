namespace SixBot.Ast
{
    internal class Reference : Expression 
    {
        public Reference(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public Rule? Rule { get; set; }
    }
}

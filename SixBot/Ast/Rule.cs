namespace SixBot.Ast
{
    internal class Rule
    {
        public Rule(string name, Expression expression)
        {
            Name = name;
            Expression = expression;
        }

        public string Name { get; }
        public Expression Expression { get; }
    }
}

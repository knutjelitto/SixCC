namespace SixBot.Ast
{
    internal class Rule : Expression
    {
        private readonly List<Reference> references = new List<Reference>();

        public Rule(string name, Expression expression)
        {
            Name = name;
            Expression = expression;
        }

        public string Name { get; }
        public Expression Expression { get; set; }

        public Reference Add(Reference reference)
        {
            references.Add(reference);
            return reference;
        }
    }
}

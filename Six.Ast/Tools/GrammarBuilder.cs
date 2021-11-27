namespace Six.Ast
{
    public class GrammarBuilder
    {
        private readonly Grammar grammar;

        public GrammarBuilder()
        {
            grammar = new TreeGrammar(string.Empty);
        }

        public Grammar Grammar(string name)
        {
            Name = name;

            new IsFragmentBuilder().Walk(grammar);

            return grammar;
        }

        public string Name { get => grammar.Name; set => grammar.Name = value; }

        protected virtual void Build()
        {
        }

        public Indefinite Indefinite(ILocation location, string name, Expression expression)
        {
            var symbol = new Indefinite(location, name, expression);
            grammar.Add(symbol);
            return symbol;
        }

        public Expression Sequence(ILocation location, List<Expression> expressions)
        {
            return new Sequence(location, expressions);
        }

        public Expression Alternation(ILocation location, List<Expression> expressions)
        {
            return new Alternation(location, expressions);
        }

        public Expression Reference(ILocation location, string name)
        {
            return new Reference(grammar, location, name);
        }

        public Expression Literal(ILocation location, string text)
        {
            return new Literal(location, text);
        }

        public Expression Not(ILocation location, Expression expression)
        {
            return new NotPredicate(location, expression);
        }

        public Expression And(ILocation location, Expression expression)
        {
            return new AndPredicate(location, expression);
        }

        public Expression Compact(ILocation location, Expression expression)
        {
            return new Compact(location, expression);
        }

        public Expression Range(ILocation location, Expression start, Expression end)
        {
            return new Range(location, start, end);
        }

        public Expression Difference(ILocation location, Expression left, Expression right)
        {
            return new Difference(location, left, right);
        }

        public Expression ZeroOrMore(ILocation location, Expression expression)
        {
            return new ZeroOrMore(location, expression);
        }

        public Expression OneOrMore(ILocation location, Expression expression)
        {
            return new OneOrMore(location, expression);
        }

        public Expression ZeroOrOne(ILocation location, Expression expression)
        {
            return new ZeroOrOne(location, expression);
        }

        public Expression Any(ILocation location) => new Any(location);

        public Expression Epsilon(ILocation location) => new Sequence(location);
    }
}

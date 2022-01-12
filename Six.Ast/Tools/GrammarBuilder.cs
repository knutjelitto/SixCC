namespace Six.Ast
{
    public class GrammarBuilder
    {
        private readonly AstGrammar grammar;

        public GrammarBuilder()
        {
            grammar = new AstGrammar(string.Empty);
        }

        public AstGrammar Grammar(string name)
        {
            Name = name;

            return grammar;
        }

        public string Name { get => grammar.Name; set => grammar.Name = value; }

        protected virtual void Build()
        {
        }

        public AstSymbol Indefinite(ILocation location, string name, Expression expression)
        {
            var symbol = new AstSymbol(location, name, expression);
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

        public Expression Token(ILocation location, Expression expression)
        {
            return new Token(location, expression);
        }

        public Expression Range(ILocation location, Expression start, Expression end)
        {
            return new Range(location, start, end);
        }

        public Expression Diff(ILocation location, Expression left, Expression right)
        {
            return new Diff(location, left, right);
        }

        public Expression Complement(ILocation location, Expression expression)
        {
            return new Diff(location, Any(location), expression);
        }

        public Expression Not(ILocation location, Expression expression)
        {
            return new Not(location, expression);
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

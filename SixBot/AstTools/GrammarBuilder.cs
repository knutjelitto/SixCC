namespace SixBot.Ast
{
    internal abstract class GrammarBuilder
    {
        private readonly List<Rule> rules = new();
        private readonly Dictionary<string, Rule> index = new();

        protected GrammarBuilder(string name)
        {
            Name = name;
        }

        private string Name { get; }

        public Grammar Grammar()
        {
            Build();

            foreach (var rule in index.Values.Where(r => r.Expression is Undefined))
            {
                rules.Add(rule);
            }
            Assert(rules.Count >= index.Count);


            return new Grammar(Name, index, rules);
        }

        protected abstract void Build();

        private Rule Rule(string name)
        {
            if (!index.TryGetValue(name, out var rule))
            {
                rule = new Rule(name, Undefined.Instance);
                index.Add(rule.Name, rule);
            }

            return rule;
        }

        protected void Rule(string name, Expression expression)
        {
            var rule = Rule(name);
            if (rule.Expression is Undefined)
            {
                rules.Add(rule);
            }
            rule.Expression = expression;
        }

        protected Reference N(string name)
        {
            var rule = Rule(name);
            return rule.Add(new Reference(Rule(name)));
        }

        protected static Terminal T(string literal)
        {
            return new Terminal(new CpString(literal));
        }

        protected static Terminal T(char literal)
        {
            return new Terminal(new CpString(literal));
        }

        protected static Terminal T(int literal)
        {
            return new Terminal(new CpString(literal));
        }

        protected static Terminal T(Expression expression)
        {
            return new Terminal(expression);
        }

        protected static Terminal Range(Expression start, Expression end)
        {
            return new Terminal(new Range(start, end));
        }

        protected static Terminal Range(int start, int end)
        {
            return new Terminal(new Range(T(start), T(end)));
        }

        protected static Epsilon Empty => Epsilon.Instance;
    }
}

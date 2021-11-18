namespace Six.Ast
{
    public class GrammarBuilder
    {
        private readonly UniqueList<string, Rule> rules = new UniqueList<string, Rule>(r => r.Name);

        public GrammarBuilder()
        {
            RuleOrder = 0;
        }

        private int RuleOrder { get; set; }

        public Grammar Grammar(string name)
        {
            Build();

            var x = new List<Rule>();

            x.AddRange(rules.Where(r => r.Kind == RuleKind.Defined).OrderBy(r => r.Order));
            x.AddRange(rules.Where(r => r.Kind == RuleKind.Undefined));
            x.AddRange(rules.Where(r => r.Kind == RuleKind.Artifical).OrderBy(r => r.Name));
            rules.Clear();
            rules.AddRange(x);

            var grammar = new Grammar(name, rules);

            new IsRegexWalker().Walk(grammar);
            new IsFragmentWalker().Walk(grammar);

            grammar.Dump($"{grammar.Name}-dump.txt");

            return grammar;
        }

        protected virtual void Build()
        {
        }

        private Rule FindOrCreateRule(ILocation? location, string name)
        {
            if (!rules.TryGetValue(name, out var rule))
            {
                rule = new Rule(location, name, new Undefined(location))
                {
                    Kind = RuleKind.Undefined
                };
                rules.Add(rule);
            }

            return rule;
        }

        public Expression Seq(ILocation? location, List<Expression> expressions)
        {
            Assert(expressions.Count >= 0);
            if (expressions.Count == 0)
            {
                return new Seq(location);
            }
            else if (expressions.Count == 1)
            {
                return expressions.Single();
            }
            else
            {
                return new Seq(location, expressions);
            }
        }

        public Expression Alt(ILocation? location, List<Expression> expressions)
        {
            Assert(expressions.Count >= 1);
            if (expressions.Count > 1)
            {
                return new Alt(location, expressions);
            }
            else
            {
                return expressions.Single();
            }
        }

        public Rule Rule(ILocation location, string name, Expression expression)
        {
            var rule = FindOrCreateRule(location, name);
            rule.Order = RuleOrder++;
            rule.Kind = RuleKind.Defined;
            rule.Expression = expression;

            return rule;
        }

        public Reference Ref(ILocation location, string name)
        {
            var rule = FindOrCreateRule(location, name);
            return rule.Add(new Reference(location, rule));
        }

        public Expression Literal(ILocation location, string literal, string payload)
        {
            return new Literal(location, payload);
        }

        public Expression Compact(ILocation? location, Expression expression)
        {
            return new Compact(location, expression);
        }

        public Expression Range(ILocation? location, Expression start, Expression end)
        {
            return new Range(location, start, end);
        }

        public Expression Difference(ILocation? location, Expression left, Expression right)
        {
            return new Difference(location, left, right);
        }

        public Expression ZeroOrMore(ILocation? location, Expression expression)
        {
            return new ZeroOrMore(location, expression);
        }

        public Expression OneOrMore(ILocation? location, Expression expression)
        {
            return new OneOrMore(location, expression);
        }

        public Expression ZeroOrOne(ILocation? location, Expression expression)
        {
            return new ZeroOrOne(location, expression);
        }

        public Expression Any(ILocation location) => new Any(location);

        public Expression Epsilon() => new Seq(null);

        public Expression Epsilon(ILocation location) => new Seq(location);
    }
}

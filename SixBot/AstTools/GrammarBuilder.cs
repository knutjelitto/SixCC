using System.Xml.Linq;

namespace SixBot.Ast
{
    internal abstract class GrammarBuilder
    {
        private readonly UniqueList<string, Rule> rules = new(r => r.Name);

        protected GrammarBuilder(string name)
        {
            Name = name;
            RuleOrder = 0;
        }

        private string Name { get; }
        private int RuleOrder { get; set; }

        public Grammar Grammar()
        {
            Build();

            var x = new List<Rule>();

            x.AddRange(rules.Where(r => r.Kind == RuleKind.Defined).OrderBy(r => r.Order));
            x.AddRange(rules.Where(r => r.Kind == RuleKind.Undefined));
            x.AddRange(rules.Where(r => r.Kind == RuleKind.Artifical).OrderBy(r => r.Name));
            rules.Clear();
            rules.AddRange(x);

            return new Grammar(Name, rules);
        }

        protected abstract void Build();

        private Rule Rule(string name)
        {
            if (!rules.TryGetValue(name, out var rule))
            {
                rule = new Rule(name, Undefined.Instance);
                rule.Kind = RuleKind.Undefined;
                rules.Add(rule);
            }

            return rule;
        }

        protected void Define(string name, Expression expression)
        {
            var rule = Rule(name);
            rule.Order = RuleOrder++;
            rule.Kind = RuleKind.Defined;
            rule.Expression = expression;
        }

        protected Reference Ref(string name)
        {
            var rule = Rule(name);
            return rule.Add(new Reference(rule));
        }

        private Reference TerminalRef(Terminal terminal)
        {
            if (!rules.TryGetValue(terminal.ToName(), out var rule))
            {
                rule = Rule(terminal.ToName());
                rule.Kind = RuleKind.Artifical;
                rule.Expression = terminal;
            }
            return rule.Add(new Reference(rule));
        }

        protected Expression T(string literal)
        {
#if true
            return new Literal(literal);
#else
            return TerminalRef(new Literal(literal));
#endif
        }

        protected Expression T(char literal)
        {
#if true
            return new Literal(literal);
#else
            return TerminalRef(new Literal(literal));
#endif
        }

        protected Expression T(int literal)
        {
#if true
            return new Literal(literal);
#else
            return TerminalRef(new Literal(literal));
#endif
        }

        protected static Expression Forced(Expression expression)
        {
            return new Compact(expression);
        }

        protected Expression Range(int start, int end)
        {
            Assert(start >= 0 && start <= 0x10FFFF && end >= 0 && end <= 0x10FFFF && start <= end);
            if (start == end)
            {
                return new Literal(start);
            }
            return new Range(new Literal(start), new Literal(end));
        }

        protected static Expression Star(Expression expression)
        {
            return new ZeroOrMore(expression);
        }

        protected static Expression Plus(Expression expression)
        {
            return new OneOrMore(expression);
        }

        protected static Expression Opt(Expression expression)
        {
            return new ZeroOrOne(expression);
        }

        protected static Epsilon Empty => Epsilon.Instance;

        protected static Any Any => Any.Instance;
    }
}

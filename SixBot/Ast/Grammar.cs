namespace SixBot.Ast
{
    internal class Grammar
    {
        public Grammar(string name, params Rule[] rules)
        {
            Rules = rules.ToList();
            Lookup = Rules.ToDictionary(x => x.Name, x => x);
            Resolve();
            Name = name;
        }

        public string Name { get; }

        public List<Rule> Rules { get; }
        public Dictionary<string, Rule> Lookup { get; }

        private void Resolve()
        {
            foreach (var rule in Rules)
            {
                Resolve(rule.Expression);
            }

            void Resolve(Expression expression)
            {
                switch (expression)
                {
                    case Alt alt:
                        foreach (var aExpression in alt.Expressions)
                        {
                            Resolve(aExpression);
                        }
                        break;
                    case Seq seq:
                        foreach (var sExpression in seq.Expressions)
                        {
                            Resolve(sExpression);
                        }
                        break;
                    case Nonterminal reference:
                        reference.Rule = Lookup[reference.Name];
                        break;
                }
            }
        }
    }
}

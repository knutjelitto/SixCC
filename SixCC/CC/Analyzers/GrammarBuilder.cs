using SixCC.Sdk.Ebnf;

namespace SixCC.CC.Analyzers
{
    internal sealed class GrammarBuilder : TreeVisitor
    {
        private readonly List<Rule> rules = new();

        public Grammar Build(Tree.Grammar tree)
        {
            rules.Clear();

            Visit(tree);

            var name = Get<string>(tree.Name);

            var grammar = new Grammar(name);

            foreach (var rule in rules)
            {
                grammar.Add(rule);
            }

            Resolve(grammar);
            IsTerminal(grammar);
            BuildInlineTerminals(grammar);
            Numbering(grammar);

            return grammar;
        }

        protected override void Visit(Tree.Grammar grammar)
        {
            base.Visit(grammar);
        }

        protected override void Visit(Tree.Rule tree)
        {
            base.Visit(tree);

            var rule = new Rule(tree.Location, Get<string>(tree.Name), Get<Symbol>(tree.Expression));
            rules.Add(rule);
            Set(tree, rule);
        }

        protected override void Visit(Tree.Alt tree)
        {
            base.Visit(tree);

            Set(tree, new Alternative(tree.Location, GetMany<Symbol>(tree)));
        }

        protected override void Visit(Tree.Cat tree)
        {
            base.Visit(tree);

            Set(tree, new Sequence(tree.Location, GetMany<Symbol>(tree)));
        }

        protected override void Visit(Tree.Any tree)
        {
            Set(tree, new Any(tree.Location));
        }

        protected override void Visit(Tree.Epsilon tree)
        {
            Set(tree, new Epsilon(tree.Location));
        }

        protected override void Visit(Tree.Difference tree)
        {
            base.Visit(tree);

            var left = Get<Symbol>(tree.Left);
            var right = Get<Symbol>(tree.Right);
            Set(tree, new Difference(tree.Location, left, right));
        }

        protected override void Visit(Tree.Literal tree)
        {
            Set(tree, new Literal(tree.Location, tree.Text));
        }

        protected override void Visit(Tree.Name tree)
        {
            Set(tree, tree.Text);
        }

        protected override void Visit(Tree.Range tree)
        {
            base.Visit(tree);

            var left = Get<Literal>(tree.Left);
            var right = Get<Literal>(tree.Right);
            Set(tree, new Sdk.Ebnf.Range(tree.Location, left, right));
        }

        protected override void Visit(Tree.Reference tree)
        {
            Set(tree, new Reference(tree.Location, tree.Text));
        }

        protected override void Visit(Tree.OneOrMore tree)
        {
            base.Visit(tree);

            Set(tree, new OneOrMore(tree.Location, Get<Symbol>(tree.Expression)));
        }

        protected override void Visit(Tree.ZeroOrMore tree)
        {
            base.Visit(tree);

            Set(tree, new ZeroOrMore(tree.Location, Get<Symbol>(tree.Expression)));
        }

        protected override void Visit(Tree.ZeroOrOne tree)
        {
            base.Visit(tree);

            Set(tree, new ZeroOrOne(tree.Location, Get<Symbol>(tree.Expression)));
        }

        protected override void Visit(Tree.Complement tree)
        {
            base.Visit(tree);

            Set(tree, new Complement(tree.Location, Get<Symbol>(tree.Expression)));
        }

        private static void BuildInlineTerminals(Grammar grammar)
        {
            foreach (var rule in grammar.Rules.Where(rule => rule.IsNonterminal).ToList())
            {
                Build(rule, rule.Symbol);
            }

            bool IsTerminalRule(Rule inRule, Symbol symbol, out Rule? rule)
            {
                if (symbol.IsTerminal && symbol is not Rule)
                {
                    Debug.Assert(!symbol.IsFragment);
                    var key = symbol.Key;
                    if (!grammar.TryGet(key, out rule))
                    {
                        rule = new Rule(symbol.Location, key, symbol)
                        {
                            IsTerminal = true
                        };
                        grammar.Add(rule);
                    }
                    rule!.Usages.Add(inRule);
                    return true;
                }
                rule = null;
                return false;
            }

            Symbol Build(Rule inRule, Symbol symbol)
            {
                if (IsTerminalRule(inRule, symbol, out var rule))
                {
                    Debug.Assert(rule != null);
                    return rule!;
                }
                switch (symbol)
                {
                    case Alternative alternation:
                        for (var i = 0; i < alternation.Sequences.Count; i += 1)
                        {
                            alternation.Sequences[i] = Build(inRule, alternation.Sequences[i]);
                        }
                        return symbol;
                    case Sequence sequence:
                        for (var i = 0; i < sequence.Symbols.Count; ++i)
                        {
                            sequence.Symbols[i] = Build(inRule, sequence.Symbols[i]);
                        }
                        return symbol;
                    case Complement complement:
                        complement.Symbol = Build(inRule, complement.Symbol);
                        return symbol;
                    case ZeroOrOne zeroOrOne:
                        zeroOrOne.Symbol = Build(inRule, zeroOrOne.Symbol);
                        return symbol;
                    case ZeroOrMore zeroOrMore:
                        zeroOrMore.Symbol = Build(inRule, zeroOrMore.Symbol);
                        return symbol;
                    case OneOrMore oneOrMore:
                        oneOrMore.Symbol = Build(inRule, oneOrMore.Symbol);
                        return symbol;
                    case Difference difference:
                        difference.Left = Build(inRule, difference.Left);
                        difference.Right = Build(inRule, difference.Right);
                        return symbol;
                    default:
                        return symbol;
                }
            }
        }

        private static void Numbering(Grammar grammar)
        {
            int number = 0;
            var sorted = new List<Rule>();

            foreach (var rule in grammar.Rules.Where(rule => !rule.IsTerminal && !rule.IsFragment))
            {
                rule.Number = number++;
                sorted.Add(rule);
            }

            foreach (var rule in grammar.Rules.Where(rule => rule.IsTerminal && !rule.IsFragment))
            {
                rule.Number = number++;
                sorted.Add(rule);
            }

            foreach (var rule in grammar.Rules.Where(rule => rule.IsTerminal && rule.IsFragment))
            {
                rule.Number = number++;
                sorted.Add(rule);
            }

            grammar.SetSorted(sorted);
        }

        private static void Resolve(Grammar grammar)
        {
            foreach (var rule in grammar.Rules)
            {
                rule.Symbol = Resolve(rule, rule.Symbol);
            }

            Symbol Resolve(Rule rule, Symbol symbol)
            {
                switch (symbol)
                {
                    case Reference reference:
                        var resolved = grammar.Get(reference);
                        resolved.Usages.Add(rule);
                        return resolved;
                    case Alternative alternation:
                        for (var i = 0; i < alternation.Sequences.Count; i += 1)
                        {
                            alternation.Sequences[i] = Resolve(rule, alternation.Sequences[i]);
                        }
                        return symbol;
                    case Sequence sequence:
                        for (var i = 0; i < sequence.Symbols.Count; ++i)
                        {
                            sequence.Symbols[i] = Resolve(rule, sequence.Symbols[i]);
                        }
                        return symbol;
                    case Complement complement:
                        complement.Symbol = Resolve(rule, complement.Symbol);
                        return symbol;
                    case OneOrMore oneOrMore:
                        oneOrMore.Symbol = Resolve(rule, oneOrMore.Symbol);
                        return symbol;
                    case ZeroOrMore zeroOrMore:
                        zeroOrMore.Symbol = Resolve(rule, zeroOrMore.Symbol);
                        return symbol;
                    case ZeroOrOne zeroOrOne:
                        zeroOrOne.Symbol = Resolve(rule, zeroOrOne.Symbol);
                        return symbol;
                    case Sdk.Ebnf.Range range:
                        range.Left = (Literal)Resolve(rule, range.Left);
                        range.Right = (Literal)Resolve(rule, range.Right);
                        return symbol;
                    case Difference difference:
                        difference.Left = Resolve(rule, difference.Left);
                        difference.Right = Resolve(rule, difference.Right);
                        return symbol;
                    default:
                        return symbol;
                }
            }
        }

        private static void Update(ref bool changed, ref bool changee, bool value)
        {
            if (changee != value)
            {
                changed = true;
            }
            changee = value;
        }

        private static void IsTerminal(Grammar grammar)
        {
            var changed = true;

            while (changed)
            {
                changed = false;

                foreach (var rule in grammar.Rules)
                {
                    Terminal(rule.Symbol);

                    Update(ref changed, ref rule.IsTerminal, rule.Symbol.IsTerminal);
                }
            }

            grammar.Rules[0].IsNonterminal = true;
            grammar.Rules[0].IsTerminal = false;
            grammar.Rules[0].IsFragment = false;


            foreach (var rule in grammar.Rules.Where(r => r.IsTerminal))
            {
                rule.IsFragment = rule.Usages.All(usage => usage.IsTerminal || usage.IsFragment);
            }

            foreach (var rule in grammar.Rules.Where(rule => !rule.IsTerminal))
            {
                rule.IsNonterminal = true;
            }

            void Terminal(Symbol symbol)
            {
                switch (symbol)
                {
                    case Alternative alternation:
                        foreach (var sequence in alternation.Sequences)
                        {
                            Terminal(sequence);
                        }
                        Update(ref changed, ref alternation.IsTerminal, alternation.Sequences.All(sequence => sequence.IsTerminal));
                        break;
                    case Sequence sequence:
                        if (sequence.Symbols.Count > 0)
                        {
                            foreach (var sym in sequence.Symbols)
                            {
                                Terminal(sym);
                            }
                            Update(ref changed, ref sequence.IsTerminal, sequence.Symbols.All(symbol => symbol.IsTerminal));
                        }
                        break;
                    case Difference difference:
                        Terminal(difference.Left);
                        Terminal(difference.Right);
                        Update(ref changed, ref difference.IsTerminal, difference.Left.IsTerminal && difference.Right.IsTerminal);
                        break;
                    case OneOrMore oneOrMore:
                        Terminal(oneOrMore.Symbol);
                        Update(ref changed, ref oneOrMore.IsTerminal, oneOrMore.Symbol.IsTerminal);
                        break;
                    case Complement complement:
                        Terminal(complement.Symbol);
                        Update(ref changed, ref complement.IsTerminal, complement.Symbol.IsTerminal);
                        break;
                    case ZeroOrMore zeroOrMore:
                        Terminal(zeroOrMore.Symbol);
                        Update(ref changed, ref zeroOrMore.IsTerminal, zeroOrMore.Symbol.IsTerminal);
                        break;
                    case ZeroOrOne zeroOrOne:
                        Terminal(zeroOrOne.Symbol);
                        Update(ref changed, ref zeroOrOne.IsTerminal, zeroOrOne.Symbol.IsTerminal);
                        break;
                }
            }
        }
    }
}

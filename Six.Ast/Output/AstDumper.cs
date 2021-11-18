namespace Six.Ast
{
    internal class AstDumper : Walker
    {
        private readonly Writer writer;

        public AstDumper(Writer writer)
        {
            this.writer = writer;
        }

        private void Clamped(Expression expression, string suffix)
        {
            if (!expression.IsAtomic)
                writer.Write("(");
            Walk(expression);
            if (!expression.IsAtomic)
                writer.Write(")");
            writer.Write(suffix);
        }

        protected override void Visit(Grammar grammar)
        {
            var more = false;
            foreach (var rule in grammar.Rules)
            {
                if (more)
                {
                    writer.WriteLine();
                }
                more = true;
                Walk(rule);
            }

            writer.WriteLine();
            writer.WriteLine($"/*");
            writer.WriteLine();
            Sorts(grammar, "nonterminal", r => !(r.IsCompact || r.IsFragment));
            writer.WriteLine();
            Sorts(grammar, "terminals", r => r.IsCompact && !r.IsFragment);
            writer.WriteLine();
            Sorts(grammar, "fragments", r => r.IsFragment);
            writer.WriteLine();
            writer.WriteLine($"*/");
        }

        private void Sorts(Grammar grammar, string what, Func<Rule, bool> predicate)
        {
            var more = false;
            writer.WriteLine($"=== {what}");
            using (writer.Indent())
            {
                foreach (var rule in grammar.Rules.Where(r => predicate(r)))
                {
                    WhenMore(ref more, () => writer.Write(" "));
                    writer.Write($"{rule.Name}");
                }
            }
            if (more)
            {
                writer.WriteLine();
            }
        }

        private void WhenMore(ref bool more, Action whenMore)
        {
            if (more)
            {
                whenMore();
            }
            else
            {
                more = true;
            }
        }

        protected override void Visit(Rule rule)
        {
            writer.Write($"{rule.Name}:");
            writer.Write(new string(' ', Math.Max(1, 20 - rule.Name.Length)));
            writer.Write("// [");
            writer.Write($"{rule.References.Count}");
            writer.Write("," + (rule.IsRegex ? "R" : "-"));
            writer.Write("," + (rule.IsFragment ? "F" : "-"));
            writer.Write("]");
            using (writer.Indent())
            {
                if (rule.Expression is Alt alt && alt.Expressions.Count >= 2)
                {
                    var more = false;
                    foreach (var sub in alt.Expressions)
                    {
                        writer.WriteLine();
                        if (more)
                        {
                            writer.Write("| ");
                        }
                        else
                        {
                            writer.Write("  ");
                            more = true;
                        }
                        Walk(sub);
                    }
                }
                else
                {
                    writer.WriteLine();
                    Walk(rule.Expression);
                }
                writer.WriteLine();
                writer.WriteLine(";");
            }
        }

        private void Loop(IEnumerable<Expression> expressions, Action whenMore)
        {
            var more = false;
            foreach (var expression in expressions)
            {
                WhenMore(ref more, whenMore);
                Walk(expression);
            }
        }

        protected override void Visit(Alt alt)
        {
            writer.Write(alt.IsAtomic ? "" : "(");
            Loop(alt.Expressions, () => writer.Write(" | "));
            writer.Write(alt.IsAtomic ? "" : ")");
        }

        protected override void Visit(Seq seq)
        {
            if (seq.Expressions.Count == 0)
            {
                writer.Write("ε");
            }
            else
            {
                Loop(seq.Expressions, () => writer.Write(" "));
            }
        }

        protected override void Visit(ZeroOrMore zeroOrMore)
        {
            Clamped(zeroOrMore.Expression, "*");
        }

        protected override void Visit(ZeroOrOne zeroOrOne)
        {
            Clamped(zeroOrOne.Expression, "?");
        }

        protected override void Visit(OneOrMore oneOrMore)
        {
            Clamped(oneOrMore.Expression, "+");
        }

        protected override void Visit(Reference reference)
        {
            writer.Write($"{reference.Name}");
        }

        protected override void Visit(Compact terminal)
        {
            writer.Write("< ");
            Walk(terminal.Expression);
            writer.Write(" >");
        }

        protected override void Visit(Literal literal)
{
            writer.Write($"{literal.Text.Esc()}");
        }

        protected override void Visit(Set range)
        {
            writer.Write($"{range}");
        }

        protected override void Visit(Range range)
        {
            Walk(range.Start);
            writer.Write(" .. ");
            Walk(range.End);
        }

        protected override void Visit(Difference substract)
        {
            writer.Write("(");
            Walk(substract.Left);
            writer.Write(" - ");
            Walk(substract.Right);
            writer.Write(")");
        }

        protected override void Visit(Undefined undefined)
        {
            writer.Write($"<--[undefined]-->");
        }

        protected override void Visit(Any any)
        {
            writer.Write(".");
        }
    }
}

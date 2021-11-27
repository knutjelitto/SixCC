namespace Six.Ast
{
    internal class AstDumper : Walker
    {
        private readonly Writer writer;

        public AstDumper(Writer writer)
        {
            this.writer = writer;
        }

        private void Clamped(Expression expression, string prefix = "", string suffix = "")
        {
            writer.Write(prefix);
            if (!expression.IsSimple)
                writer.Write("(");
            Walk(expression);
            if (!expression.IsSimple)
                writer.Write(")");
            writer.Write(suffix);
        }

        protected override void Visit(Grammar grammar)
        {
            var more = false;
            foreach (var symbol in grammar.Symbols)
            {
                if (more)
                {
                    writer.WriteLine();
                }
                more = true;
                Walk(symbol);
            }

            writer.WriteLine();
            writer.WriteLine($"/*");
            writer.WriteLine();
            Sorts("nonterminals", grammar.Nonterminals());
            writer.WriteLine();
            Sorts("terminals", grammar.Terminals());
            writer.WriteLine();
            Sorts("fragments", grammar.Fragments());
            writer.WriteLine();
            writer.WriteLine($"*/");
        }

        private void Sorts(string what, IEnumerable<Symbol> symbols)
        {
            writer.WriteLine($"=== {what}");
            using (writer.Indent())
            {
                foreach (var symbol in symbols)
                {
                    writer.WriteLine($"{symbol.Name}");
                }
            }
        }

        private void WhenMore(ref bool more, Action whenMore, Action? whenNotMore = null)
        {
            if (more)
            {
                whenMore.Invoke();
            }
            else
            {
                whenNotMore?.Invoke();
                more = true;
            }
        }

        protected override void Visit(Symbol symbol)
        {
            writer.Write($"{symbol.Name}");
            writer.Write(new string(' ', Math.Max(1, 20 - symbol.Name.Length)));
            writer.Write("// [");
            writer.Write((symbol.IsFragment ? "F" : "-"));
            writer.Write("]");
            using (writer.Indent())
            {
                if (symbol.Expression is Alternation alt && alt.Expressions.Count >= 1)
                {
                    var more = false;
                    foreach (var sub in alt.Expressions)
                    {
                        writer.WriteLine();
                        WhenMore(ref more, () => writer.Write("| "), () => writer.Write(": "));
                        Walk(sub);
                    }
                }
                else
                {
                    writer.WriteLine();
                    Walk(symbol.Expression);
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

        protected override void Visit(Alternation alt)
        {
            writer.Write(alt.IsSimple ? "" : "(");
            Loop(alt.Expressions, () => writer.Write(" | "));
            writer.Write(alt.IsSimple ? "" : ")");
        }

        protected override void Visit(Sequence seq)
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
            Clamped(zeroOrMore.Expression, suffix: "*");
        }

        protected override void Visit(ZeroOrOne zeroOrOne)
        {
            Clamped(zeroOrOne.Expression, suffix: "?");
        }

        protected override void Visit(OneOrMore oneOrMore)
        {
            Clamped(oneOrMore.Expression, suffix: "+") ;
        }

        protected override void Visit(NotPredicate not)
        {
            Clamped(not.Expression, prefix: "!");
        }

        protected override void Visit(AndPredicate and)
        {
            Clamped(and.Expression, prefix: "&");
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

        protected override void Visit(Range range)
        {
            Walk(range.One);
            writer.Write(" .. ");
            Walk(range.Two);
        }

        protected override void Visit(Difference substract)
        {
            writer.Write("(");
            Walk(substract.One);
            writer.Write(" - ");
            Walk(substract.Two);
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

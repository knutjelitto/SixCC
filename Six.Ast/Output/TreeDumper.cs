namespace Six.Ast
{
    public class TreeDumper : Walker
    {
        private readonly Writer writer;

        public TreeDumper(Writer writer)
        {
            this.writer = writer;
        }

        protected override void Visit(AstGrammar grammar)
        {
            var more = false;
            foreach (var rule in grammar.Symbols)
            {
                if (more)
                {
                    writer.WriteLine();
                }
                more = true;
                Walk(rule);
            }
        }

        protected override void Visit(Symbol symbol)
        {
            writer.WriteLine($"{symbol}");
            using (writer.Indent())
            {
                base.Visit(symbol);
            }
        }

        protected override void Visit(Alternation alt)
        {
            writer.WriteLine("alternation");
            using (writer.Indent())
            {
                base.Visit(alt);
            }
        }

        protected override void Visit(Sequence seq)
        {
            writer.WriteLine("sequence");
            using (writer.Indent())
            {
                base.Visit(seq);
            }
        }

        protected override void Visit(Token compact)
        {
            writer.WriteLine("compact");
            using (writer.Indent())
            {
                base.Visit(compact);
            }
        }

        protected override void Visit(OneOrMore oneOrMore)
        {
            writer.WriteLine("one-or-more");
            using (writer.Indent())
            {
                base.Visit(oneOrMore);
            }
        }

        protected override void Visit(ZeroOrMore zeroOrMore)
        {
            writer.WriteLine("zero-or-more");
            using (writer.Indent())
            {
                base.Visit(zeroOrMore);
            }
        }

        protected override void Visit(ZeroOrOne zeroOrOne)
        {
            writer.WriteLine("zero-or-one");
            using (writer.Indent())
            {
                base.Visit(zeroOrOne);
            }
        }

        protected override void Visit(NotPredicate not)
        {
            writer.WriteLine("not");
            using (writer.Indent())
            {
                base.Visit(not);
            }
        }

        protected override void Visit(AndPredicate and)
        {
            writer.WriteLine("and");
            using (writer.Indent())
            {
                base.Visit(and);
            }
        }

        protected override void Visit(Reference reference)
        {
            writer.WriteLine($"→{reference.Name}");
            base.Visit(reference);
        }

        protected override void Visit(Any any)
        {
            writer.WriteLine("any");
        }

        protected override void Visit(Literal literal)
        {
            writer.WriteLine(literal.Text.Esc());
        }

        protected override void Visit(Range range)
        {
            writer.WriteLine("range");
            using (writer.Indent())
            {
                base.Visit(range);
            }
        }
    }
}

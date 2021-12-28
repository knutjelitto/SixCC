namespace Six.Ast
{
    public class AstDumper : Walker
    {
        public AstDumper(Writer writer, AstGrammar grammar)
        {
            Writer = writer;
            Grammar = grammar;
        }

        public Writer Writer { get; }
        public AstGrammar Grammar { get; }

        public void Dump()
        {
            Walk(Grammar);
        }

        protected override void Visit(AstGrammar grammar)
        {
            var more = false;
            foreach (var rule in grammar.Symbols)
            {
                if (more)
                {
                    Writer.WriteLine();
                }
                more = true;
                Walk(rule);
            }
        }

        protected override void Visit(Symbol symbol)
        {
            Writer.WriteLine($"{symbol}");
            using (Writer.Indent())
            {
                base.Visit(symbol);
            }
        }

        protected override void Visit(Alternation alt)
        {
            Writer.WriteLine("alternation");
            using (Writer.Indent())
            {
                base.Visit(alt);
            }
        }

        protected override void Visit(Sequence seq)
        {
            Writer.WriteLine("sequence");
            using (Writer.Indent())
            {
                base.Visit(seq);
            }
        }

        protected override void Visit(Token compact)
        {
            Writer.WriteLine("compact");
            using (Writer.Indent())
            {
                base.Visit(compact);
            }
        }

        protected override void Visit(OneOrMore oneOrMore)
        {
            Writer.WriteLine("one-or-more");
            using (Writer.Indent())
            {
                base.Visit(oneOrMore);
            }
        }

        protected override void Visit(ZeroOrMore zeroOrMore)
        {
            Writer.WriteLine("zero-or-more");
            using (Writer.Indent())
            {
                base.Visit(zeroOrMore);
            }
        }

        protected override void Visit(ZeroOrOne zeroOrOne)
        {
            Writer.WriteLine("zero-or-one");
            using (Writer.Indent())
            {
                base.Visit(zeroOrOne);
            }
        }

        protected override void Visit(Reference reference)
        {
            Writer.WriteLine($"→{reference.Name}");
            base.Visit(reference);
        }

        protected override void Visit(Any any)
        {
            Writer.WriteLine("any");
        }

        protected override void Visit(Literal literal)
        {
            Writer.WriteLine(literal.Text.Esc());
        }

        protected override void Visit(Range range)
        {
            Writer.WriteLine("range");
            using (Writer.Indent())
            {
                base.Visit(range);
            }
        }
    }
}

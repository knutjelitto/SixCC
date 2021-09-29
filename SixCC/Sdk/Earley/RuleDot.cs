using SixCC.Sdk.Ebnf;
using SixCC.Writing;

namespace SixCC.Sdk.Earley
{
    public class RuleDot
    {
        private int nodeCount = 0;

        public RuleDot(Writer writer, Rule rule)
        {
            Writer = writer;
            Rule = rule;
        }

        public Writer Writer { get; }
        public Rule Rule { get; }

        public void Dot()
        {
            Writer.WriteLine($"digraph");
            Writer.WriteLine("{");
            using (Writer.Indent())
            {
                Writer.WriteLine($"comment = \"{Rule.Name}\"");
                Writer.WriteLine("rankdir = LR;");

                var left = NewPoint();
                var right = NewPoint();

                DoDot(Rule.Symbol, left, right);

            }
            Writer.WriteLine("}");
        }

        private string AllocNode() => $"n{++nodeCount}";

        private string NewPoint()
        {
            var node = AllocNode();
            Writer.WriteLine($"{node} [label=\"\"; shape=point];");
            return node;
        }

        private string NewNode(string label)
        {
            var node = AllocNode();
            Writer.WriteLine($"{node} [label=\"{label}\"; shape=box];");
            return node;
        }

        private void LeftToRight(string left, string mid, string right)
        {
            Writer.WriteLine($"{left}:e->{mid}:w;");
            Writer.WriteLine($"{mid}:e->{right}:w;");
        }


        private void DoDot(Symbol symbol, string left, string right)
        {
            Dot((dynamic)symbol, left, right);
        }

        private void Dot(Sequence sequence, string left, string right)
        {
            foreach (var symbol in sequence.Symbols)
            {
                var mid = NewPoint();
            
                DoDot(symbol, left, mid);
                left = mid;
            }
            Writer.WriteLine($"{left}:e->{right}:w;");
        }

        private void Dot(Alternative alternative, string left, string right)
        {
            foreach (var symbol in alternative.Sequences)
            {
                DoDot(symbol, left, right);
            }
        }

        private void Dot(Nonterminal symbol, string left, string right)
        {
            var mid = NewNode(symbol.Name);

            LeftToRight(left, mid, right);
        }

        private void Dot(OneOrMore symbol, string left, string right)
        {
            var mid = NewNode("()+");

            LeftToRight(left, mid, right);
        }

        private void Dot(ZeroOrMore symbol, string left, string right)
        {
            DoDot(symbol.Symbol, left, right);

            Writer.WriteLine($"{right}:s->{left}:s;");
            Writer.WriteLine($"{left}:n->{right}:n;");
        }

        private void Dot(Ebnf.Range symbol, string left, string right)
        {
            var mid = NewNode($"{symbol.Left.Decoded}..{symbol.Right.Decoded}");

            LeftToRight(left, mid, right);
        }

        private void Dot(Terminal symbol, string left, string right)
        {
            var mid = NewNode(symbol.Name);

            LeftToRight(left, mid, right);
        }

        private void Dot(Literal symbol, string left, string right)
        {
            var mid = NewNode(symbol.Decoded);

            LeftToRight(left, mid, right);
        }

        private void Dot(Symbol symbol, string left, string right)
        {
            throw new NotImplementedException();
        }
    }
}

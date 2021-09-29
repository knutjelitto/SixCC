using Microsoft.FSharp.Core;
using RailroadDiagrams;
using SixCC.Sdk.Ebnf;
using SixCC.Writing;

#pragma warning disable CA1822 // Mark members as static

namespace SixCC.Sdk.Earley
{
    public class RuleSvg
    {
        public RuleSvg(Writer writer)
        {
            Writer = writer;
        }

        public Writer Writer { get; }

        public void Write(Rule rule)
        {
            var y = new Diagram(Concat(DoDot(rule.Symbol)));

            using var text = new StringWriter();
            y.WriteSvg(text);
            Writer.WriteLine($"{text}");
        }

        private FSharpChoice<DiagramItem, string> Diag(Symbol symbol)
        {
            return FSharpChoice<DiagramItem, string>.NewChoice1Of2(DoDot(symbol));
        }

        private FSharpChoice<DiagramItem, string> Diag(DiagramItem diagram)
        {
            return FSharpChoice<DiagramItem, string>.NewChoice1Of2(diagram);
        }

        IEnumerable<FSharpChoice<DiagramItem, string>> Concat(params DiagramItem[] items)
        {
            return items.Select(i => Diag(i));
        }

        private DiagramItem DoDot(Symbol symbol)
        {
            return Dot((dynamic)symbol);
        }

        private DiagramItem Dot(Ebnf.Sequence sequence)
        {
            return new RailroadDiagrams.Sequence(sequence.Symbols.Select(sym => Diag(sym)));
        }

        private DiagramItem Dot(Alternative alternative)
        {
            return new Choice(0, alternative.Sequences.Select(sym => Diag(sym)));
        }

        private DiagramItem Dot(Nonterminal symbol)
        {
            return new NonTerminal(symbol.Name, null, null);
        }

        private DiagramItem Dot(Ebnf.OneOrMore symbol)
        {
            return new RailroadDiagrams.OneOrMore(Diag(symbol.Symbol));
        }

        private DiagramItem Dot(ZeroOrMore symbol)
        {
            return new Choice(0, Concat(new Skip(), DoDot(symbol.Symbol)));
        }

        private DiagramItem Dot(Ebnf.Range symbol)
        {
            return new RailroadDiagrams.Terminal($"{symbol.Left.Decoded}..{symbol.Right.Decoded}", null, null);
        }

        private DiagramItem Dot(Difference symbol)
        {
            return new RailroadDiagrams.Terminal($"{symbol.Left}-{symbol.Right}", null, null);
        }

        private DiagramItem Dot(Ebnf.Terminal symbol)
        {
            return new RailroadDiagrams.Terminal(symbol.Name, null, null);
        }

        private DiagramItem Dot(Literal symbol)
        {
            return new RailroadDiagrams.Terminal(symbol.Decoded, null, null);
        }

        private DiagramItem Dot(Symbol symbol)
        {
            throw new NotImplementedException();
        }
    }
}

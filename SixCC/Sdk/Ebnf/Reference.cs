using SixCC.Runtime.Structures;
using SixCC.Sdk.Automata;

namespace SixCC.Sdk.Ebnf
{
    public class Reference : Symbol
    {
        public Reference(ILocation location, string text)
            : base(location)
        {
            Text = text;
        }

        public Reference(Rule rule)
            : this(rule.Location, rule.Name)
        {
        }

        public string Text { get; }

        public override NFA GetTerminalNfa(Factory builder)
        {
            throw new NotImplementedException();
        }

        public override NFA GetNonterminalNfa(Factory builder)
        {
            throw new NotImplementedException();
        }

        public override string ToString() => $"^{Text}";
    }
}

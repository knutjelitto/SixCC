using SixCC.Sdk.Grammars;

namespace SixCC.Sdk.Tree
{
    public sealed class TerminalRule : Terminal
    {
        public static readonly TerminalRule Nope = new TerminalRule("$nope$", new Nope());

        public TerminalRule(string name, IExpression expression)
            : base(name)
        {
            Expression = expression;
        }

        public IExpression Expression { get; }
    }
}

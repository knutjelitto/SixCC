using System.Collections.Generic;

namespace Six.Ceylon.Ast
{
    public sealed class StringTemplate : Node, Expression
    {
        public StringTemplate(StringStart start, IEnumerable<Expression> expressions, IEnumerable<StringMid> mids, StringEnd end)
        {
            Start = start;
            Expressions = new Expressions(expressions);
            Mids = new StringMids(mids);
            End = end;
        }

        public StringStart Start { get; }
        public Expressions Expressions { get; }
        public StringMids Mids { get; }
        public StringEnd End { get; }
    }

    public sealed class StringMids : NodeList<StringMid>
    {
        public StringMids(IEnumerable<StringMid> items) : base(items)
        {
        }
    }

    public sealed class StringStart : Node
    {
        public StringStart(Terminal terminal)
        {
            Terminal = terminal;
        }

        public Terminal Terminal { get; }
    }

    public sealed class StringMid : Node
    {
        public StringMid(Terminal terminal)
        {
            Terminal = terminal;
        }

        public Terminal Terminal { get; }
    }

    public sealed class StringEnd : Node
    {
        public StringEnd(Terminal terminal)
        {
            Terminal = terminal;
        }

        public Terminal Terminal { get; }
    }

}

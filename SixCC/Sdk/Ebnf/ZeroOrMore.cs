﻿using SixCC.Runtime.Structures;
using SixCC.Sdk.Automata;

namespace SixCC.Sdk.Ebnf
{
    public class ZeroOrMore : Bracketed
    {
        public ZeroOrMore(ILocation location, Symbol symbol)
            : base(location, symbol)
        {
            IsNullable = true;
        }

        public override NFA GetTerminalNfa(Factory builder)
        {
            return Symbol.GetTerminalNfa(builder).ZeroOrMore();
        }

        public override NFA GetNonterminalNfa(Factory builder)
        {
            return Symbol.GetNonterminalNfa(builder).ZeroOrMore();
        }

        public override string ToString()
        {
            if (Symbol is Sequence production)
            {
                return $"({production})*";
            }
            return $"{Symbol}*";
        }
    }
}

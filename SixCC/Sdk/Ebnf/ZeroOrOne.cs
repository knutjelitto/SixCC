﻿using SixCC.Runtime.Structures;
using SixCC.Sdk.Automata;

namespace SixCC.Sdk.Ebnf
{
    public class ZeroOrOne : Bracketed
    {
        public ZeroOrOne(ILocation location, Symbol symbol)
            : base(location, symbol)
        {
            IsNullable = true;
        }

        public override NFA GetTerminalNfa(Factory builder)
        {
            return Symbol.GetTerminalNfa(builder).ZeroOrOne();
        }

        public override NFA GetNonterminalNfa(Factory builder)
        {
            return Symbol.GetNonterminalNfa(builder).ZeroOrOne();
        }

        public override string ToString()
        {
            if (Symbol is Sequence production)
            {
                return $"({production})?";
            }
            return $"{Symbol}?";
        }
    }
}

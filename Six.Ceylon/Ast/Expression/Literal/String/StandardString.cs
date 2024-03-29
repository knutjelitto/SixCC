﻿using Six.Runtime.Types;

namespace Six.Ceylon.Ast
{
    public sealed class StandardString : String, Expr
    {
        public StandardString(RToken token)
            : base(GetText(token))
        {
        }

        private static string GetText(RToken token)
        {
            Assert(token.Text.StartsWith("\"") && token.Text.EndsWith("\""));

            return Decode(token.Text[1..^1]);
        }
    }
}

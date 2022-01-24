using Six.Runtime.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Ceylon.Ast
{
    public class UpperIdentifier : Identifier
    {
        public UpperIdentifier(RToken token)
            : base(token, GetText(token))
        {
        }

        private static string GetText(RToken token)
        {
            var text = token.Text;

            if (text.StartsWith("\\I"))
                return text[2..];
            return text;
        }
    }
}

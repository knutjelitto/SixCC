using Six.Runtime.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Ceylon.Ast
{
    public class AnyIdentifier : Identifier
    {
        public AnyIdentifier(RToken token)
            : base(token, token.Text)
        {
        }
    }
}

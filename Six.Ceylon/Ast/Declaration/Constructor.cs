using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Ceylon.Ast
{
    public class Constructor : Declaration
    {
        public Constructor(Identifier name)
            : base(name)
        {
        }

        public override string ItemKind => "d-ctor";
    }
}

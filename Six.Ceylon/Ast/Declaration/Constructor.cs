using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Ceylon.Ast
{
    public class Constructor : Statement, IBodyOwner
    {
        public Constructor(Identifier? name)
        {
            Body = new Body(this);
        }

        public override string ItemKind => "d-ctor";

        public IBody Body { get; }
    }
}

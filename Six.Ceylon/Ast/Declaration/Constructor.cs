using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Ceylon.Ast
{
    public class Constructor : Stmt, IBodyOwner
    {
        public Constructor(Identifier? name)
        {
            Body = new Body(this);
        }

        public IBody Body { get; }
    }
}

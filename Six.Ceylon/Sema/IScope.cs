using Six.Ceylon.Ast;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Ceylon.Sema
{
    public interface IScope
    {
        bool Add(Identifier name, AstNode node);
    }
}

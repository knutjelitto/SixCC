using Six.Ceylon.Ast;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Ceylon.Sema
{
    public abstract class Scope : IScope
    {
        private readonly Dictionary<string, AstNode> lookup = new();

        public bool Add(Identifier name, AstNode node)
        {
            return lookup.TryAdd(name.Text, name);
        }
    }
}

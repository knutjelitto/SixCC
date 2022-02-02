using Six.Ceylon.Ast;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Ceylon.Sema
{
    public class NamespaceScope : Scope
    {
        public NamespaceScope(string name)
        {
            Name = name;
        }

        public string Name { get; }
    }
}

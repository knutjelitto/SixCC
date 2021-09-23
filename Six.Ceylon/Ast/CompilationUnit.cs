using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Ceylon.Ast
{
    public class CompilationUnit : Node
    {
        public CompilationUnit(IEnumerable<Declaration> declarations, Eof eof)
        {
            Eof = eof;
            Declarations = declarations.ToList();
        }

        public List<Declaration> Declarations { get; }
        public Eof Eof { get; }
    }
}

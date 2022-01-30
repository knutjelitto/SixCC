using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Ceylon.Ast
{
    public static class Misc
    {
        public sealed record ForIterator(Pattern Variable, Containment? Containment);

        public sealed record Containment(string Op, Ast.Expr Expr);

    }
}

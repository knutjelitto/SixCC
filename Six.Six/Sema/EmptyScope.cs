using Six.Six.Ast;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using A = Six.Six.Ast;

namespace Six.Six.Sema
{
    public class EmptyScope : Scope
    {
        [DebuggerStepThrough]
        public EmptyScope(Scope parent)
        {
            Parent = parent;
        }
        public Scope Parent { get; }
        public IReadOnlyList<Member> Members { get; } = Array.Empty<Member>();
        public T Add<T>(T member) where T : Member => throw new NotImplementedException();
    }
}

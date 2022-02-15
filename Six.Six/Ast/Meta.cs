using Six.Runtime.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Six.Ast
{
    public interface Meta : Expression
    {
        public abstract record MetaReference(IRNode Tree, Names Names) : Meta;
        public sealed record ClassReference(IRNode Tree, Names Names) : MetaReference(Tree, Names);
        public sealed record ObjectReference(IRNode Tree, Names Names) : MetaReference(Tree, Names);
        public sealed record ValueReference(IRNode Tree, Names Names) : MetaReference(Tree, Names);
        public sealed record InterfaceReference(IRNode Tree, Names Names) : MetaReference(Tree, Names);
        public sealed record FunctionReference(IRNode Tree, Names Names) : MetaReference(Tree, Names);
    }
}

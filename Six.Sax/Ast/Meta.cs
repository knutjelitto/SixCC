using Six.Runtime.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Sax.Ast
{
    public interface Meta : Expression
    {
        public abstract record Reference(IRNode Tree, Names Names) : Meta;
        public sealed record ClassReference(IRNode Tree, Names Names) : Reference(Tree, Names);
        public sealed record InterfaceReference(IRNode Tree, Names Names) : Reference(Tree, Names);
        public sealed record FunctionReference(IRNode Tree, Names Names) : Reference(Tree, Names);
    }
}

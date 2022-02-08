using Six.Runtime.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Sax.Ast
{
    public interface Unit : Node
    {
        public sealed record Code(
            IRNode Tree, 
            bool Skip,
            Namespace Namespace,
            Using.Usings Usings,
            Declarations Declarations) : Unit;
        public sealed record Module(IRNode Tree, Names Names) : Unit;
    }
}

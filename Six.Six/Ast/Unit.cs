using Six.Runtime.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Six.Ast
{
    public interface Unit : TreeNode
    {
        public sealed record Code(
            IRNode Tree, 
            NamespaceIntro Namespace,
            Usings Usings,
            Declarations Declarations) : Unit;
        public sealed record Module(IRNode Tree, Names Names) : Unit;
    }
}

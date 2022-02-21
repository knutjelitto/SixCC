using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using A = Six.Six.Ast;

namespace Six.Six.Sema
{
    public interface Entity
    {
        Assoc Assoc { get; }       
    }

    public static class EntityExtensions
    {
        public static Container? Scope(this Entity entity)
        {
            return entity.Assoc.Scope;
        }
        public static A.TreeNode Node(this Entity entity)
        {
            return entity.Assoc.Node;
        }
    }
}

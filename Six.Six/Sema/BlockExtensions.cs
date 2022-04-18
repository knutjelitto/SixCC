using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Six.Sema
{
    public static class BlockExtensions
    {
        public static IEnumerable<Decl> GetDeclarations(this NamespaceBlock block)
        {
            return block.Members.OfType<Decl>();
        }

        public static string FullName(this Block block)
        {
            if (block is ModuleBlock)
            {
                return "";
            }
            else if (block is NamespaceBlock namespaceBlock)
            {
                return namespaceBlock.GetPath();
            }
            else if (block is CodeBlock codeBlock)
            {
                return $"{block.Parent.FullName()}";
            }
            else
            {
                return $"{block.Parent.FullName()}.{block.Name}";
            }
        }
    }
}

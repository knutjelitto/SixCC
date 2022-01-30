using Six.Ceylon.Ast;
using Six.Runtime.Types;
using static Six.Ceylon.CeylonTree;

namespace Six.Ceylon
{
    public partial class CeylonVisitor
    {
        protected override void Visit(CPackageDescriptor element)
        {
            WalkChildrenNotYet(element);
        }
    }
}

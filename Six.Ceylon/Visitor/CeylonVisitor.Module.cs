using Six.Ceylon.Ast;
using Six.Runtime.Types;
using static Six.Ceylon.CeylonTree;

namespace Six.Ceylon
{
    public partial class CeylonVisitor
    {
        protected override void Visit(CModuleDescriptor element)
        {
            WalkChildrenNotYet(element);
        }

        protected override void Visit(CModuleBody element)
        {
            WalkChildrenNotYet(element);
        }

        protected override void Visit(CModuleImport element)
        {
            WalkChildrenNotYet(element);
        }
    }
}

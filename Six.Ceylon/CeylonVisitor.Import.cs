using Six.Ceylon.Ast;
using static Six.Ceylon.CeylonTree;

namespace Six.Ceylon
{
    public partial class CeylonVisitor
    {
        protected override void Visit(CImports element)
        {
            WalkChildrenNotYet(element);

            //TODO
            element.Value = new ImportList(Enumerable.Empty<Import>());
        }

        protected override void Visit(CImportDeclaration element)
        {
            WalkChildrenNotYet(element);
        }

        protected override void Visit(CImportElements element)
        {
            WalkChildrenNotYet(element);
        }

        protected override void Visit(CImportElementList element)
        {
            WalkChildrenNotYet(element);
        }

        protected override void Visit(CImportNamed element)
        {
            WalkChildrenNotYet(element);
        }

        protected override void Visit(CImportNameSpecifier element)
        {
            WalkChildrenNotYet(element);
        }

        protected override void Visit(CImportWildcard element)
        {
            WalkChildrenNotYet(element);
        }
    }
}

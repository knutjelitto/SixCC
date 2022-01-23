using static Six.Ceylon.CeylonTree;

namespace Six.Ceylon
{
    public partial class CeylonVisitor
    {
        protected override void Visit(CImportDeclarations element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CImportDeclaration element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CImportElements element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CImportElementList element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CImportNamed element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CImportNameSpecifier element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CImportWildcard element)
        {
            WalkChilden(element);
        }
    }
}

using Six.Ceylon.Ast;
using static Six.Ceylon.CeylonTree;

namespace Six.Ceylon
{
    public partial class CeylonVisitor
    {
        protected override void Visit(CImports element)
        {
            WalkChildren(element);

            //TODO
            element.Value = new ImportList(Enumerable.Empty<Import>());
        }

        protected override void Visit(CImportDeclaration element)
        {
            WalkChildren(element);
        }

        protected override void Visit(CImportElements element)
        {
            WalkChildren(element);
        }

        protected override void Visit(CImportElementList element)
        {
            WalkChildren(element);
        }

        protected override void Visit(CImportNamed element)
        {
            WalkChildren(element);
        }

        protected override void Visit(CImportNameSpecifier element)
        {
            WalkChildren(element);
        }

        protected override void Visit(CImportWildcard element)
        {
            WalkChildren(element);
        }
    }
}

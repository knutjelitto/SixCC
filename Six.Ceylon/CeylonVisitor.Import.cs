using Six.Ceylon.Ast;
using static Six.Ceylon.CeylonTree;

namespace Six.Ceylon
{
    public partial class CeylonVisitor
    {
        protected override void Visit(CImports element)
        {
            WalkChildrenTodo(element);

            //TODO
            element.Value = new ImportList(Enumerable.Empty<Import>());
        }

        protected override void Visit(CImportDeclaration element)
        {
            WalkChildrenTodo(element);
        }

        protected override void Visit(CImportElements element)
        {
            WalkChildrenTodo(element);
        }

        protected override void Visit(CImportElementList element)
        {
            WalkChildrenTodo(element);
        }

        protected override void Visit(CImportNamed element)
        {
            WalkChildrenTodo(element);
        }

        protected override void Visit(CImportNameSpecifier element)
        {
            WalkChildrenTodo(element);
        }

        protected override void Visit(CImportWildcard element)
        {
            WalkChildrenTodo(element);
        }
    }
}

using static Six.Ceylon.CeylonTree;

namespace Six.Ceylon
{
    public partial class CeylonVisitor
    {
        protected override void Visit(CParameters element)
        {
            WalkChildrenTodo(element);
        }

        protected override void Visit(CParameterList element)
        {
            WalkChildrenTodo(element);
        }

        protected override void Visit(CValueParameterDeclaration element)
        {
            WalkChildrenTodo(element);
        }

        protected override void Visit(CFunctionParameterDeclaration element)
        {
            WalkChildrenTodo(element);
        }

        protected override void Visit(CParameter element)
        {
            WalkChildrenTodo(element);
        }

        protected override void Visit(CParameterReference element)
        {
            WalkChildrenTodo(element);
        }
    }
}

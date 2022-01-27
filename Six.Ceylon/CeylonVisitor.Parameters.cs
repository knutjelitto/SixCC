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
            WalkChildren(element);
        }

        protected override void Visit(CValueParameterDeclaration element)
        {
            WalkChildren(element);
        }

        protected override void Visit(CFunctionParameterDeclaration element)
        {
            WalkChildren(element);
        }

        protected override void Visit(CParameter element)
        {
            WalkChildren(element);
        }

        protected override void Visit(CParameterReference element)
        {
            WalkChildren(element);
        }
    }
}

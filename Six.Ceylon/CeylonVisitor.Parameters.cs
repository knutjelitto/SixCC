using static Six.Ceylon.CeylonTree;

namespace Six.Ceylon
{
    public partial class CeylonVisitor
    {
        protected override void Visit(CParameters element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CParameterList element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CValueParameterDeclaration element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CFunctionParameterDeclaration element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CParameter element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CParameterReference element)
        {
            WalkChilden(element);
        }
    }
}

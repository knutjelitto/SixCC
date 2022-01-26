using Six.Ceylon.Ast;
using static Six.Ceylon.CeylonTree;

namespace Six.Ceylon
{
    public partial class CeylonVisitor
    {
        protected override void Visit(CAnnotations element)
        {
            //TODO: Annotations
            element.Value = new Annotations();
        }

        protected override void Visit(CAnnotation element)
        {
            WalkChilden(element);
        }
    }
}

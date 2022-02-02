using Six.Ceylon.Ast;
using static Six.Ceylon.CeylonTree;

namespace Six.Ceylon.Visitor
{
    public partial class CeylonVisitor
    {
        protected override void Visit(CAnnotations element)
        {
            var doc = Walk<String>(element.StringLiteral);
            var annotations = new AnnotationList(WalkMany<Annotation>(element.Annotation));
            element.Value = new Annotations(doc, annotations);
        }

        protected override void Visit(CAnnotation element)
        {
            var name = Walk<Identifier>(element.MemberName);
            var arguments = Walk<Arguments>(element.Arguments);

            element.Value = new Annotation(name, arguments);
        }
    }
}

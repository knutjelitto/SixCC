using Six.Ceylon.Ast;
using static Six.Ceylon.CeylonTree;

namespace Six.Ceylon
{
    public partial class CeylonVisitor
    {
        protected override void Visit(CAnnotations element)
        {
            var doc = Walk<Ast.String>(element.StringLiteral);
            var annotations = new AnnotationList(WalkMany<Annotation>(element.Annotation));
            element.Value = new Annotations(doc, annotations);
        }

        protected override void Visit(CAnnotation element)
        {
            var name = Walk<Identifier>(element.MemberName);
            var arguments = Walk<ArgumentList>(element.Arguments);

            element.Value = new Annotation(name, arguments);
        }
    }
}

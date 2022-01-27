using Six.Ceylon.Ast;
using static Six.Ceylon.CeylonTree;

namespace Six.Ceylon
{
    public partial class CeylonVisitor
    {
        protected override void Visit(CAnnotations element)
        {
            var doc = Walk<Ast.String>(element.StringLiteralOptional);
            var annotations = element.AnnotationStar.Children.Select(child => Walk<Annotation>(child));
            element.Value = new Annotations(doc, annotations);
        }

        protected override void Visit(CAnnotation element)
        {
            var name = Walk<Identifier>(element.MemberName);
            var arguments = Walk<Arguments>(element.ArgumentsOptional);

            element.Value = new Annotation(name, arguments);
        }
    }
}

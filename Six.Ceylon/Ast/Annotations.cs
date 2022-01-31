namespace Six.Ceylon.Ast
{
    public class Annotation : AstNode
    {
        public Annotation(Identifier name, ArgumentList? arguments)
        {
            Name = name;
            Arguments = arguments;
        }

        public Identifier Name { get; }
        public ArgumentList? Arguments { get; }
    }

    public sealed record AnnotationList(IEnumerable<Annotation> Items) : ReadOnlyList<Annotation>(Items);

    public class Annotations
    {
        public Annotations(String? doc, AnnotationList annotations)
        {
            Doc = doc;
            Items = annotations;
        }

        public String? Doc { get; }
        public AnnotationList Items { get; }
    }
}

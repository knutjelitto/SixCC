namespace Six.Ceylon.Ast
{
    public class Annotations
    {
        public Annotations(String? doc, IEnumerable<Annotation> annotations)
        {
            Doc = doc;
            Items = new AnnotationList(annotations);
        }

        public String? Doc { get; }
        public AnnotationList Items { get; }
    }
}

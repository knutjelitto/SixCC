namespace Six.Ceylon.Ast
{
    public sealed record AnnotationList(IEnumerable<Annotation> Items) : ReadOnlyList<Annotation>(Items);
}

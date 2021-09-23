namespace Six.Ceylon.Ast
{
    public sealed class PackageDescriptor : Node, Declaration
    {
        public PackageDescriptor(Annotations annotations, DottedName name)
        {
            Annotations = annotations;
            Name = name;
        }

        public Annotations Annotations { get; }
        public DottedName Name { get; }
    }
}

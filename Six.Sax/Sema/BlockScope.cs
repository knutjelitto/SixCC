namespace Six.Sax.Sema
{
    public class BlockScope : Scope, Contained
    {
        public BlockScope(Container container)
            : base(container.Module)
        {
            Container = container;
        }

        public Container Container { get; }
    }
}

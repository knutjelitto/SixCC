namespace Six.Sax.Sema
{
    public class BlockScope : Scope
    {
        public BlockScope(IScope up)
            : base(up.Global)
        {
            Up = up;
        }

        public IScope Up { get; }
    }
}

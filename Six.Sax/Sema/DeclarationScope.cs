namespace Six.Sax.Sema
{
    public class DeclarationScope : Scope
    {
        public DeclarationScope(IScope up)
            : base(up.Global)
        {
            Up = up;
        }

        public IScope Up { get; }
    }
}

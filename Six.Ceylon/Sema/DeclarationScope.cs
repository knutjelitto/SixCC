namespace Six.Ceylon.Sema
{
    public class DeclarationScope : Scope
    {
        public DeclarationScope(IScope up)
        {
            Up = up;
        }

        public IScope Up { get; }
    }
}

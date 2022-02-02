namespace Six.Ceylon.Sema
{
    public class DeclarationScope : Scope
    {
        public DeclarationScope(string name)
        {
            Name = name;
        }

        public string Name { get; }
    }
}

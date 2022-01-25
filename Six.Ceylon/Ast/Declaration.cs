namespace Six.Ceylon.Ast
{
    public abstract class Declaration : INamed, IDeclarationsOwner
    {
        public Declaration(Identifier name)
        {
            Name = name;
            Declarations = new DeclarationBag(this);
        }

        public Identifier Name { get; }

        public abstract string Kind { get; }

        public IDeclarationBag Declarations { get; }

        public string Location()
        {
            return Name.Token.Source.NameLineColumn(Name.Token.Core);
        }
    }
}

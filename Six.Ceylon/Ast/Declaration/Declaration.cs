namespace Six.Ceylon.Ast
{
    public abstract class Declaration : Statement, INamed, IBodyOwner
    {
        public Declaration(Identifier name)
        {
            Name = name;
            Body = new Body(this);
        }

        public Identifier Name { get; }

        public abstract string ItemKind { get; }

        public IBody Body { get; }

        public string Location()
        {
            return Name.Token.Source.NameLineColumn(Name.Token.Core);
        }
    }
}

using Six.Ceylon.Ast;

namespace Six.Ceylon
{
    public class DeclarationBag : IDeclarationBag
    {
        private readonly Dictionary<Identifier, Declaration> declarations = new();

        public DeclarationBag(IDeclarationsOwner owner)
        {
            Owner = owner;
        }

        public IDeclarationsOwner Owner { get; }

        public int Count => declarations.Count;

        public void Add(Declaration declaration)
        {
            Assert(declaration.Name is LowerIdentifier || declaration.Name is UpperIdentifier);
            declarations.Add(declaration.Name, declaration);
        }

        public void Dump(Writer writer)
        {
            foreach (var declaration in declarations.Values.OrderBy(x => x.Name.Text))
            {
                writer.WriteLine($"{declaration.Kind,-10}: {declaration.Name,-30} [{declaration.Location()}]");
                if (declaration is IDeclarationsOwner owner && owner.Declarations.Count > 0)
                {
                    using (writer.Indent())
                    {
                        owner.Declarations.Dump(writer);
                    }
                }
            }
        }
    }
}

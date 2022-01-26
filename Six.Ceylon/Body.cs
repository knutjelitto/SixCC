using Six.Ceylon.Ast;

namespace Six.Ceylon
{
    public class Body : IBody
    {
        private readonly Dictionary<Identifier, Declaration> declarations = new();
        private readonly List<Statement> statements = new();

        public Body(IBodyOwner owner)
        {
            Owner = owner;
        }

        public IBodyOwner Owner { get; }

        public int StatementCount => statements.Count - declarations.Count;
        public int DeclarationCount => declarations.Count;

        public void Add(Statement statement)
        {
            statements.Add(statement);
            if (statement is Declaration declaration)
            {
                Add(declaration);
            }
        }

        private void Add(Declaration declaration)
        {
            Assert(declaration.Name is LowerIdentifier || declaration.Name is UpperIdentifier);
            declarations.Add(declaration.Name, declaration);
        }

        public void Dump(Writer writer)
        {
            foreach (var declaration in statements.OfType<Declaration>())
            {
                writer.WriteLine($"{declaration.ItemKind,-13}: {declaration.Name,-30} [{declaration.Location()}]");
                if (declaration is IBodyOwner owner && owner.Body.DeclarationCount > 0)
                {
                    using (writer.Indent())
                    {
                        owner.Body.Dump(writer);
                    }
                }
            }
        }
    }
}

using Six.Ceylon.Ast;

namespace Six.Ceylon
{
    public class Body : IBody
    {
        private readonly Dictionary<Identifier, Decl> declarations = new();
        private readonly List<Stmt> statements = new();

        public Body(IBodyOwner owner)
        {
            Owner = owner;
        }

        public IBodyOwner Owner { get; }

        public int Count => statements.Count;
        public int StatementCount => statements.Count - declarations.Count;
        public int DeclarationCount => declarations.Count;

        public void Add(Stmt statement)
        {
            statements.Add(statement);
            if (statement is Decl declaration)
            {
                Add(declaration);
            }
            else
            {

            }
        }

        private void Add(Decl declaration)
        {
#if false
            Assert(declaration.Name is LowerIdentifier || declaration.Name is UpperIdentifier);
            try
            {
                declarations.Add(declaration.Name, declaration);
            }
            catch (Exception ex)
            {
                throw new AggregateException($"{declaration.Location()}: ERROR", ex);
            }
#endif
        }

        public void Dump(Writer writer)
        {
#if true
            writer.WriteLine("TODO");
#else
            foreach (var declaration in statements.OfType<Decl>())
            {
                writer.WriteLine($"{declaration.GetType().Name.ToLowerInvariant(),-13}: {declaration.Name,-30} [{declaration.Location()}]");
                if (declaration is IBodyOwner owner && owner.Body.DeclarationCount > 0)
                {
                    using (writer.Indent())
                    {
                        owner.Body.Dump(writer);
                    }
                }
            }
#endif
        }
    }
}

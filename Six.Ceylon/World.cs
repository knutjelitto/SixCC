using Six.Ceylon.Ast;

namespace Six.Ceylon
{
    public class World
    {
        private readonly Stack<Module> moduleStack = new Stack<Module>();
        private readonly Stack<Package> packageStack = new Stack<Package>();
        private readonly Stack<IBodyOwner> ownerStack = new Stack<IBodyOwner>();

        public readonly INamespace Global = new Namespace();

        public World()
        {
        }

        public Module CurrentModule => moduleStack.Peek();
        public Package CurrentPackage => packageStack.Peek();
        public IBodyOwner Owner => ownerStack.Peek();

        public IDisposable CreateNamespace(IdentifierList identifiers)
        {
            var current = Global;
            foreach (var identifier in identifiers)
            {
                current = current.Create(identifier);
            }
            return Use(current);
        }

        public void AddDeclaration(Statement declaration)
        {
            Assert(ownerStack.Count > 0);
            Owner.Body.Add(declaration);
        }

        public IDisposable Use(Module module)
        {
            moduleStack.Push(module);
            return new Disposable(() => moduleStack.Pop());
        }

        public IDisposable Use(Package package)
        {
            packageStack.Push(package);
            return new Disposable(() => packageStack.Pop());
        }

        public IDisposable Use(IBodyOwner owner)
        {
            ownerStack.Push(owner);
            return new Disposable(() => ownerStack.Pop());
        }
    }
}

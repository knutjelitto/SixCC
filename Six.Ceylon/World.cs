using Six.Ceylon.Ast;

namespace Six.Ceylon
{
    public class World
    {
        private readonly Stack<Module> moduleStack = new Stack<Module>();
        private readonly Stack<Package> packageStack = new Stack<Package>();
        private readonly Stack<IDeclarationsOwner> ownerStack = new Stack<IDeclarationsOwner>();

        public readonly INamespace Global = new Namespace();

        public World()
        {
        }

        public Module CurrentModule => moduleStack.Peek();
        public Package CurrentPackage => packageStack.Peek();
        public IDeclarationsOwner Owner => ownerStack.Peek();

        public IDisposable CreateNamespace(Identifiers identifiers)
        {
            var current = Global;
            foreach (var identifier in identifiers)
            {
                current = current.Create(identifier);
            }
            return Use(current);
        }

        public void AddDeclaration(Declaration declaration)
        {
            Assert(ownerStack.Count > 0);
            Owner.Declarations.Add(declaration);
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

        public IDisposable Use(IDeclarationsOwner owner)
        {
            ownerStack.Push(owner);
            return new Disposable(() => ownerStack.Pop());
        }
    }
}

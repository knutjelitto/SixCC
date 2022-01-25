using Six.Ceylon.Ast;

namespace Six.Ceylon
{
    public class World
    {
        private readonly Stack<Module> moduleStack = new Stack<Module>();
        private readonly Stack<Package> packageStack = new Stack<Package>();

        public World()
        {
        }

        public Module CurrentModule => moduleStack.Peek();
        public Package CurrentPackage => packageStack.Peek();

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
    }
}

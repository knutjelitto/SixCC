using Six.Ceylon.Ast;

namespace Six.Ceylon
{
    public class World
    {
        private readonly Stack<Module> moduleStack = new Stack<Module>();
        private readonly Stack<Package> packageStack = new Stack<Package>();
        private readonly Stack<FileJob> fileStack = new Stack<FileJob>();

        public Module CurrentModule => moduleStack.Peek();
        public Package CurrentPackage => packageStack.Peek();
        public FileJob CurrentFile => fileStack.Peek();
    }
}

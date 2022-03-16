#pragma warning disable CA1822 // Mark members as static
#pragma warning disable IDE0060 // Remove unused parameter

namespace Six.Six.Sema
{
    public class Layouter
    {
        public Layouter(Module module)
        {
            Module = module;
        }

        public Module Module { get; }

        public void Run()
        {
            foreach (var classy in Module.GetClassies())
            {
                Walk(classy);
            }
        }

        private void Walk(Entity entity)
        {
            Layout((dynamic)entity);
        }

        private void Layout(Entity entity)
        {
            Assert(true);
        }

        private void Layout(Decl.Class decl)
        {
            decl.Layout.Run();
        }
    }
}

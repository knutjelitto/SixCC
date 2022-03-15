using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            foreach (var field in decl.Fields)
            {
                decl.Layout.Add(field);
            }

            decl.Layout.Finish();
        }
    }
}

using Six.Core;

namespace Six.Sax.Sema
{
    public static class DumpExtensions
    {
        private static int dcMax = 100;
        private static int dcCount = 0;

        public static void Dump(this Declaration declaration, Writer writer)
        {
            var attrs = new StringBuilder();
            attrs.Append(declaration.IsShared ? "S" : " ");
            attrs.Append(declaration.IsNative ? "N" : " ");

            writer.WriteLine($"{declaration.GetKindOne()} [{attrs}] {declaration.GetName()}");

            declaration.Content.Dump(writer);

            dcCount++;
        }

        public static void Dump(this Statement statement, Writer writer)
        {
            writer.WriteLine($"{statement.GetKind()}");
        }

        public static void Dump(this Container container, Writer writer)
        {
            if (dcCount < dcMax)
            {
                using (writer.Indent())
                {
                    foreach (var entitiy in container.Entities)
                    {
                        entitiy.DumpIntern(writer);

                        if (dcCount == dcMax)
                        {
                            break;
                        }
                    }
                }
            }
        }

        public static void DumpReferences(this Module module, Writer writer)
        {
            foreach (var ns in module.GetNamespaces())
            {
                foreach (var declaration in ns.Entities.OfType<Declaration>())
                {
                    var attrs = new StringBuilder();
                    attrs.Append(declaration.IsShared ? "S" : " ");
                    attrs.Append(declaration.IsNative ? "N" : " ");

                    writer.WriteLine($"{declaration.GetKindOne()} [{attrs}] {declaration.GetName(),-50} {declaration.GetLocation()}");
                }
            }
        }

        private static void DumpIntern(this Entity entity, Writer writer)
        {
            Dump((dynamic)entity, writer);
        }

        private static void Dump(this Entity entity, Writer writer)
        {
            Assert(false);
        }
    }
}

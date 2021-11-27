namespace Six.Gen
{
    internal class CodeGeneratorCore : IDisposable
    {
        protected Writer writer;

        protected CodeGeneratorCore()
        {
            writer = new Writer();
        }

        public virtual void Generate(string name, string content)
        {
        }

        protected void w(string text)
        {
            writer.Write(text);
        }

        protected void wl(string text)
        {
            writer.WriteLine(text);
        }

        protected void wl()
        {
            writer.WriteLine();
        }

        protected void block(string head, Action content)
        {
            writer.WriteLine(head);
            writer.WriteLine("{");
            using (writer.Indent())
            {
                content();
            }
            writer.WriteLine("}");
        }

        protected void initializer(string head, Action content)
        {
            writer.WriteLine(head);
            writer.WriteLine("{");
            using (writer.Indent())
            {
                content();
            }
            writer.WriteLine("};");
        }

        protected void indent(Action content)
        {
            using (writer.Indent())
            {
                content();
            }
        }

        protected IDisposable indent()
        {
            return writer.Indent();
        }

        public void Dispose()
        {
            writer.Dispose();
        }

        public override string ToString()
        {
            return writer.ToString();
        }
    }
}

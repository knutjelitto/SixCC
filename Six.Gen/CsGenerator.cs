namespace Six.Gen
{
    public class CsGenerator : IDisposable
    {
        protected Writer writer;
        private readonly bool owns;

        protected CsGenerator()
        {
            writer = new Writer();
            owns = true;
        }

        protected CsGenerator(Writer writer)
        {
            this.writer = writer; ;
            owns = false;
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

        protected void block(Action content)
        {
            block(string.Empty, content);
        }

        protected void block(string head, Action content)
        {
            if (!string.IsNullOrWhiteSpace(head))
            {
                writer.WriteLine(head);
            }
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

        protected void indent(string head, Action content)
        {
            writer.WriteLine(head);
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
            if (owns)
            {
                writer.Dispose();
            }
        }

        public override string ToString()
        {
            return writer.ToString();
        }
    }
}

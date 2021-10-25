namespace SixTools
{
    public class Writer
    {
        public Writer(TextWriter sink)
        {
            this.sink = sink;
        }

        public Writer() : this(new StringWriter())
        {
        }

        public void WriteLine()
        {
            sink.WriteLine();
            pending = true;
        }

        public void WriteLine(string text)
        {
            Write(text);
            WriteLine();
        }

        public void Write(string text)
        {
            if (pending)
            {
                for (var i = 0; i < level; i++)
                {
                    sink.Write(prefix);
                    pending = false;
                }
            }
            sink.Write(text);
        }

        public void Plus()
        {
            level += 1;
        }

        public void Minus()
        {
            level = Math.Max(0, level - 1);
        }

        public IDisposable Indent()
        {
            return new Undenter(this);
        }

        public override string ToString()
        {
            if (sink is StringWriter stringWriter)
            {
                return stringWriter.ToString();
            }
            return "-content-lost-in-sink-";
        }

        private class Undenter : IDisposable
        {
            private readonly Writer writer;

            public Undenter(Writer writer)
            {
                this.writer = writer;
                writer.Plus();
            }
            public void Dispose()
            {
                writer.Minus();
            }
        }

        private readonly TextWriter sink;
        private int level;
        private bool pending = true;
        private readonly string prefix = "    ";
    }
}

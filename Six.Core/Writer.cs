using System;
using System.IO;

namespace Six.Core
{
    public class Writer : IDisposable
    {
        public Writer(TextWriter sink, bool owns = false)
        {
            this.sink = sink;
            this.owns = owns;
        }

        public Writer()
            : this(new StringWriter(), true)
        {
        }

        public Writer(string filename)
            : this(new StreamWriter(filename), true)
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

        public void Indent(Action content)
        {
            using (Indent())
            {
                content();
            }
        }

        public override string ToString()
        {
            if (sink is StringWriter stringWriter)
            {
                return stringWriter.ToString();
            }
            return "-content-lost-in-outer-space-";
        }

        public void Dispose()
        {
            if (owns && sink != null)
            {
                sink.Dispose();
            }
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
        private readonly bool owns;
        private int level;
        private bool pending = true;
        private readonly string prefix = "    ";
    }
}

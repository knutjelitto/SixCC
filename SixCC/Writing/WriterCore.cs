using System;
using System.CodeDom.Compiler;

namespace SixCC.Writing
{
    public abstract class WriterCore : Writer
    {
        protected IndentedTextWriter writer;

        public WriterCore(IndentedTextWriter writer)
        {
            this.writer = writer;
        }

        public void Write(string text)
        {
            writer.Write(text);
        }

        public void WriteLine(string text)
        {
            writer.WriteLine(text);
        }

        public void WriteLine()
        {
            writer.WriteLine();
        }

        public IDisposable Indent()
        {
            return new Indentor(writer);
        }

        public virtual void Dispose()
        {
            writer.Close();
        }

        private sealed class Indentor : IDisposable
        {
            private readonly IndentedTextWriter writer;

            public Indentor(IndentedTextWriter writer)
            {
                this.writer = writer;
                this.writer.Indent += 1;
            }
            public void Dispose()
            {
                this.writer.Indent -= 1;
            }
        }
    }
}

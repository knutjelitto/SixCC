using System;

namespace SixCC.Writing
{
    public interface Writer : IDisposable
    {
        IDisposable Indent();
        void Write(string text);
        void WriteLine();
        void WriteLine(string text);
    }
}
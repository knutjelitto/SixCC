using System;

namespace SixCC.Sdk.Output
{
    public interface IWriter
    {
        void Write(string text);

        void WriteLine(string text);

        void WriteLine();

        void Write(object obj);

        void WriteLine(object obj);

        void Indent(Action body);
    }
}

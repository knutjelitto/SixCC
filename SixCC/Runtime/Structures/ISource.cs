using System;
using System.Collections.Generic;
using System.Text;

namespace SixCC.Runtime.Structures
{
    public interface ISource
    {
        int this[int index] { get; }
        int Length { get; }
        string Name { get; }
        (int lineNumber, int columnNumber) GetLineAndColumn(int index);
        string GetText(int start, int length);
        bool IsEnd(int index);
        void IndexNewline(int index);
    }
}

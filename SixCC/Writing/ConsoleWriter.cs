using System;

namespace SixCC.Writing
{
    public class ConsoleWriter : TextWriter
    {
        public ConsoleWriter()
            : base(Console.Out)
        {
        }
    }
}

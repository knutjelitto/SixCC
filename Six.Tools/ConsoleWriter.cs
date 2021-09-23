using System;

namespace Six.Tools
{
    public class ConsoleWriter : IndentWriter
    {
        public ConsoleWriter() : base(new BaseTextWriter(Console.Out)) { }
    }
}

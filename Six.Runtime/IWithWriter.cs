using Six.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Runtime
{
    public interface IWithWriter
    {
        Writer Writer { get; }

        public void wl(string content) => Writer.WriteLine(content);
        public void wl() => Writer.WriteLine();
        public void w(string content) => Writer.Write(content);
        public void indent(Action content)
        {
            using (Writer.Indent())
            {
                content();
            }
        }
    }
}

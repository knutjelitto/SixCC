using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixCC.Writing
{
    public class TextWriter : WriterCore
    {
        public TextWriter(System.IO.TextWriter writer)
            : base(new IndentedTextWriter(writer))
        {
        }

        public override void Dispose()
        {
        }
    }
}

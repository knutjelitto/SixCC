using SixCC.Writing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixCC.CC.Errors
{
    public abstract class Diagnostic
    {
        public Diagnostic(Level level)
        {
            Level = level;
        }

        public Level Level { get; }

        public abstract void Report(Writer writer);
    }
}

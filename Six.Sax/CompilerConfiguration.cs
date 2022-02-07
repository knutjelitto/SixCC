using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Sax
{
    public class CompilerConfiguration
    {
        public bool WithRuleIndex { get; init; }
        public bool DumpSppf { get; init; }
        public bool DumpTree { get; init; }
        public bool BuildAst { get; init; }
        public bool DumpAst { get; init; }
        public bool BuildTypes { get; init; }
    }
}

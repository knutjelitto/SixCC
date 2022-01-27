using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Ceylon
{
    public class CompilerConfiguration
    {
        public bool WithRuleIndex { get; init; }
        public bool DumpSppf { get; init; }
        public bool DumpTree { get; init; }
        public bool BuildAst { get; init; }
    }
}

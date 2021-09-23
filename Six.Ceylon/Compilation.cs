using Antlr4.Runtime;
using Six.Ceylon.Ast;
using Six.Tools;
using System;

namespace Six.Ceylon
{
    public class Compilation
    {
        public Compilation(FileRef file, CompileStatistics stats, CompilationUnit unit, CeylonParser.CompilationUnitContext context)
        {
            File = file;
            Stats = stats;
            Unit = unit;
            Context = context;
        }

        public FileRef File { get; }
        public CompileStatistics Stats { get; }
        public CompilationUnit Unit { get; }
        public CeylonParser.CompilationUnitContext Context { get; }
    }
}

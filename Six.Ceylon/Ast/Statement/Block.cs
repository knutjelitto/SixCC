using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Ceylon.Ast
{
    public sealed class Block
    {
        public Block(ImportList imports, StatementList statements)
        {
            Imports = imports;
            Statements = statements;
        }

        public ImportList Imports { get; }
        public StatementList Statements { get; }
    }
}

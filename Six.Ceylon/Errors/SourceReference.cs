using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using Six.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Ceylon.Errors
{
    public class SourceReference
    {
        public SourceReference(IParseTree tree, FileRef file, ITokenStream tokens, ICharStream characters)
        {
            File = file;
            Tree = tree;
            Tokens = tokens;
            Characters = characters;
        }

        public FileRef File { get; }
        public IParseTree Tree { get; }
        public ITokenStream Tokens { get; }
        public ICharStream Characters { get; }

        public int LineNo => Tokens.Get(Tree.SourceInterval.a).Line;
        public int ColumnNo => Tokens.Get(Tree.SourceInterval.a).Column + 1;
    }
}

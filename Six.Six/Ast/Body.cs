﻿using Six.Runtime.Types;

namespace Six.Six.Ast
{
    public interface Body : TreeNode
    {
        public sealed record Deferred(IRNode Tree) : Body;
        public sealed record Expr(IRNode Tree, Expression Expression) : Body;
        public sealed record Block(IRNode Tree, Usings Usings, Statelarations Statelarations) : Body;
        public sealed record Class(IRNode Tree, Usings Usings, Declarations Declarations) : Body;
    }
}

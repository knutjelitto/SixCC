namespace Six.Ceylon.Ast
{
    public interface Stmt : AstNode
    {
        public sealed record Core : Stmt;

        public record ConditionalBlock(Conditions Conditions, Block Block) : Stmt;

        public sealed record Break : Stmt;

        public sealed record Continue : Stmt;

        public sealed record Return(Ast.Expr? Expr) : Stmt;

        public sealed record Throw(Ast.Expr? Expr) : Stmt;

        public sealed record If(IEnumerable<ConditionalBlock> Conditionals, Block? ElseBlock) : Stmt;

        public sealed record For(Misc.ForIterator? Iterator, Block Block, Block? ElseBlock) : Stmt;

        public sealed record While(Conditions Conditions, Block Block) : ConditionalBlock(Conditions, Block);

        public sealed record Let(LetVariableList Lets) : Stmt;

        public sealed record Try(ResourceList? Resources, Block Block, CatchBlockList Catches, Block? Finally) : Stmt;

        public sealed record Specification(Ast.Expr Primary, Ast.Expr Value) : Stmt;

        public sealed record Expression(Ast.Expr Expr) : Stmt;

        public sealed record Assertion(String? Message, Conditions Conditions) : Stmt;

        public sealed record Switch(Expr Head, CaseList Cases, Block? Else) : Stmt;
        public sealed record Case(CaseItem Item, Block Block) : AstNode;
        public sealed record CaseList(IEnumerable<Case> cases) : ReadOnlyList<Case>(cases);
    }
}

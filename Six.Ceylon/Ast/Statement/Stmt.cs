namespace Six.Ceylon.Ast
{
    public interface Stmt
    {
        public sealed record Core : Stmt;

        public record ConditionalBlock(ConditionList Conditions, Block Block) : Stmt;

        public sealed record Break : Stmt;

        public sealed record Continue : Stmt;

        public sealed record Return(Ast.Expr? Expr) : Stmt;

        public sealed record Throw(Ast.Expr? Expr) : Stmt;

        public sealed record If(IEnumerable<ConditionalBlock> Conditionals, Block? ElseBlock) : Stmt;

        public sealed record For(Misc.ForIterator? Iterator, Block Block, Block? ElseBlock) : Stmt;

        public sealed record While(ConditionList Conditions, Block Block) : ConditionalBlock(Conditions, Block);

        public sealed record Let(LetList Lets) : Stmt;

        public sealed record Try(ResourceList? Resources, Block Block, CatchBlockList Catches, Block? Finally) : Stmt;

        public sealed record Specification(Ast.Expr Primary, Ast.Expr Value) : Stmt;

        public sealed record Expression(Ast.Expr Expr) : Stmt;

        public sealed record Assertion(String? Message, ConditionList Conditions) : Stmt;

        public sealed record Switch(Expr Head, CaseList Cases, Block? Else) : Stmt;
        public sealed record Case(CaseItem Item, Block Block);
        public sealed record CaseList(IEnumerable<Case> cases) : ReadOnlyList<Case>(cases.ToList());
    }
}

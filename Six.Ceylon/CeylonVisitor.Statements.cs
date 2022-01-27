using Six.Ceylon.Ast;
using static Six.Ceylon.CeylonTree;

namespace Six.Ceylon
{
    public partial class CeylonVisitor
    {
        protected override void Visit(CStatements element)
        {
            var statements = element.Children.Select(child => Walk<Statement>(child));

            element.Value = new StatementList(statements);
        }

        protected override void Visit(CUnclosedStatement element)
        {
            Walk(element.OpenStatement);

            element.Value = element.OpenStatement.Value is IExpression expression
                ? new Statement.Expression(expression)
                : element.OpenStatement.Value!;
        }

        protected override void Visit(CSpecificationStatement element)
        {
            var primary = Walk<IExpression>(element.Primary);
            var specifier = Walk<IExpression>(element.FunctionSpecifier);

            element.Value = new Statement.Specification(primary, specifier);
        }

        protected override void Visit(CAssertionStatement element)
        {
            var message = Walk<Ast.String>(element.AssertionMessageOptional);
            // 'assert'
            var conditions = Walk<ConditionList>(element.Conditions);

            element.Value = new Statement.Assertion(message, conditions);
        }

        protected override void Visit(CIfElseStatement element)
        {
            // 'if'
            var conditions = Walk<ConditionList>(element.Conditions);
            var block = Walk<Block>(element.Block);

            var ifBlock = new Statement.ConditionalBlock(conditions, block);
            var elseIfs = element.ElseIfStar.Children.Select(child => Walk<Statement.ConditionalBlock>(child));
            var elseBlock = Walk<Block>(element.ElseBlockOptional);

            var conditionals = Enumerable.Repeat(ifBlock, 1).Concat(elseIfs);
            //TODO
            element.Value = new Statement.If(conditionals, elseBlock);
        }

        protected override void Visit(CElseIf element)
        {
            // 'else'
            // 'if'
            var conditions = Walk<ConditionList>(element.Conditions);
            var block = Walk<Block>(element.Block);

            element.Value = new Statement.ConditionalBlock(conditions, block);
        }

        protected override void Visit(CForElseStatement element)
        {
            WalkChildren(element);

            //TODO
            element.Value = new Statement();
        }

        protected override void Visit(CReturnStatement element)
        {
            var expr = Walk<IExpression>(element.ExpressionOptional);
            element.Value = new Statement.Return(expr);
        }

        protected override void Visit(CThrowStatement element)
        {
            var expr = Walk<IExpression>(element.ExpressionOptional);
            element.Value = new Statement.Throw(expr);
        }

        protected override void Visit(CBreakStatement element)
        {
            element.Value = new Statement.Break();
        }

        protected override void Visit(CContinueStatement element)
        {
            element.Value = new Statement.Continue();
        }

        protected override void Visit(CSwitchStatement element)
        {
            WalkChildren(element);

            //TODO
            element.Value = new Statement();
        }

        protected override void Visit(CWhileStatement element)
        {
            var conditions = Walk<ConditionList>(element.Conditions);
            var block = Walk<Block>(element.Block);

            element.Value = new Statement.While(conditions, block);
        }

        protected override void Visit(CLetStatement element)
        {
            WalkChildren(element);
        }

        protected override void Visit(CTryStatement element)
        {
            WalkChildren(element);

            //TODO
            element.Value = new Statement();
        }

        /*---------------------------------------------------------------------
         *  Statements - Interns
         *--------------------------------------------------------------------*/
        protected override void Visit(CElseBlock element)
        {
            // 'else'
            element.Value = Walk<Block>(element.Block);
        }

        protected override void Visit(CFailBlock element)
        {
            // 'else'
            element.Value = Walk<Block>(element.Block);
        }

        protected override void Visit(CForBlock element)
        {
            //TODO
            WalkChildren(element);
        }

        protected override void Visit(CTryBlock element)
        {
            //TODO
            WalkChildren(element);
        }

        protected override void Visit(CCatchBlock element)
        {
            //TODO
            WalkChildren(element);
        }

        protected override void Visit(CCatchVariable element)
        {
            //TODO
            WalkChildren(element);
        }

        protected override void Visit(CResources element)
        {
            //TODO
            WalkChildren(element);
        }

        protected override void Visit(CResourceList element)
        {
            //TODO
            WalkChildren(element);
        }

        protected override void Visit(CCaseBlock element)
        {
            //TODO
            WalkChildren(element);
        }

        protected override void Visit(CFinallyBlock element)
        {
            //TODO
            WalkChildren(element);
        }

        protected override void Visit(CForIterator element)
        {
            //TODO
            WalkChildren(element);
        }

        protected override void Visit(CContainment element)
        {
            //TODO
            WalkChildren(element);
        }
    }
}

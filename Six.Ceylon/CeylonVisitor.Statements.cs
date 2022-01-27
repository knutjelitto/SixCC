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
            if (element.OpenStatement.Value is IExpression expression)
            {
                element.Value = new ExpressionStmt(expression);
            }
            else
            {
                element.Value = (Statement)element.OpenStatement.Value!;
            }
        }

        protected override void Visit(CSpecificationStatement element)
        {
            var primary = Walk<IExpression>(element.Primary);
            var specifier = Walk<IExpression>(element.FunctionSpecifier);

            element.Value = new SpecificationStmt(primary, specifier);
        }

        protected override void Visit(CAssertionStatement element)
        {
            var message = Walk<Ast.String>(element.AssertionMessageOptional);
            // 'assert'
            var conditions = Walk<ConditionList>(element.Conditions);

            element.Value = new AssertionStmt(message, conditions);
        }

        protected override void Visit(CIfElseStatement element)
        {
            WalkChildren(element);

            //TODO
            element.Value = new Statement();
        }

        protected override void Visit(CForElseStatement element)
        {
            WalkChildren(element);

            //TODO
            element.Value = new Statement();
        }

        protected override void Visit(CReturnStatement element)
        {
            WalkChildren(element);

            //TODO
            element.Value = new Statement();
        }

        protected override void Visit(CBreakStatement element)
        {
            WalkChildren(element);

            //TODO
            element.Value = new Statement();
        }

        protected override void Visit(CContinueStatement element)
        {
            WalkChildren(element);
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

            element.Value = new WhileStmt(conditions, block);
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

        protected override void Visit(CThrowStatement element)
        {
            WalkChildren(element);
        }

        /*---------------------------------------------------------------------
         *  Statements - Interns
         *--------------------------------------------------------------------*/
        protected override void Visit(CIfBlock element)
        {
            WalkChildren(element);
        }

        protected override void Visit(CElseBlock element)
        {
            WalkChildren(element);
        }

        protected override void Visit(CFailBlock element)
        {
            WalkChildren(element);
        }

        protected override void Visit(CForBlock element)
        {
            WalkChildren(element);
        }

        protected override void Visit(CTryBlock element)
        {
            WalkChildren(element);
        }

        protected override void Visit(CCatchBlock element)
        {
            WalkChildren(element);
        }

        protected override void Visit(CCatchVariable element)
        {
            WalkChildren(element);
        }

        protected override void Visit(CResources element)
        {
            WalkChildren(element);
        }

        protected override void Visit(CResourceList element)
        {
            WalkChildren(element);
        }

        protected override void Visit(CCaseBlock element)
        {
            WalkChildren(element);
        }

        protected override void Visit(CFinallyBlock element)
        {
            WalkChildren(element);
        }

        protected override void Visit(CForIterator element)
        {
            WalkChildren(element);
        }

        protected override void Visit(CContainment element)
        {
            WalkChildren(element);
        }


    }
}

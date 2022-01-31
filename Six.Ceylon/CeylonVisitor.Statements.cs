using Six.Ceylon.Ast;
using static Six.Ceylon.CeylonTree;

namespace Six.Ceylon
{
    public partial class CeylonVisitor
    {
        protected override void Visit(CStatements element)
        {
            var statements = element.Children.Select(child => Walk<Stmt>(child));

            element.Value = new StatementList(statements);
        }

        protected override void Visit(CUnclosedStatement element)
        {
            Walk(element.OpenStatement);

            element.Value = element.OpenStatement.Value is Expr expression
                ? new Stmt.Expression(expression)
                : element.OpenStatement.Value!;
        }

        protected override void Visit(CSpecificationStatement element)
        {
            var primary = Walk<Expr>(element.Primary);
            var specifier = Walk<Expr>(element.FunctionSpecifier);

            element.Value = new Stmt.Specification(primary, specifier);
        }

        protected override void Visit(CAssertionStatement element)
        {
            var message = Walk<Ast.String>(element.AssertionMessage);
            // 'assert'
            var conditions = Walk<Conditions>(element.Conditions);

            element.Value = new Stmt.Assertion(message, conditions);
        }

        protected override void Visit(CIfElseStatement element)
        {
            // 'if'
            var conditions = Walk<Conditions>(element.Conditions);
            var block = Walk<Block>(element.Block);

            var ifBlock = new Stmt.ConditionalBlock(conditions, block);
            var elseIfs = element.ElseIf.Children.Select(child => Walk<Stmt.ConditionalBlock>(child));
            var elseBlock = Walk<Block>(element.ElseBlock);

            var conditionals = Enumerable.Repeat(ifBlock, 1).Concat(elseIfs);
            //TODO
            element.Value = new Stmt.If(conditionals, elseBlock);
        }

        protected override void Visit(CElseIf element)
        {
            // 'else'
            // 'if'
            var conditions = Walk<Conditions>(element.Conditions);
            var block = Walk<Block>(element.Block);

            element.Value = new Stmt.ConditionalBlock(conditions, block);
        }

        protected override void Visit(CForElseStatement element)
        {
            var iterator = Walk<Misc.ForIterator>(element.ForIterator);
            var block = Walk<Block>(element.Block);
            var elseBlock = Walk<Block>(element.ElseBlock);

            element.Value = new Stmt.For(iterator, block, elseBlock);
        }

        protected override void Visit(CReturnStatement element)
        {
            var expr = Walk<Expr>(element.Expression);

            element.Value = new Stmt.Return(expr);
        }

        protected override void Visit(CThrowStatement element)
        {
            var expr = Walk<Expr>(element.Expression);

            element.Value = new Stmt.Throw(expr);
        }

        protected override void Visit(CBreakStatement element)
        {
            element.Value = new Stmt.Break();
        }

        protected override void Visit(CContinueStatement element)
        {
            element.Value = new Stmt.Continue();
        }

        protected override void Visit(CSwitchStatement element)
        {
            var head = Walk<Expr>(element.SwitchHeader);
            var cases = new Stmt.CaseList(WalkMany<Stmt.Case>(element.CaseBlock));
            var @else = Walk<Block>(element.ElseBlock);

            element.Value = new Stmt.Switch(head, cases, @else);
        }

        protected override void Visit(CWhileStatement element)
        {   
            var conditions = Walk<Conditions>(element.Conditions);
            var block = Walk<Block>(element.Block);

            element.Value = new Stmt.While(conditions, block);
        }

        protected override void Visit(CLetStatement element)
        {
            var lets = Walk<LetVariableList>(element.LetVariableList);

            element.Value = new Stmt.Let(lets);
        }

        protected override void Visit(CTryStatement element)
        {
            var resources = Walk<ResourceList>(element.Resources);
            var block = Walk<Block>(element.Block);
            var catches = new CatchBlockList(element.CatchBlock.Children.Select(child => Walk<CatchBlock>(child)));
            var final = Walk<Block>(element.FinallyBlock);

            //TODO
            element.Value = new Stmt.Try(resources, block, catches, final);
        }

        /*---------------------------------------------------------------------
         *  Statements - Interns
         *--------------------------------------------------------------------*/
        protected override void Visit(CElseBlock element)
        {
            // 'else'
            element.Value = Walk<Block>(element.Block);
        }

        protected override void Visit(CCatchBlock element)
        {
            var variable = Walk<Pattern.Variable>(element.Variable);
            var block = Walk<Block>(element.Block);

            element.Value = new CatchBlock(variable, block);
        }

        protected override void Visit(CFinallyBlock element)
        {
            element.Value = Walk<Block>(element.Block);
        }

        protected override void Visit(CResources element)
        {
            element.Value = Walk<ResourceList>(element.ResourceList);
        }

        protected override void Visit(CResourceList element)
        {
            var items = element.Elements.Select(child => Walk<Resource>(child));
            var list = new ResourceList(items);

            element.Value = list;
        }

        protected override void Visit(CCaseBlock element)
        {
            var item = Walk<CaseItem>(element.CaseItem);
            var block = Walk<Block>(element.Block);

            element.Value = new Stmt.Case(item, block);
        }

        protected override void Visit(CForIterator element)
        {
            var pattern = Walk<Pattern>(element.ForVariable);
            var containment = Walk<Misc.Containment>(element.Containment);

            element.Value = new Misc.ForIterator(pattern, containment);
        }

        protected override void Visit(CContainment element)
        {
            var op = element.ContainmentOperator.GetText();
            var expr = Walk<Expr>(element.OperatorExpression);

            element.Value = new Misc.Containment(op, expr);
        }
    }
}

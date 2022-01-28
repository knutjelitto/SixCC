using Six.Ceylon.Ast;
using static Six.Ceylon.CeylonTree;

namespace Six.Ceylon
{
    public partial class CeylonVisitor
    {
        protected override void Visit(CAssignmentExpr element)
        {
            var left = Walk<IExpression>(element.ThenElseExpression);
            var op = element.AssignmentOperator.GetText();
            var right = Walk<IExpression>(element.Expression);

            element.Value = new Expression.Infix(op, left, right);
        }

        protected override void Visit(CLargerExpr element)
        {
            var left = Walk<IExpression>(element.ExistsNonemptyExpression);
            var op = element.LargerOperator.GetText();
            var right = Walk<IExpression>(element.ExistsNonemptyExpression2);

            element.Value = new Expression.Infix(op, left, right);
        }

        protected override void Visit(CSmallerExpr element)
        {
            var left = Walk<IExpression>(element.ExistsNonemptyExpression);
            var op = element.SmallerOperator.GetText();
            var right = Walk<IExpression>(element.ExistsNonemptyExpression2);

            element.Value = new Expression.Infix(op, left, right);
        }

        protected override void Visit(CAdditiveExpr element)
        {
            var left = Walk<IExpression>(element.AdditiveExpression);
            var op = element.AdditiveOperator.GetText();
            var right = Walk<IExpression>(element.ScaleExpression);

            element.Value = new Expression.Infix(op, left, right);
        }

        protected override void Visit(CSelectionExpr element)
        {
            var left = Walk<IExpression>(element.Primary);
            var op = element.MemberSelectionOperator.GetText();
            var right = Walk<IExpression>(element.BaseReference);

            element.Value = new Expression.Infix(op, left, right);
        }

        protected override void Visit(CMultiplicativeExpr element)
        {
            var left = Walk<IExpression>(element.MultiplicativeExpression);
            var op = element.MultiplicativeOperator.GetText();
            var right = Walk<IExpression>(element.UnionExpression);

            element.Value = new Expression.Infix(op, left, right);
        }

        protected override void Visit(CThenElseExpr element)
        {
            var left = Walk<IExpression>(element.ThenElseExpression);
            var op = element.ThenElseOperator.GetText();
            var right = Walk<IExpression>(element.DisjunctionExpression);

            element.Value = new Expression.Infix(op, left, right);
        }

        protected override void Visit(CEqualityExpr element)
        {
            var left = Walk<IExpression>(element.ComparisonExpression);
            var op = element.EqualityOperator.GetText();
            var right = Walk<IExpression>(element.ComparisonExpression2);

            element.Value = new Expression.Infix(op, left, right);
        }

        protected override void Visit(CConjunctionExpr element)
        {
            var left = Walk<IExpression>(element.ConjunctionExpression);
            var op = element.ConjunctionOperator.GetText();
            var right = Walk<IExpression>(element.LogicalNegationExpression);

            element.Value = new Expression.Infix(op, left, right);
        }

        protected override void Visit(CComparisonExpr element)
        {
            var left = Walk<IExpression>(element.ExistsNonemptyExpression);
            var op = element.ComparisonOperator.GetText();
            var right = Walk<IExpression>(element.ExistsNonemptyExpression2);

            element.Value = new Expression.Infix(op, left, right);
        }

        protected override void Visit(CDisjunctionExpr element)
        {
            var left = Walk<IExpression>(element.DisjunctionExpression);
            var op = element.DisjunctionOperator.GetText();
            var right = Walk<IExpression>(element.ConjunctionExpression);

            element.Value = new Expression.Infix(op, left, right);
        }

        protected override void Visit(CRangeExpr element)
        {
            var left = Walk<IExpression>(element.AdditiveExpression);
            var op = element.RangeOperator.GetText();
            var right = Walk<IExpression>(element.AdditiveExpression2);

            element.Value = new Expression.Infix(op, left, right);
        }

        protected override void Visit(CPostfixExpr element)
        {
            var expr = Walk<IExpression>(element.PostfixExpression);
            var op = element.IncrementOperator.GetText();

            element.Value = new Expression.Postfix(expr, op);
        }

        protected override void Visit(CPrefixExpr element)
        {
            var op = element.IncrementOperator.GetText();
            var expr = Walk<IExpression>(element.PrefixExpression);

            element.Value = new Expression.Prefix(op, expr);
        }

        protected override void Visit(CNegationOrComplementExpr element)
        {
            var op = Walk<string>(element.UnaryMinusOrComplementOperator);
            var right = Walk<IExpression>(element.NegationOrComplementExpression);

            element.Value = new Expression.Prefix(op, right);
        }

        protected override void Visit(CLogicalNegationExpr element)
        {
            var op = element.NotOperator.GetText();
            var right = Walk<IExpression>(element.LogicalNegationExpression);

            element.Value = new Expression.Prefix(op, right);
        }

        protected override void Visit(CCallExpr element)
        {
            var primary = Walk<IExpression>(element.Primary);
            var arguments = Walk<Arguments>(element.Arguments);

            element.Value = new Expression.Call(primary, arguments);
        }

        protected override void Visit(CParametrizedMember element)
        {
            WalkChildrenTodo(element);

            element.Value = new Expression();
        }

        protected override void Visit(CInferredFunctionExpr element)
        {
            var typeParameters = Walk<TypeParameterList>(element.TypeParameters);
            var items = element.Parameters.Children.Select(child => Walk<ParameterList>(child));
            var parameters = new ParameterListList(items); ;
            var constraints = Walk<ConstraintList>(element.TypeConstraints);
            var definition = Walk<IExpression>(element.FunctionDefinition);

            element.Value = new Expression.InferredFunction(typeParameters, parameters, constraints, definition);
        }

        protected override void Visit(CVoidFunctionExpr element)
        {
            var typeParameters = Walk<TypeParameterList>(element.TypeParameters);
            var items = element.Parameters.Children.Select(child => Walk<ParameterList>(child));
            var parameters = new ParameterListList(items); ;
            var constraints = Walk<ConstraintList>(element.TypeConstraints);
            var definition = Walk<IExpression>(element.FunctionDefinition);

            element.Value = new Expression.VoidFunction(typeParameters, parameters, constraints, definition);
        }


        protected override void Visit(CIfExpr element)
        {
            // 'if'
            var conditions = Walk<ConditionList>(element.Conditions);
            var thenExpr = Walk<IExpression>(element.ThenExpression);
            var elseExpr = Walk<IExpression>(element.ElseExpression);

            element.Value = new Expression.If(conditions, thenExpr, elseExpr);
        }

        protected override void Visit(CTupleExpr element)
        {
            WalkChildrenTodo(element);

            //TODO
            element.Value = new Expression();
        }

        protected override void Visit(CIndexedExpr element)
        {
            var expr = Walk<IExpression>(element.Primary);
            var index = Walk<IExpression>(element.Index);

            element.Value = new Expression.Indexed(expr, index);
        }

        protected override void Visit(CEntryExpr element)
        {
            WalkChildrenTodo(element);

            //TODO
            element.Value = new Expression();
        }

        protected override void Visit(CObjectExpr element)
        {
            WalkChildrenTodo(element);

            //TODO
            element.Value = new Expression();
        }

        protected override void Visit(CGroupedExpr element)
        {
            element.Value = Walk<IExpression>(element.Expression);
        }

        protected override void Visit(CEnumerationExpr element)
        {
            WalkChildrenTodo(element);

            //TODO
            element.Value = new Expression();
        }

        protected override void Visit(CTypecheckExpr element)
        {
            WalkChildrenTodo(element);

            //TODO
            element.Value = new Expression();
        }

        protected override void Visit(CExistsExpr element)
        {
            WalkChildrenTodo(element);

            //TODO
            element.Value = new Expression();
        }

        protected override void Visit(CNonemptyExpr element)
        {
            WalkChildrenTodo(element);

            //TODO
            element.Value = new Expression();
        }

        protected override void Visit(CSwitchExpr element)
        {
            WalkChildrenTodo(element);

            //TODO
            element.Value = new Expression();
        }

        protected override void Visit(CLetExpr element)
        {
            WalkChildrenTodo(element);

            //TODO
            element.Value = new Expression();
        }

        protected override void Visit(CExclusiveExpr element)
        {
            WalkChildrenTodo(element);

            //TODO
            element.Value = new Expression();
        }

        protected override void Visit(CStringInterpolation element)
        {
            var start = Walk<StartInterpolationString>(element.StringStart);
            var end = Walk<EndInterpolationString>(element.StringEnd);
            var mids = element.InterpolationPart.Select(part => Walk<MidInterpolationString>(part.StringMid));
            var strings = Enumerable.Repeat<Ast.InterpolationString>(start, 1)
                .Concat(mids.Cast<Ast.InterpolationString>())
                .Concat(Enumerable.Repeat<Ast.InterpolationString>(end, 1));
            var first = Walk<IExpression>(element.Expression);
            var rest = element.InterpolationPart.Select(part => Walk<IExpression>(part.Expression));
            var expressions = Enumerable.Repeat(first, 1).Concat(rest);

            element.Value = new Expression.Interpolation(strings.ToList(), expressions.ToList());
        }

        protected override void Visit(CInterpolationPart element)
        {
            WalkChildrenTodo(element);
        }

        protected override void Visit(CSmallerBoundsExpr element)
        {
            var left = Walk<IExpression>(element.ExistsNonemptyExpression);
            var op1 = element.SmallerOperator.GetText();
            var mid = Walk<IExpression>(element.ExistsNonemptyExpression2);
            var op2 = element.SmallerOperator2.GetText();
            var right = Walk<IExpression>(element.ExistsNonemptyExpression3);

            element.Value = new Expression.Infix2(left, op1, mid, op2, right);
        }

        /*---------------------------------------------------------------------
         *  Expression - Inners
         *--------------------------------------------------------------------*/
        protected override void Visit(CThenExpression element)
        {
            var op = element.Literal.GetText();
            var right = Walk<IExpression>(element.ConditionalExpression);

            element.Value = new Expression.Prefix(op, right);
        }

        protected override void Visit(CElseExpression element)
        {
            var op = element.Literal.GetText();
            var right = Walk<IExpression>(element.ConditionalExpression);

            element.Value = new Expression.Prefix(op, right);
        }

        protected override void Visit(CSwitchHeader element)
        {
            WalkChildrenTodo(element);
        }

        protected override void Visit(CCaseExpressions element)
        {
            WalkChildrenTodo(element);
        }

        protected override void Visit(CCaseExpression element)
        {
            WalkChildrenTodo(element);
        }

        protected override void Visit(CIsCaseCondition element)
        {
            WalkChildrenTodo(element);
        }

        protected override void Visit(CLetVariableList element)
        {
            WalkChildrenTodo(element);
        }

        protected override void Visit(CSpanned element)
        {
            var from = Walk<IExpression>(element.IndexExpression);
            var to = Walk<IExpression>(element.IndexExpression2);

            element.Value = new Expression.SpanIndex(from, to);
        }

        protected override void Visit(CMeasured element)
        {
            var from = Walk<IExpression>(element.IndexExpression);
            var count = Walk<IExpression>(element.IndexExpression2);

            element.Value = new Expression.MeasureIndex(from, count);
        }

        protected override void Visit(CLowerSpanned element)
        {
            var to = Walk<IExpression>(element.IndexExpression);

            element.Value = new Expression.ToIndex(to);
        }

        protected override void Visit(CUpperSpanned element)
        {
            var from = Walk<IExpression>(element.IndexExpression);

            element.Value = new Expression.FromIndex(from);
        }
    }
}

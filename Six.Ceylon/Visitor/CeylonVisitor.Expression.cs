using Six.Ceylon.Ast;
using Six.Runtime.Types;
using static Six.Ceylon.CeylonTree;

namespace Six.Ceylon.Visitor
{
    public partial class CeylonVisitor
    {
        protected override void Visit(CAssignmentExpr element)
        {
            var left = Walk<Expr>(element.ThenElseExpression);
            var op = element.AssignmentOperator.GetText();
            var right = Walk<Expr>(element.Expression);

            element.Value = new Expr.Infix(op, left, right);
        }

        protected override void Visit(CLargerExpr element)
        {
            var left = Walk<Expr>(element.ExistsNonemptyExpression);
            var op = element.LargerOperator.GetText();
            var right = Walk<Expr>(element.ExistsNonemptyExpression2);

            element.Value = new Expr.Infix(op, left, right);
        }

        protected override void Visit(CSmallerExpr element)
        {
            var left = Walk<Expr>(element.ExistsNonemptyExpression);
            var op = element.SmallerOperator.GetText();
            var right = Walk<Expr>(element.ExistsNonemptyExpression2);

            element.Value = new Expr.Infix(op, left, right);
        }

        protected override void Visit(CAdditiveExpr element)
        {
            var left = Walk<Expr>(element.AdditiveExpression);
            var op = element.AdditiveOperator.GetText();
            var right = Walk<Expr>(element.ScaleExpression);

            element.Value = new Expr.Infix(op, left, right);
        }

        protected override void Visit(CSelectionExpr element)
        {
            var left = Walk<Expr>(element.Primary);
            var op = element.MemberSelectionOperator.GetText();
            var right = Walk<Expr>(element.BaseReference);

            element.Value = new Expr.Infix(op, left, right);
        }

        protected override void Visit(CMultiplicativeExpr element)
        {
            var left = Walk<Expr>(element.MultiplicativeExpression);
            var op = element.MultiplicativeOperator.GetText();
            var right = Walk<Expr>(element.UnionExpression);

            element.Value = new Expr.Infix(op, left, right);
        }

        protected override void Visit(CThenElseExpr element)
        {
            var left = Walk<Expr>(element.ThenElseExpression);
            var op = element.ThenElseOperator.GetText();
            var right = Walk<Expr>(element.DisjunctionExpression);

            element.Value = new Expr.Infix(op, left, right);
        }

        protected override void Visit(CEqualityExpr element)
        {
            var left = Walk<Expr>(element.ComparisonExpression);
            var op = element.EqualityOperator.GetText();
            var right = Walk<Expr>(element.ComparisonExpression2);

            element.Value = new Expr.Infix(op, left, right);
        }

        protected override void Visit(CConjunctionExpr element)
        {
            var left = Walk<Expr>(element.ConjunctionExpression);
            var op = element.ConjunctionOperator.GetText();
            var right = Walk<Expr>(element.LogicalNegationExpression);

            element.Value = new Expr.Infix(op, left, right);
        }

        protected override void Visit(CComparisonExpr element)
        {
            var left = Walk<Expr>(element.ExistsNonemptyExpression);
            var op = element.ComparisonOperator.GetText();
            var right = Walk<Expr>(element.ExistsNonemptyExpression2);

            element.Value = new Expr.Infix(op, left, right);
        }

        protected override void Visit(CDisjunctionExpr element)
        {
            var left = Walk<Expr>(element.DisjunctionExpression);
            var op = element.DisjunctionOperator.GetText();
            var right = Walk<Expr>(element.ConjunctionExpression);

            element.Value = new Expr.Infix(op, left, right);
        }

        protected override void Visit(CRangeExpr element)
        {
            var left = Walk<Expr>(element.AdditiveExpression);
            var op = element.RangeOperator.GetText();
            var right = Walk<Expr>(element.AdditiveExpression2);

            element.Value = new Expr.Infix(op, left, right);
        }

        protected override void Visit(CExclusiveExpr element)
        {
            var left = Walk<Expr>(element.ExclusiveExpression);
            var op = element.ExclusiveOperator.GetText();
            var right = Walk<Expr>(element.IntersectionExpression);

            element.Value = new Expr.Infix(op, left, right);
        }

        protected override void Visit(CPostfixExpr element)
        {
            var expr = Walk<Expr>(element.PostfixExpression);
            var op = element.IncrementOperator.GetText();

            element.Value = new Expr.PostfixIncDec(expr, op);
        }

        protected override void Visit(CPrefixExpr element)
        {
            var op = Walk<string>(element.IncrementOperator);
            var expr = Walk<Expr>(element.PrefixExpression);

            element.Value = new Expr.PrefixIncDec(op, expr);
        }

        protected override void Visit(CNegationOrComplementExpr element)
        {
            var op = Walk<string>(element.UnaryMinusOrComplementOperator);
            var right = Walk<Expr>(element.NegationOrComplementExpression);

            element.Value = new Expr.Prefix(op, right);
        }

        protected override void Visit(CLogicalNegationExpr element)
        {
            var op = element.NotOperator.GetText();
            var right = Walk<Expr>(element.LogicalNegationExpression);

            element.Value = new Expr.Prefix(op, right);
        }

        protected override void Visit(CCallExpr element)
        {
            var primary = Walk<Expr>(element.Primary);
            var arguments = Walk<Arguments>(element.Arguments);

            element.Value = new Expr.Call(primary, arguments);
        }

        protected override void Visit(CParametrizedMember element)
        {
            var name = Walk<Identifier>(element.MemberName);
            var typeParameters = Walk<TypeParameters>(element.TypeParameters);
            var parameters = new ParametersList(WalkMany<Parameters>(element.Parameters));

            element.Value = new Expr.Member(name, typeParameters, parameters);
        }

        protected override void Visit(CInferredFunctionExpr element)
        {
            var typeParameters = Walk<TypeParameters>(element.TypeParameters);
            var parameters = new ParametersList(WalkMany<Parameters>(element.Parameters)); ;
            var constraints = Walk<TypeConstraints>(element.TypeConstraints);
            var definition = Walk<Expr>(element.FunctionDefinition);

            element.Value = new Expr.InferredFunction(typeParameters, parameters, constraints, definition);
        }

        protected override void Visit(CVoidFunctionExpr element)
        {
            var typeParameters = Walk<TypeParameters>(element.TypeParameters);
            var parameters = new ParametersList(WalkMany<Parameters>(element.Parameters)); ;
            var constraints = Walk<TypeConstraints>(element.TypeConstraints);
            var definition = Walk<Expr>(element.FunctionDefinition);

            element.Value = new Expr.VoidFunction(typeParameters, parameters, constraints, definition);
        }


        protected override void Visit(CIfExpr element)
        {
            // 'if'
            var conditions = Walk<Conditions>(element.Conditions);
            var thenExpr = Walk<Expr>(element.ThenExpression);
            var elseExpr = Walk<Expr>(element.ElseExpression);

            element.Value = new Expr.If(conditions, thenExpr, elseExpr);
        }

        protected override void Visit(CTupleExpr element)
        {
            var arguments = Walk<ArgumentList>(element.SequencedArgumentList) ?? new ArgumentList(Enumerable.Empty<Argument>());

            element.Value = new Expr.Tuple(arguments);
        }

        protected override void Visit(CIndexedExpr element)
        {
            var expr = Walk<Expr>(element.Primary);
            var index = Walk<Expr>(element.Index);

            element.Value = new Expr.Indexed(expr, index);
        }

        protected override void Visit(CEntryExpr element)
        {
            var left = Walk<Expr>(element.AdditiveExpression);
            var op = element.EntryOperator.GetText();
            var right = Walk<Expr>(element.AdditiveExpression2);

            element.Value = new Expr.Infix(op, left, right);
        }

        protected override void Visit(CObjectExpr element)
        {
            var extended = Walk<Extends>(element.ExtendedType);
            var satisfied = Walk<Satisfies>(element.SatisfiedTypes);
            var block = Walk<Block>(element.Block);

            element.Value = new Expr.Object(extended, satisfied, block);
        }

        protected override void Visit(CGroupedExpr element)
        {
            element.Value = Walk<Expr>(element.Expression);
        }

        protected override void Visit(CEnumerationExpr element)
        {
            var statements = Walk<StatementList>(element.Statements);
            var sequenced = Walk<ArgumentList>(element.SequencedArgumentList);

            element.Value = new Expr.Enumeration(statements, sequenced);
        }

        protected override void Visit(CTypecheckExpr element)
        {
            var expr = Walk<Expr>(element.ExistsNonemptyExpression);
            var op = element.TypeOperator.GetText();
            var type = Walk<Type>(element.Type);

            element.Value = new Expr.Typecheck(expr, op, type);
        }

        protected override void Visit(CExistsExpr element)
        {
            var expr = Walk<Expr>(element.EntryRangeExpression);

            element.Value = new Expr.Exists(expr);
        }

        protected override void Visit(CNonemptyExpr element)
        {
            var expr = Walk<Expr>(element.EntryRangeExpression);

            element.Value = new Expr.Nonempty(expr);
        }

        protected override void Visit(CSwitchExpr element)
        {
            var head = Walk<Expr>(element.SwitchHeader);
            var cases = new Expr.CaseList(WalkMany<Expr.Case>(element.CaseExpression));
            var elseExpr = Walk<Expr>(element.ElseExpression);

            element.Value = new Expr.Switch(head, cases, elseExpr);
        }

        protected override void Visit(CLetExpr element)
        {
            var lets = Walk<LetVariableList>(element.LetVariableList);
            var expr = Walk<Expr>(element.ConditionalExpression);

            element.Value = new Expr.Let(lets, expr);
        }

        protected override void Visit(CStringInterpolation element)
        {
            var start = Walk<StartInterpolationString>(element.StringStart);
            var end = Walk<EndInterpolationString>(element.StringEnd);
            var mids = element.InterpolationPart.Select(part => Walk<MidInterpolationString>(part.StringMid));
            var istrings = Enumerable.Repeat<Ast.InterpolationString>(start, 1)
                .Concat(mids.Cast<Ast.InterpolationString>())
                .Concat(Enumerable.Repeat<Ast.InterpolationString>(end, 1));
            var strings = new Expr.Strings(istrings);
            var first = Walk<Expr>(element.Expression);
            var rest = element.InterpolationPart.Select(part => Walk<Expr>(part.Expression));
            var expressions = new Expr.Expressions(Enumerable.Repeat(first, 1).Concat(rest));

            element.Value = new Expr.Interpolation(strings, expressions);
        }

        protected override void Visit(CInterpolationPart element)
        {
            WalkChildrenNever(element);
        }

        protected override void Visit(CSmallerBoundsExpr element)
        {
            var left = Walk<Expr>(element.ExistsNonemptyExpression);
            var op1 = element.SmallerOperator.GetText();
            var mid = Walk<Expr>(element.ExistsNonemptyExpression2);
            var op2 = element.SmallerOperator2.GetText();
            var right = Walk<Expr>(element.ExistsNonemptyExpression3);

            element.Value = new Expr.SmallerBounds(left, op1, mid, op2, right);
        }

        /*---------------------------------------------------------------------
         *  Expression - Inners
         *--------------------------------------------------------------------*/
        protected override void Visit(CThenExpression element)
        {
            var op = element.Literal.GetText();
            var right = Walk<Expr>(element.ConditionalExpression);

            element.Value = new Expr.Prefix(op, right);
        }

        protected override void Visit(CElseExpression element)
        {
            var op = element.Literal.GetText();
            var right = Walk<Expr>(element.ConditionalExpression);

            element.Value = new Expr.Prefix(op, right);
        }

        protected override void Visit(CSwitchHeader element)
        {
            var switched = Walk<Expr>(element.Switched);

            element.Value = switched;
        }

        protected override void Visit(CCaseExpression element)
        {
            var item = Walk<CaseItem>(element.CaseItem);
            var expr = Walk<Expr>(element.ConditionalExpression);

            element.Value = new Expr.Case(item, expr);
        }

        protected override void Visit(CIsCaseCondition element)
        {
            var type = Walk<Type>(element.Type);

            element.Value = new CaseItem.IsCase(type);
        }

        protected override void Visit(CLetVariableList element)
        {
            var items = WalkMany<Pattern.LetVariable>(element);

            element.Value = new LetVariableList(items);
        }

        protected override void Visit(CSpanned element)
        {
            var from = Walk<Expr>(element.IndexExpression);
            var to = Walk<Expr>(element.IndexExpression2);

            element.Value = new Expr.SpannedIndex(from, to);
        }

        protected override void Visit(CMeasured element)
        {
            var from = Walk<Expr>(element.IndexExpression);
            var count = Walk<Expr>(element.IndexExpression2);

            element.Value = new Expr.MeasuredIndex(from, count);
        }

        protected override void Visit(CLowerSpanned element)
        {
            var to = Walk<Expr>(element.IndexExpression);

            element.Value = new Expr.ToIndex(to);
        }

        protected override void Visit(CUpperSpanned element)
        {
            var from = Walk<Expr>(element.IndexExpression);

            element.Value = new Expr.FromIndex(from);
        }
    }
}

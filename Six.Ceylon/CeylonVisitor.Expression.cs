using Six.Ceylon.Ast;
using static Six.Ceylon.CeylonTree;

namespace Six.Ceylon
{
    public partial class CeylonVisitor
    {
        protected override void Visit(CAssignmentExpr element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CCallExpr element)
        {
            //TODO
            element.Value = new Expression();
        }

        protected override void Visit(CLargerExpr element)
        {
            //TODO
            element.Value = new Expression();
        }

        protected override void Visit(CSmallerExpr element)
        {
            //TODO
            element.Value = new Expression();
        }

        protected override void Visit(CAdditiveExpr element)
        {
            //TODO
            element.Value = new Expression();
        }

        protected override void Visit(CIfExpr element)
        {
            //TODO
            element.Value = new Expression();
        }

        protected override void Visit(CSelectionExpr element)
        {
            //TODO
            element.Value = new Expression();
        }

        protected override void Visit(CTupleExpr element)
        {
            //TODO
            element.Value = new Expression();
        }

        protected override void Visit(CFunctionExpr element)
        {
            //TODO
            element.Value = new Expression();
        }

        protected override void Visit(CIndexedExpr element)
        {
            //TODO
            element.Value = new Expression();
        }

        protected override void Visit(CPostfixExpr element)
        {
            //TODO
            element.Value = new Expression();
        }

        protected override void Visit(CPrefixExpr element)
        {
            //TODO
            element.Value = new Expression();
        }

        protected override void Visit(CEntryExpr element)
        {
            //TODO
            element.Value = new Expression();
        }

        protected override void Visit(CMultiplicativeExpr element)
        {
            //TODO
            element.Value = new Expression();
        }

        protected override void Visit(CObjectExpr element)
        {
            //TODO
            element.Value = new Expression();
        }

        protected override void Visit(CGroupedExpr element)
        {
            //TODO
            element.Value = new Expression();
        }

        protected override void Visit(CRangeExpr element)
        {
            //TODO
            element.Value = new Expression();
        }

        protected override void Visit(CEnumerationExpr element)
        {
            //TODO
            element.Value = new Expression();
        }

        protected override void Visit(CTypecheckExpr element)
        {
            //TODO
            element.Value = new Expression();
        }

        protected override void Visit(CThenElseExpr element)
        {
            //TODO
            element.Value = new Expression();
        }

        protected override void Visit(CExistsExpr element)
        {
            //TODO
            element.Value = new Expression();
        }

        protected override void Visit(CNonemptyExpr element)
        {
            //TODO
            element.Value = new Expression();
        }

        protected override void Visit(CLogicalNegationExpr element)
        {
            //TODO
            element.Value = new Expression();
        }

        protected override void Visit(CSwitchExpr element)
        {
            //TODO
            element.Value = new Expression();
        }

        protected override void Visit(CLetExpr element)
        {
            //TODO
            element.Value = new Expression();
        }

        protected override void Visit(CEqualityExpr element)
        {
            //TODO
            element.Value = new Expression();
        }

        protected override void Visit(CConjunctionExpr element)
        {
            //TODO
            element.Value = new Expression();
        }

        protected override void Visit(CNegationOrComplementExpr element)
        {
            //TODO
            element.Value = new Expression();
        }

        protected override void Visit(CComparisonExpr element)
        {
            //TODO
            element.Value = new Expression();
        }

        protected override void Visit(CExclusiveExpr element)
        {
            //TODO
            element.Value = new Expression();
        }

        protected override void Visit(CDisjunctionExpr element)
        {
            //TODO
            element.Value = new Expression();
        }
    }
}

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
            WalkChilden(element);
        }

        protected override void Visit(CLargerExpr element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CSmallerExpr element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CAdditiveExpr element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CIfExpr element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CSelectionExpr element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CTupleExpr element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CFunctionExpr element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CIndexedExpr element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CPostfixExpr element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CPrefixExpr element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CEntryExpr element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CMultiplicativeExpr element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CObjectExpr element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CGroupedExpr element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CRangeExpr element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CEnumerationExpr element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CTypecheckExpr element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CThenElseExpr element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CExistsExpr element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CNonemptyExpr element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CLogicalNegationExpr element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CSwitchExpr element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CLetExpr element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CEqualityExpr element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CConjunctionExpr element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CNegationOrComplementExpr element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CComparisonExpr element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CExclusiveExpr element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CDisjunctionExpr element)
        {
            //TODO
            element.Value = new Expression();
        }
    }
}

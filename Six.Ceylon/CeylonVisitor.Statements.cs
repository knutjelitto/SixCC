using static Six.Ceylon.CeylonTree;

namespace Six.Ceylon
{
    public partial class CeylonVisitor
    {
        protected override void Visit(CUnclosedStatement element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CSpecificationStatement element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CAssertionStatement element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CIfElseStatement element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CForElseStatement element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CReturnStatement element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CBreakStatement element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CContinueStatement element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CSwitchStatement element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CWhileStatement element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CLetStatement element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CTryStatement element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CThrowStatement element)
        {
            WalkChilden(element);
        }

        /*---------------------------------------------------------------------
         *  Statements - Interns
         *--------------------------------------------------------------------*/
        protected override void Visit(CIfBlock element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CElseBlock element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CFailBlock element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CForBlock element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CTryBlock element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CCatchBlock element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CCatchVariable element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CResources element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CResourceList element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CCaseBlock element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CFinallyBlock element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CForIterator element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CContainment element)
        {
            WalkChilden(element);
        }


    }
}

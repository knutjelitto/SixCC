using static Six.Ceylon.CeylonTree;

namespace Six.Ceylon
{
    public partial class CeylonVisitor
    {
        protected override void Visit(CTypeDefault element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CTypePath element)
        {
            //TODO: Visitor
            element.Value = new Ast.Type();
        }

        protected override void Visit(CSatisfiedTypes element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CExtendedType element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CTypeConstraints element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CTypeConstraint element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CUnionTypeList element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CPackageQualifiedType element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CEntryType element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CIntersectionTypeCore element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CUnionTypeCore element)
        {
            //TODO: Visitor
            element.Value = new Ast.Type();
        }

        protected override void Visit(CIterableType element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CGroupedType element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CTupleType element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CArrayType element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CNullableType element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CFunctionType element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CVariancedType element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CVariadicUnionType element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CSpreadType element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CFunctionExpressionType element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CDefaultedTypeList element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CTypeParameters element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CTypeParameterList element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CTypeParameter element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CCaseTypes element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CCaseTypeList element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CQualifiedCaseType element)
        {
            WalkChilden(element);
        }
    }
}

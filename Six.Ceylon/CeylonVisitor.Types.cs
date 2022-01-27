using Six.Ceylon.Ast;
using static Six.Ceylon.CeylonTree;

namespace Six.Ceylon
{
    public partial class CeylonVisitor
    {
        protected override void Visit(CSatisfiedTypes element)
        {
            // 'satisfies'
            var types = Walk<TypeList>(element.UnionTypeList);
            element.Value = new Satisfied(types);
        }

        protected override void Visit(CExtendedType element)
        {
            // 'extends'
            var instantiation = Walk<Instantiation>(element.ClassInstatiation);
            element.Value = new Extended(instantiation);
        }

        protected override void Visit(CTypeConstraints element)
        {
            WalkChildren(element);
        }

        protected override void Visit(CTypeConstraint element)
        {
            WalkChildren(element);
        }

        protected override void Visit(CCaseTypes element)
        {
            WalkChildren(element);
        }

        protected override void Visit(CCaseTypeList element)
        {
            WalkChildren(element);
        }

        protected override void Visit(CQualifiedCaseType element)
        {
            WalkChildren(element);
        }

        protected override void Visit(CTypeDefault element)
        {
            WalkChildren(element);
        }

        protected override void Visit(CTypePath element)
        {
            //TODO: Type
            element.Value = new Ast.Type();
        }

        protected override void Visit(CUnionTypeList element)
        {
            var types = element.Elements.Select(child => Walk<Ast.Type>(child));

            element.Value = new TypeList(types);
        }

        protected override void Visit(CPackageQualifiedType element)
        {
            WalkChildren(element);
        }

        protected override void Visit(CEntryType element)
        {
            WalkChildren(element);
        }

        protected override void Visit(CIntersectionTypeCore element)
        {
            WalkChildren(element);

            //TODO: Visitor
            element.Value = new Ast.Type();
        }

        protected override void Visit(CUnionTypeCore element)
        {
            var left = Walk<Ast.Type>(element.UnionType);
            var right = Walk<Ast.Type>(element.IntersectionType);

            element.Value = new Ast.Type.Union(left, right);
        }

        protected override void Visit(CIterableType element)
        {
            WalkChildren(element);
        }

        protected override void Visit(CGroupedType element)
        {
            WalkChildren(element);
        }

        protected override void Visit(CTupleType element)
        {
            WalkChildren(element);

            //TODO: Visitor
            element.Value = new Ast.Type();
        }

        protected override void Visit(CArrayType element)
        {
            WalkChildren(element);
        }

        protected override void Visit(CNullableType element)
        {
            WalkChildren(element);
        }

        protected override void Visit(CFunctionType element)
        {
            WalkChildren(element);
        }

        protected override void Visit(CVariancedType element)
        {
            WalkChildren(element);
        }

        protected override void Visit(CVariadicUnionType element)
        {
            WalkChildren(element);
        }

        protected override void Visit(CSpreadType element)
        {
            WalkChildren(element);
        }

        protected override void Visit(CFunctionExpressionType element)
        {
            WalkChildren(element);
        }

        protected override void Visit(CDefaultedTypeList element)
        {
            WalkChildren(element);
        }

        protected override void Visit(CTypeParameters element)
        {
            WalkChildren(element);
        }

        protected override void Visit(CTypeParameterList element)
        {
            WalkChildren(element);
        }

        protected override void Visit(CTypeParameter element)
        {
            WalkChildren(element);
        }
    }
}

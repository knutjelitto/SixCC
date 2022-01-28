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
            WalkChildrenTodo(element);
        }

        protected override void Visit(CTypeConstraint element)
        {
            WalkChildrenTodo(element);
        }

        protected override void Visit(CCaseTypes element)
        {
            WalkChildrenTodo(element);
        }

        protected override void Visit(CCaseTypeList element)
        {
            WalkChildrenTodo(element);
        }

        protected override void Visit(CQualifiedCaseType element)
        {
            WalkChildrenTodo(element);
        }

        protected override void Visit(CTypeDefault element)
        {
            WalkChildrenTodo(element);
        }

        protected override void Visit(CTypePath element)
        {
            //TODO: Type
            element.Value = new Ast.Typo();
        }

        protected override void Visit(CUnionTypeList element)
        {
            var types = element.Elements.Select(child => Walk<Ast.Typo>(child));

            element.Value = new TypeList(types);
        }

        protected override void Visit(CPackageQualifiedType element)
        {
            WalkChildrenTodo(element);
        }

        protected override void Visit(CEntryType element)
        {
            var left = Walk<Ast.Typo>(element.UnionType);
            var op = element.Literal.GetText();
            var right = Walk<Ast.Typo>(element.UnionType2);

            element.Value = new Ast.Typo.Infix(left, op, right);
        }

        protected override void Visit(CIntersectionTypeCore element)
        {
            var left = Walk<Ast.Typo>(element.IntersectionType);
            var op = element.Literal.GetText();
            var right = Walk<Ast.Typo>(element.PrimaryType);

            element.Value = new Ast.Typo.Infix(left, op, right);
        }

        protected override void Visit(CUnionTypeCore element)
        {
            var left = Walk<Ast.Typo>(element.UnionType);
            var op = element.Literal.GetText();
            var right = Walk<Ast.Typo>(element.IntersectionType);

            element.Value = new Ast.Typo.Infix(left, op, right);
        }

        protected override void Visit(CIterableType element)
        {
            // '{'
            var type = Walk<Ast.Typo>(element.VariadicType);
            element.Value = new Typo.Iterable(type);
            // '}'
        }

        protected override void Visit(CGroupedType element)
        {
            // '<'
            element.Value = Walk<Ast.Typo>(element.Type);
            // '>'
        }

        protected override void Visit(CTupleType element)
        {
            WalkChildrenTodo(element);

            //TODO
            element.Value = new Ast.Typo();
        }

        protected override void Visit(CArrayType element)
        {
            WalkChildrenTodo(element);

            //TODO
            element.Value = new Ast.Typo();
        }

        protected override void Visit(CNullableType element)
        {
            var type = Walk<Typo>(element.PrimaryType);
            var op = element.Literal.GetText();

            element.Value = new Typo.Postfix(type, op);
        }

        protected override void Visit(CFunctionType element)
        {
            WalkChildrenTodo(element);
        }

        protected override void Visit(CVariancedType element)
        {
            WalkChildrenTodo(element);
        }

        protected override void Visit(CVariadicUnionType element)
        {
            var left = Walk<Ast.Typo>(element.UnionType);
            var op = element.VariadicOperator.GetText();

            element.Value = new Ast.Typo.Postfix(left, op);
        }

        protected override void Visit(CSpreadType element)
        {
            WalkChildrenTodo(element);
        }

        protected override void Visit(CFunctionExpressionType element)
        {
            WalkChildrenTodo(element);
        }

        protected override void Visit(CDefaultedTypeList element)
        {
            WalkChildrenTodo(element);
        }

        protected override void Visit(CTypeParameters element)
        {
            WalkChildrenTodo(element);
        }

        protected override void Visit(CTypeParameterList element)
        {
            WalkChildrenTodo(element);
        }

        protected override void Visit(CTypeParameter element)
        {
            WalkChildrenTodo(element);
        }
    }
}

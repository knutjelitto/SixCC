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
            var instantiation = Walk<Instantiation>(element.ClassInstantiation);

            element.Value = new Extended(instantiation);
        }

        protected override void Visit(CClassInstantiation element)
        {
            //TODO
            var @class = Walk<QualifiedClass>(element.QualifiedClass);
            var arguments = Walk<ArgumentList>(element.Arguments);

            element.Value = new Instantiation(@class, arguments);
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
            var items = element.Elements.Select(child => Walk<TypeReference>(child));
            var path = new TypePath(items);

            element.Value = path;
        }

        protected override void Visit(CUnionTypeList element)
        {
            var types = element.Elements.Select(child => Walk<Typo>(child));

            element.Value = new TypeList(types);
        }

        protected override void Visit(CPackageQualifiedType element)
        {
            WalkChildrenTodo(element);
        }

        protected override void Visit(CEntryType element)
        {
            var left = Walk<Typo>(element.UnionType);
            var op = element.Literal.GetText();
            var right = Walk<Typo>(element.UnionType2);

            element.Value = new Typo.Infix(left, op, right);
        }

        protected override void Visit(CIntersectionTypeCore element)
        {
            var left = Walk<Typo>(element.IntersectionType);
            var op = element.Literal.GetText();
            var right = Walk<Typo>(element.PrimaryType);

            element.Value = new Typo.Infix(left, op, right);
        }

        protected override void Visit(CUnionTypeCore element)
        {
            var left = Walk<Typo>(element.UnionType);
            var op = element.Literal.GetText();
            var right = Walk<Typo>(element.IntersectionType);

            element.Value = new Typo.Infix(left, op, right);
        }

        protected override void Visit(CIterableType element)
        {
            // '{'
            var type = Walk<Typo>(element.VariadicType);
            element.Value = new Typo.Iterable(type);
            // '}'
        }

        protected override void Visit(CGroupedType element)
        {
            // '<'
            element.Value = Walk<Typo>(element.Type);
            // '>'
        }

        protected override void Visit(CTupleType element)
        {
            WalkChildrenTodo(element);

            //TODO
            element.Value = new Typo.Instance();
        }

        protected override void Visit(CArrayType element)
        {
            var primary = Walk<Typo>(element.PrimaryType);
            var number = Walk<NaturalNumber>(element.LiteralNatural);

            element.Value = new Typo.Array(primary, number);
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
            var variance = Walk<string>(element.Variance);
            var type = Walk<Typo>(element.Type);

            element.Value = new Typo.Varianced(variance, type);
        }

        protected override void Visit(CVariadicUnionType element)
        {
            var left = Walk<Typo>(element.UnionType);
            var op = element.VariadicOperator.GetText();

            element.Value = new Typo.Postfix(left, op);
        }

        protected override void Visit(CSpreadType element)
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

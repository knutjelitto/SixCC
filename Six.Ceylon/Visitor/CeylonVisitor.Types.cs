using Six.Ceylon.Ast;
using static Six.Ceylon.CeylonTree;

namespace Six.Ceylon.Visitor
{
    public partial class CeylonVisitor
    {
        protected override void Visit(CSatisfiedTypes element)
        {
            // 'satisfies'
            var types = Walk<TypeList>(element.UnionTypeList);
            element.Value = new Satisfies(types);
        }

        protected override void Visit(CExtendedType element)
        {
            // 'extends'
            var instantiation = Walk<Instantiation>(element.ClassInstantiation);

            element.Value = new Extends(instantiation);
        }

        protected override void Visit(CClassInstantiation element)
        {
            var @class = Walk<QualifiedClass>(element.QualifiedClass);
            var arguments = Walk<ArgumentList>(element.Arguments);

            element.Value = new Instantiation(@class, arguments);
        }

        protected override void Visit(CTypeConstraints element)
        {
            element.Value = new TypeConstraints(WalkMany<TypeConstraint>(element));
        }

        protected override void Visit(CTypeConstraint element)
        {
            var name = Walk<Identifier>(element.TypeName);
            var parameters = Walk<TypeParameters>(element.TypeParameters);
            var caseTypes = Walk<CaseTypes>(element.CaseTypes);
            var satisfied = Walk<Satisfies>(element.SatisfiedTypes);

            element.Value = new TypeConstraint(name, parameters, caseTypes, satisfied);
        }

        protected override void Visit(CCaseTypes element)
        {
            element.Value = new CaseTypes(Walk<TypeList>(element.CaseTypeList));
        }

        protected override void Visit(CCaseTypeList element)
        {
            element.Value = new TypeList(WalkMany<Type>(element));
        }

        protected override void Visit(CQualifiedCaseType element)
        {
            var withPackage = Exists(element.PackageQualifier);
            var name = Walk<Identifier>(element.MemberName);

            element.Value = new Type.CaseType(withPackage, name);
        }

        protected override void Visit(CTypeDefault element)
        {
            element.Value = Walk<Type>(element.Type);
        }

        protected override void Visit(CTypePath element)
        {
            element.Value = new TypePath(WalkMany<Expr.TypeReference>(element));
        }

        protected override void Visit(CUnionTypeList element)
        {
            element.Value = new TypeList(WalkMany<Type>(element));
        }

        protected override void Visit(CPackageQualifiedType element)
        {
            var path = Walk<TypePath>(element.TypePath);

            element.Value = new Type.PackageType(path);
        }

        protected override void Visit(CEntryType element)
        {
            var left = Walk<Type>(element.UnionType);
            var op = element.Literal.GetText();
            var right = Walk<Type>(element.UnionType2);

            element.Value = new Type.Entry(op, left, right);
        }

        protected override void Visit(CIntersectionTypeCore element)
        {
            var left = Walk<Type>(element.IntersectionType);
            var op = element.Literal.GetText();
            var right = Walk<Type>(element.PrimaryType);

            element.Value = new Type.Intersection(op, left, right);
        }

        protected override void Visit(CUnionTypeCore element)
        {
            var left = Walk<Type>(element.UnionType);
            var op = element.Literal.GetText();
            var right = Walk<Type>(element.IntersectionType);

            element.Value = new Type.Union(op, left, right);
        }

        protected override void Visit(CIterableType element)
        {
            // '{'
            var type = Walk<Type>(element.VariadicType);
            element.Value = new Type.Iterable(type);
            // '}'
        }

        protected override void Visit(CGroupedType element)
        {
            // '<'
            element.Value = Walk<Type>(element.Type);
            // '>'
        }

        protected override void Visit(CTupleType element)
        {
            var args = Walk<Type>(element.TypeTypeArguments) ?? new TypeList(Enumerable.Empty<Type>());

            element.Value = new Type.Tuple(args);
        }

        protected override void Visit(CArrayType element)
        {
            var primary = Walk<Type>(element.PrimaryType);
            var number = Walk<NaturalNumber>(element.LiteralNatural);

            element.Value = new Type.Array(primary, number);
        }

        protected override void Visit(CNullableType element)
        {
            var type = Walk<Type>(element.PrimaryType);

            element.Value = new Type.Nullable(type);
        }

        protected override void Visit(CFunctionType element)
        {
            var type = Walk<Type>(element.PrimaryType);
            var args = Walk<Type>(element.TypeTypeArguments) ?? new TypeList(Enumerable.Empty<Type>());

            element.Value = new Type.Function(type, args);
        }

        protected override void Visit(CVariancedType element)
        {
            var variance = Walk<string>(element.Variance);
            var type = Walk<Type>(element.Type);

            element.Value = new Type.Varianced(variance, type);
        }

        protected override void Visit(CVariadicTypeCore element)
        {
            var left = Walk<Type>(element.UnionType);
            var op = element.VariadicOperator.GetText();

            element.Value = new Type.Variadic(left, op);
        }

        protected override void Visit(CSpreadType element)
        {
            var type = Walk<Type>(element.UnionType);

            element.Value = new Type.Spread(type);
        }

        protected override void Visit(CDefaultedTypeList element)
        {
            element.Value = new TypeList(WalkMany<Type>(element));
        }


        protected override void Visit(CDefaultedTypeCore element)
        {
            element.Value = new Type.Defaulted(Walk<Type>(element.Type));
        }

        protected override void Visit(CTypeParameters element)
        {
            element.Value = Walk<TypeParameters>(element.TypeParameterList);
        }

        protected override void Visit(CTypeParameterList element)
        {
            element.Value = new TypeParameters(WalkMany<TypeParameter>(element));
        }

        protected override void Visit(CTypeParameter element)
        {
            var variance = Walk<string>(element.Variance);
            var name = Walk<Identifier>(element.TypeName);
            var @default = Walk<Type>(element.TypeDefault);

            element.Value = new TypeParameter(variance, name, @default);
        }
    }
}

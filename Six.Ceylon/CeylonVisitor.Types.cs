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
            element.Value = new TypeConstraintList(WalkMany<TypeConstraint>(element));
        }

        protected override void Visit(CTypeConstraint element)
        {
            var name = Walk<Identifier>(element.TypeName);
            var parameters = Walk<TypeParameterList>(element.TypeParameters);
            var caseTypes = Walk<CaseTypes>(element.CaseTypes);
            var satisfied = Walk<Satisfied>(element.SatisfiedTypes);

            element.Value = new TypeConstraint(name, parameters, caseTypes, satisfied);
        }

        protected override void Visit(CCaseTypes element)
        {
            element.Value = new CaseTypes(Walk<TypeList>(element.CaseTypeList));
        }

        protected override void Visit(CCaseTypeList element)
        {
            element.Value = new TypeList(WalkMany<Typo>(element));
        }

        protected override void Visit(CQualifiedCaseType element)
        {
            var withPackage = element.PackageQualifier.Children.Length > 0;
            var name = Walk<Identifier>(element.MemberName);

            element.Value = new Typo.CaseType(withPackage, name);
        }

        protected override void Visit(CTypeDefault element)
        {
            element.Value = Walk<Typo>(element.Type);
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
            var path = Walk<TypePath>(element.TypePath);

            element.Value = new Typo.PackageType(path);
        }

        protected override void Visit(CEntryType element)
        {
            var left = Walk<Typo>(element.UnionType);
            var op = element.Literal.GetText();
            var right = Walk<Typo>(element.UnionType2);

            element.Value = new Typo.Entry(left, right);
        }

        protected override void Visit(CIntersectionTypeCore element)
        {
            var left = Walk<Typo>(element.IntersectionType);
            var op = element.Literal.GetText();
            var right = Walk<Typo>(element.PrimaryType);

            element.Value = new Typo.Intersection(left, right);
        }

        protected override void Visit(CUnionTypeCore element)
        {
            var left = Walk<Typo>(element.UnionType);
            var op = element.Literal.GetText();
            var right = Walk<Typo>(element.IntersectionType);

            element.Value = new Typo.Union(left, right);
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
            var args = Walk<Typo>(element.TypeTypeArguments) ?? new TypeList(Enumerable.Empty<Typo>());

            element.Value = new Typo.Tuple(args);
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
            var type = Walk<Typo>(element.PrimaryType);
            var args = Walk<Typo>(element.TypeTypeArguments) ?? new TypeList(Enumerable.Empty<Typo>());

            element.Value = new Typo.Function(type, args);
        }

        protected override void Visit(CVariancedType element)
        {
            var variance = Walk<string>(element.Variance);
            var type = Walk<Typo>(element.Type);

            element.Value = new Typo.Varianced(variance, type);
        }

        protected override void Visit(CVariadicTypeCore element)
        {
            var left = Walk<Typo>(element.UnionType);
            var op = element.VariadicOperator.GetText();

            element.Value = new Typo.Variadic(left, op);
        }

        protected override void Visit(CSpreadType element)
        {
            var type = Walk<Typo>(element.UnionType);

            element.Value = new Typo.Spread(type);
        }

        protected override void Visit(CDefaultedTypeList element)
        {
            var items = element.Elements.Select(child => Walk<Typo>(child));
            var types = new TypeList(items);

            element.Value = types;
        }


        protected override void Visit(CDefaultedTypeCore element)
        {
            var type = Walk<Typo>(element.Type);

            element.Value = new Typo.Defaulted(type);
        }

        protected override void Visit(CTypeParameters element)
        {
            element.Value = Walk<TypeParameterList>(element.TypeParameterList);
        }

        protected override void Visit(CTypeParameterList element)
        {
            element.Value = new TypeParameterList(WalkMany<TypeParameter>(element));
        }

        protected override void Visit(CTypeParameter element)
        {
            var variance = Walk<string>(element.Variance);
            var name = Walk<Identifier>(element.TypeName);
            var @default = Walk<Typo>(element.TypeDefault);

            element.Value = new TypeParameter(variance, name, @default);
        }
    }
}

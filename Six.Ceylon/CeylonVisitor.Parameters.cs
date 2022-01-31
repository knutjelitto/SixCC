using Six.Ceylon.Ast;
using static Six.Ceylon.CeylonTree;

namespace Six.Ceylon
{
    public partial class CeylonVisitor
    {
        protected override void Visit(CParameters element)
        {
            // '('
            var parameters = Walk<Parameters>(element.ParameterList) ?? new Parameters(Enumerable.Empty<Parameter>());
            // ')'

            Assert(parameters != null);
            element.Value = parameters;
        }

        protected override void Visit(CParameterList element)
        {
            var items = element.Elements.Select(child => Walk<Parameter>(child));

            element.Value = new Parameters(items);
        }

        protected override void Visit(CParameter element)
        {
            var annotations = Walk<Annotations>(element.Annotations);
            var declaration = Walk<Parameter.ParameterDeclaration>(element.ParameterDeclaration);

            element.Value = new Parameter.Declared(annotations, declaration);
        }

        protected override void Visit(CParameterReference element)
        {
            var name = Walk<Identifier>(element.MemberName);
            var specifier = Walk<Expr.Specifier.Value>(element.ValueSpecifier);

            element.Value = new Parameter.Reference(name, specifier);
        }

        protected override void Visit(CTypedValueParameter element)
        {
            var type = Walk<Type>(element.VariadicType);
            var name = Walk<Identifier>(element.MemberName);
            var specifier = Walk<Expr.Specifier.Value>(element.ValueSpecifier);

            element.Value = new Parameter.TypedValue(type, name, specifier);
        }

        protected override void Visit(CTypedFunctionParameter element)
        {
            var type = Walk<Type>(element.VariadicType);
            var name = Walk<Identifier>(element.MemberName);
            var typeParameters = Walk<TypeParameterList>(element.TypeParameters);
            var items = WalkMany<Parameters>(element.Parameters);
            var parameters = new ParametersList(items);
            var specifier = Walk<Expr.Specifier.Function>(element.FunctionSpecifier);

            element.Value = new Parameter.TypedFunction(type, name, typeParameters, parameters, specifier);
        }

        protected override void Visit(CVoidFunctionParameter element)
        {
            var name = Walk<Identifier>(element.MemberName);
            var typeParameters = Walk<TypeParameterList>(element.TypeParameters);
            var items = WalkMany<Parameters>(element.Parameters);
            var parameters = new ParametersList(items);
            var specifier = Walk<Expr.Specifier.Function>(element.FunctionSpecifier);

            element.Value = new Parameter.VoidFunction(name, typeParameters, parameters, specifier);
        }
    }
}

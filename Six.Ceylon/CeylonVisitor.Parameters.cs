using Six.Ceylon.Ast;
using static Six.Ceylon.CeylonTree;

namespace Six.Ceylon
{
    public partial class CeylonVisitor
    {
        protected override void Visit(CParameters element)
        {
            // '('
            var parameters = Walk<ParameterList>(element.ParameterList);
            // ')'

            element.Value = parameters;
        }

        protected override void Visit(CParameterList element)
        {
            var items = element.Elements.Select(child => Walk<Parameter>(child));

            element.Value = new ParameterList(items);
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
            var specifier = Walk<Expression.ValueSpecifier>(element.ValueSpecifier);

            element.Value = new Parameter.Reference(name, specifier);
        }

        protected override void Visit(CTypedValueParameter element)
        {
            var type = Walk<Typo>(element.VariadicType);
            var name = Walk<Identifier>(element.MemberName);
            var specifier = Walk<Expression.ValueSpecifier>(element.ValueSpecifier);

            element.Value = new Parameter.TypedValue(type, name, specifier);
        }
    }
}

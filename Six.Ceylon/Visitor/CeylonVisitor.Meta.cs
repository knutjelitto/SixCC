using Six.Ceylon.Ast;
using Six.Runtime.Types;
using static Six.Ceylon.CeylonTree;

namespace Six.Ceylon.Visitor
{
    public partial class CeylonVisitor
    {
        protected override void Visit(CMetaLiteral element)
        {
            element.Value = Walk<Expr.Meta>(element.MetaExpression);
        }

        protected override void Visit(CModuleLiteral element)
        {
            var path = Walk<Identifiers>(element.PackagePath);

            element.Value = new Expr.Meta.Module(path);
        }

        protected override void Visit(CPackageLiteral element)
        {
            var path = Walk<Identifiers>(element.PackagePath);

            element.Value = new Expr.Meta.Package(path);
        }

        protected override void Visit(CClassLiteral element)
        {
            var path = Walk<ReferencePath>(element.ReferencePath);

            element.Value = new Expr.Meta.Class(path);
        }

        protected override void Visit(CInterfaceLiteral element)
        {
            var path = Walk<ReferencePath>(element.ReferencePath);

            element.Value = new Expr.Meta.Interface(path);
        }

        protected override void Visit(CFunctionLiteral element)
        {
            var path = Walk<ReferencePath>(element.ReferencePath);

            element.Value = new Expr.Meta.Function(path);
        }

        protected override void Visit(CValueLiteral element)
        {
            var path = Walk<ReferencePath>(element.ReferencePath);

            element.Value = new Expr.Meta.Value(path);
        }

        protected override void Visit(CAliasLiteral element)
        {
            var path = Walk<ReferencePath>(element.ReferencePath);

            element.Value = new Expr.Meta.Alias(path);
        }

        protected override void Visit(CNewLiteral element)
        {
            var path = Walk<ReferencePath>(element.ReferencePath);

            element.Value = new Expr.Meta.New(path);
        }

        protected override void Visit(CTypeParameterLiteral element)
        {
            var path = Walk<ReferencePath>(element.ReferencePath);

            element.Value = new Expr.Meta.Given(path);
        }

        protected override void Visit(CObjectLiteral element)
        {
            var path = Walk<ReferencePath>(element.ReferencePath);

            element.Value = new Expr.Meta.Object(path);
        }

    }
}

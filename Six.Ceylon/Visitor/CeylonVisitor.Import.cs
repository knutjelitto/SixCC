using Six.Ceylon.Ast;
using static Six.Ceylon.CeylonTree;

namespace Six.Ceylon
{
    public partial class CeylonVisitor
    {
        protected override void Visit(CImports element)
        {
            var items = WalkMany<Import>(element);
            
            element.Value = new Imports(items);
        }

        protected override void Visit(CImportDeclaration element)
        {
            var path = Walk<Identifiers>(element.PackagePath);
            var elements = Walk<Import.ElementList>(element.ImportElements);

            element.Value = new Import(path, elements);
        }

        protected override void Visit(CImportElements element)
        {
            element.Value = Walk<Import.ElementList>(element.ImportElementList);
        }

        protected override void Visit(CImportElementList element)
        {
            var items = WalkMany<Import.Element>(element);

            element.Value = new Import.ElementList(items);
        }

        protected override void Visit(CImportNamed element)
        {
            var alias = Walk<Identifier>(element.ImportName);
            var name = Walk<Identifier>(element.ImportNameSpecifier);
            var elements = Walk<Import.ElementList>(element.ImportElements);

            if (name == null)
            {
                element.Value = new Import.Named(alias, null, elements);
            }
            else
            {
                element.Value = new Import.Named(name, alias, elements);
            }
        }

        protected override void Visit(CImportNameSpecifier element)
        {
            element.Value = Walk<Identifier>(element.Identifier);
        }

        protected override void Visit(CImportWildcard element)
        {
            element.Value = new Import.Wildcard();
        }
    }
}

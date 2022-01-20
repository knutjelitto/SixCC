using Six.Runtime.Types;
using static Six.Ceylon.CeylonTree;

namespace Six.Ceylon
{
    public class DeclarationVisitor : DynamicCeylonVisitor
    {
        protected override void DefaultImplementation(RNode element)
        {
            Console.WriteLine($"Type ``{element.GetType().Name}´´ not implemented");

            throw new NotImplementedException();
        }

        protected override void Visit(CXStart element)
        {
            VisitChildren(element);
        }

        protected override void Visit(CModuleDescriptor element)
        {
            // main module description
        }

        protected override void Visit(CPackageDescriptor element)
        {
            // main package description
        }

        protected override void Visit(CUnitElements element)
        {
            VisitChildren(element);
        }

        protected override void Visit(CImportDeclarations element)
        {
            VisitChildren(element);
        }

        protected override void Visit(CImportDeclaration element)
        {
        }

        protected override void Visit(CConstructorDeclaration element)
        {
        }

        protected override void Visit(CClassDeclaration element)
        {
            Walk((RNode)element.ClassDefinition);
        }

        protected override void Visit(CInterfaceDeclaration element)
        {
        }

        protected override void Visit(CAliasDeclaration element)
        {
        }

        protected override void Visit(CTypedMethodDeclaration element)
        {
        }

        protected override void Visit(CInferredMethodDeclaration element)
        {
        }

        protected override void Visit(CTypedAttributeDeclaration element)
        {
        }

        protected override void Visit(CInferredAttributeDeclaration element)
        {
        }

        protected override void Visit(CObjectDeclaration element)
        {
        }

        protected override void Visit(CSetterDeclaration element)
        {
        }

        protected override void Visit(CEnumeratedObject element)
        {
        }



        protected override void Visit(CBlockElements element)
        {
            Walk(element.ImportDeclarations);
            Walk(element.DeclarationOrStatement);
        }

        protected override void Visit(CUnclosedStatement element)
        {
            Walk((RNode)element.OpenStatement);
        }

        protected override void Visit(CSpecificationStatement element)
        {
        }

        protected override void Visit(CAssertionStatement element)
        {
        }

        protected override void Visit(CIfElseStatement element)
        {
        }
    }
}

using Six.Ceylon.Ast;
using static Six.Ceylon.CeylonTree;

namespace Six.Ceylon
{
    public partial class CeylonVisitor
    {
        protected override void Visit(CClassDeclaration element)
        {
            WalkChilden(element);

            var name = element.TypeName.GetValue<UpperIdentifier>();
        }

        protected override void Visit(CInterfaceDeclaration element)
        {
            WalkChilden(element);

            var name = element.TypeName.GetValue<UpperIdentifier>();
        }

        protected override void Visit(CAliasDeclaration element)
        {
            WalkChilden(element);

            var name = element.TypeName.GetValue<UpperIdentifier>();
        }

        protected override void Visit(CObjectDeclaration element)
        {
            WalkChilden(element);

            var name = element.MemberName.GetValue<LowerIdentifier>();
        }

        protected override void Visit(CConstructorDeclaration element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CEnumeratedObjectDeclaration element)
        {
            WalkChilden(element);

            var name = element.MemberName.GetValue<LowerIdentifier>();
        }

        protected override void Visit(CTypedMethodDeclaration element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CVoidMethodDeclaration element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CInferredMethodDeclaration element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CTypedAttributeDeclaration element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CInferredAttributeDeclaration element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CSetterDeclaration element)
        {
            WalkChilden(element);
        }
    }
}

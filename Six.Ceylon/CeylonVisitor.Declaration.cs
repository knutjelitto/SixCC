using Six.Ceylon.Ast;
using static Six.Ceylon.CeylonTree;

namespace Six.Ceylon
{
    public partial class CeylonVisitor
    {
        protected override void Visit(CClassDeclaration element)
        {
            Walk(element.Annotations);
            Walk(element.TypeName);
            Walk(element.TypeParametersOptional);
            Walk(element.ParametersOptional);
            Walk(element.CaseTypesOptional);
            Walk(element.ExtendedTypeOptional);
            Walk(element.SatisfiedTypesOptional);
            Walk(element.TypeConstraintsOptional);
            //Walk(element.ClassDefinition);

            Add(element, new Class(element.TypeName.GetId()));
        }

        protected override void Visit(CInterfaceDeclaration element)
        {
            Walk(element.Annotations);
            Walk(element.TypeName);

            Walk(element.TypeParametersOptional);
            Walk(element.CaseTypesOptional);
            Walk(element.SatisfiedTypesOptional);
            Walk(element.TypeConstraintsOptional);
            //Walk(element.InterfaceDefinition);

            Add(element, new Interface(element.TypeName.GetId()));
        }

        protected override void Visit(CAliasDeclaration element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CObjectDeclaration element)
        {
            Walk(element.Annotations);
            Walk(element.MemberName);

            Walk(element.ExtendedTypeOptional);
            Walk(element.SatisfiedTypesOptional);
            //Walk(element.Block);

            Add(element, new Ast.Object(element.MemberName.GetId()));
        }

        protected override void Visit(CConstructorDeclaration element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CEnumeratedObjectDeclaration element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CTypedMethodDeclaration element)
        {
            Walk(element.Annotations);
            Walk(element.VariadicType);
            Walk(element.MemberName);

            using (World.Use(Add(element, new Method(element.MemberName.GetId()))))
            {
                Walk(element.TypeParametersOptional);
                Walk(element.ParametersPlus);
                Walk(element.TypeConstraintsOptional);
                Walk(element.MethodDefinition);
            }
        }

        protected override void Visit(CVoidMethodDeclaration element)
        {
            Walk(element.Annotations);
            // 'void'
            Walk(element.MemberName);
            Walk(element.TypeParametersOptional);
            Walk(element.ParametersPlus);
            Walk(element.TypeConstraintsOptional);
            //Walk(element.MethodDefinition);

            Add(element, new Method(element.MemberName.GetId()));
        }

        protected override void Visit(CInferredMethodDeclaration element)
        {
            Walk(element.Annotations);
            // 'function'
            Walk(element.MemberName);
            Walk(element.TypeParametersOptional);
            Walk(element.ParametersPlus);
            Walk(element.TypeConstraintsOptional);
            //Walk(element.MethodDefinition);

            Add(element, new Method(element.MemberName.GetId()));
        }

        protected override void Visit(CTypedAttributeDeclaration element)
        {
            Walk(element.Annotations);
            Walk(element.VariadicType);
            Walk(element.MemberName);
            //Walk(element.AttributeDefinition);

            Add(element, new Ast.Attribute(element.MemberName.GetId()));
        }

        protected override void Visit(CInferredAttributeDeclaration element)
        {
            Walk(element.Annotations);
            /* 'value' */
            Walk(element.MemberName);
            //Walk(element.AttributeDefinition);

            Add(element, new Ast.Attribute(element.MemberName.GetId()));
        }

        protected override void Visit(CSetterDeclaration element)
        {
            WalkChilden(element);
        }
    }
}

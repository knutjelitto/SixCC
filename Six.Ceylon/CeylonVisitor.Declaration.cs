using Six.Ceylon.Ast;
using static Six.Ceylon.CeylonTree;

namespace Six.Ceylon
{
    public partial class CeylonVisitor
    {
        protected override void Visit(CAliasDeclaration element)
        {
            Walk(element.Annotations);
            // 'alias'
            var name = Walk<Identifier>(element.TypeName);

            using (Use(element, new Alias(name)))
            {
                Walk(element.TypeParameters);
                Walk(element.TypeConstraints);
                Walk(element.OptionalTypeSpecifier);
            }
        }

        protected override void Visit(CClassDeclaration element)
        {
            Walk(element.Annotations);
            var name = Walk<Identifier>(element.TypeName);

            using (Use(element, new Class(name)))
            {
                //TODO: uncomment
                //Walk(element.TypeParametersOptional);
                //Walk(element.ParametersOptional);
                //Walk(element.CaseTypesOptional);
                //Walk(element.ExtendedTypeOptional);
                var satisfied = Walk<Satisfied>(element.SatisfiedTypes);
                //Walk(element.TypeConstraintsOptional);
                Walk(element.ClassDefinition);
            }
        }

        protected override void Visit(CInterfaceDeclaration element)
        {
            Walk(element.Annotations);
            var name = Walk<Identifier>(element.TypeName);

            using (Use(element, new Interface(name)))
            {
                //TODO: uncomment
                //Walk(element.TypeParametersOptional);
                //Walk(element.CaseTypesOptional);
                var satisfied = Walk<Satisfied>(element.SatisfiedTypes);
                //Walk(element.TypeConstraintsOptional);
                Walk(element.InterfaceDefinition);
            }
        }

        protected override void Visit(CObjectDeclaration element)
        {
            Walk(element.Annotations);
            var name = Walk<Identifier>(element.MemberName);

            using (Use(element, new Ast.Object(name)))
            {
                //TODO: uncomment
                //Walk(element.ExtendedTypeOptional);
                var satisfied = Walk<Satisfied>(element.SatisfiedTypes);
                Walk(element.Block);
            }
        }

        protected override void Visit(CConstructorDeclaration element)
        {
            Walk(element.Annotations);
            // 'new'
            var name = Walk<Identifier>(element.MemberName);

            using (Use(element, new Constructor(name)))
            {
                //TODO: uncomment
                Walk(element.Parameters);
                Walk(element.DelegatedConstructor);
                Walk(element.Block);
            }
        }

        protected override void Visit(CEnumeratedObjectDeclaration element)
        {
            Walk(element.Annotations);
            // 'new'
            var name = Walk<Identifier>(element.MemberName);

            using (Use(element, new Enumerated(name)))
            {
                Walk(element.DelegatedConstructor);
                Walk(element.Block);
            }
        }

        protected override void Visit(CTypedMethodDeclaration element)
        {
            Walk(element.Annotations);
            Walk(element.VariadicType);
            var name = Walk<Identifier>(element.MemberName);

            using (Use(element, new Method(name)))
            {
                //TODO: Visitor
                //Walk(element.TypeParametersOptional);
                //Walk(element.ParametersPlus);
                //Walk(element.TypeConstraintsOptional);
                Walk(element.MethodDefinition);
            }
        }

        protected override void Visit(CVoidMethodDeclaration element)
        {
            Walk(element.Annotations);
            // 'void'
            var name = Walk<Identifier>(element.MemberName);

            using (Use(element, new Method(name)))
            {
                //TODO: Visitor
                //Walk(element.TypeParametersOptional);
                //Walk(element.ParametersPlus);
                //Walk(element.TypeConstraintsOptional);
                Walk(element.MethodDefinition);
            }
        }

        protected override void Visit(CInferredMethodDeclaration element)
        {
            Walk(element.Annotations);
            // 'function'
            var name = Walk<Identifier>(element.MemberName);

            using (Use(element, new Method(name)))
            {
                //TODO: Visitor
                //Walk(element.TypeParametersOptional);
                //Walk(element.ParametersPlus);
                //Walk(element.TypeConstraintsOptional);
                Walk(element.MethodDefinition);
            }
        }

        protected override void Visit(CTypedAttributeDeclaration element)
        {
            Walk(element.Annotations);
            Walk(element.VariadicType);
            var name = Walk<Identifier>(element.MemberName);

            using (Use(element, new Ast.Attribute(name)))
            {
                Walk(element.AttributeDefinition);
            }
        }

        protected override void Visit(CInferredAttributeDeclaration element)
        {
            Walk(element.Annotations);
            // 'value'
            var name = Walk<Identifier>(element.MemberName);

            using (Use(element, new Ast.Attribute(name)))
            {
                Walk(element.AttributeDefinition);
            }
        }

        protected override void Visit(CSetterDeclaration element)
        {
            WalkChildrenTodo(element);
        }
    }
}
